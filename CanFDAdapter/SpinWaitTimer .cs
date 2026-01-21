using CommonUtility.ThreadHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class SpinWaitTimer : IDisposable
    {
        private readonly Thread _timerThread;
        private volatile bool _isRunning = true;
        private readonly long _intervalTicks;
        private readonly Stopwatch _stopwatch = new Stopwatch();

        public SpinWaitTimer(int intervalMilliseconds)
        {
            _intervalTicks = intervalMilliseconds * Stopwatch.Frequency / 1000;
            _timerThread = new Thread(TimerWorker)
            {
                IsBackground = true,
                Priority = ThreadPriority.Highest  // 提高优先级
            };
        }

        public void Start()
        {
            _stopwatch.Start();
            _timerThread.Start();
        }

        private void TimerWorker()
        {
            long nextTriggerTime = _stopwatch.ElapsedTicks + _intervalTicks;

            while (_isRunning)
            {
                long currentTime = _stopwatch.ElapsedTicks;

                if (currentTime >= nextTriggerTime)
                {
                    try
                    {
                        OnElapsed?.Invoke(this, EventArgs.Empty);
                    }
                    catch { }

                    // 计算下一次时间（补偿任何延迟）
                    nextTriggerTime += _intervalTicks;

                    // 如果落后太多（超过2个间隔），重新同步
                    if (currentTime - nextTriggerTime > _intervalTicks * 2)
                    {
                        nextTriggerTime = currentTime + _intervalTicks;
                    }
                }
                else
                {
                    // 计算还需等待的时间
                    long remainingTicks = nextTriggerTime - currentTime;

                    if (remainingTicks > 10000) // 约0.3ms
                    {
                        // 使用短Sleep节省CPU
                        int sleepMs = (int)(remainingTicks * 1000 / Stopwatch.Frequency);
                        if (sleepMs > 0)
                        {
                            ThreadHelper.HighPrecisionDelay(Math.Min(sleepMs, 1));
                            //Thread.Sleep(Math.Min(sleepMs, 1));
                        }
                    }
                    else
                    {
                        // 短时间使用自旋等待
                        Thread.SpinWait(100);
                    }
                }
            }
        }

        public event EventHandler OnElapsed;

        public void Dispose()
        {
            _isRunning = false;
            _timerThread?.Join(1000);
        }
    }
}
