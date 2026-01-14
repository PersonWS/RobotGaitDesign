using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using LogHelper;
using Microsoft.Win32;
using System.Management;
using System.Timers;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class COM_Server
    {
        public static readonly ILogEntity log = LogHelper.EasyLogger.GetLoggerInstance_log4Net("COM_Server");
        #region 串口监听

        private SerialPort _serialPort = null;
        /// <summary>
        /// 接收到信息时回调
        /// </summary>
        internal event Action<byte[]> ReceivedMessageEvent;
        /// <summary>
        /// 总线使用率
        /// </summary>
        internal event Action<double> BusUseageRateEvent;

        string _targetCOMPort;

        int _baudRate = 9600;

        private static readonly object _lock = new object();
        #region 用于总线负载率汇报的字段
        private static readonly object _lock_report = new object();
        /// <summary>
        /// 计算1秒内传输了多少字节
        /// </summary>
        double _receivedBufferCount = 0;
        /// <summary>
        /// 上一秒的字节数
        /// </summary>
        double _receivedBufferLast = 0;


        SpinWaitTimer _timer_BusUseageRate = null;

        int _reportInterval = 500;//CAN总线上报时间间隔
        double _CAN_RateCoeff = 0;//定义了CAN的系数
        #endregion

        // public int ReportInterval { get => _reportInterval; set { _reportInterval = value; _CAN_Rate = 1000 / _reportInterval * 8 * 1.25; } }

        public COM_Server(string targetCOMPort, Int32 baudRate = 115200,Int32 reportInterval=1000)
        {
            this._targetCOMPort = targetCOMPort;
            this._baudRate = baudRate;
            this._reportInterval = reportInterval;
            _timer_BusUseageRate = new SpinWaitTimer(reportInterval);
            _timer_BusUseageRate.OnElapsed += ElapsedEventHandler;
            _timer_BusUseageRate.Start();
            _CAN_RateCoeff = 1000d / _reportInterval * 8 * 1.25;
        }
        ~COM_Server()
        {
            _timer_BusUseageRate.Dispose();
        }
        /// <summary>
        /// 开启串口监听
        /// </summary>
        internal bool StartSerialPortMonitor()
        {


            _serialPort = new SerialPort(_targetCOMPort, _baudRate);
            //设置参数
            _serialPort.PortName = _targetCOMPort; //通信端口
            _serialPort.BaudRate = _baudRate; //串行波特率
            _serialPort.DataBits = 8; //每个字节的标准数据位长度
            _serialPort.StopBits = StopBits.One; //设置每个字节的标准停止位数
            _serialPort.Parity = Parity.None; //设置奇偶校验检查协议
            _serialPort.ReadTimeout = 3000; //单位毫秒
            _serialPort.WriteTimeout = 3000; //单位毫秒
                                             //串口控件成员变量，字面意思为接收字节阀值，
                                             //串口对象在收到这样长度的数据之后会触发事件处理函数
                                             //一般都设为1
            _serialPort.ReceivedBytesThreshold = 1;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(CommDataReceived); //设置数据接收事件（监听）
            _receivedBufferCount = _receivedBufferLast = 0;
            try
            {
                _serialPort.Open(); //打开串口
                return true;
            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0},{1}", "提示信息", "串行端口打开失败！具体原因：" + ex.Message));
                return false;
            }

        }

        internal bool SendData(byte[] data)
        {
            try
            {
                _serialPort.Write(data, 0, data.Length);
                lock (_lock_report)
                {
                    _receivedBufferCount += data.Length;
                }
                return true;
            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0},{1}", "SendData", "串行发送数据失败！具体原因：" + ex.Message));
                return false;

            }
        }

        /// <summary>
        /// 串口数据处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommDataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                //Comm.BytesToRead中为要读入的字节长度
                lock (_lock)
                {
                    int len = _serialPort.BytesToRead;
                    Byte[] readBuffer = new Byte[len];
                    _serialPort.Read(readBuffer, 0, len); //将数据读入缓存
                    lock (_lock_report)
                    {
                        _receivedBufferCount += len;
                    }
#if DEBUG
                    log.Debug($"COM收到原始数据长度{len} ,单位累计长度:{_receivedBufferCount}，COM收到数据内容：{BitConverter.ToString(readBuffer)}");
#endif
                    //log.Debug(string.Format("{0},{1}", "接收到的信息 ，处理后的信息：", "", Encoding.UTF8.GetString(readBuffer)));
                    // Task.Run(() => { ReceivedMessageEvent?.Invoke(readBuffer); });
                    ReceivedMessageEvent?.Invoke(readBuffer); 
                    ////处理readBuffer中的数据，自定义处理过程
                    //string msg = Encoding.UTF8.GetString(readBuffer, 0, len); //获取出入库产品编号
                    //log.Debug(string.Format("{0},{1}", "接收到的原始信息", msg));
                }
                //System.Threading.Thread.Sleep(10);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0},{1}", "提示信息", "接收返回消息异常！具体原因：" + ex.ToString()));
            }
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        internal void Stop()
        {
            try
            {
                if (_serialPort != null)
                {
                    _serialPort.Close();
                }

            }
            catch (Exception)
            {

            }

        }



        #endregion 串口监听


        /// <summary>
        /// 获取本机串口列表
        /// </summary>
        /// <param name="isUseReg">是否使用注册表信息，默认不传，使用默认值</param>
        /// <returns></returns>
        public static List<string> GetComlist(bool isUseReg = false)
        {
            List<string> list = new List<string>();
            try
            {
                if (isUseReg)
                {
                    RegistryKey RootKey = Registry.LocalMachine;
                    RegistryKey Comkey = RootKey.OpenSubKey(@"HARDWARE\DEVICEMAP\SERIALCOMM");

                    String[] ComNames = Comkey.GetValueNames();

                    foreach (String ComNamekey in ComNames)
                    {
                        string TemS = Comkey.GetValue(ComNamekey).ToString();
                        list.Add(TemS);
                    }
                }
                else
                {
                    foreach (string com in SerialPort.GetPortNames())  //自动获取串行口名称  
                        list.Add(com);
                }
            }
            catch
            {
                log.Error(string.Format("{0},{1}", "提示信息", "串行端口检查异常！"));
                System.Environment.Exit(0); //彻底退出应用程序   
            }
            return list;
        }

        public static Dictionary<string, string> GetComPortsWithNames()
        {
            var comPorts = new Dictionary<string, string>();

            try
            {
                // 方法1: 使用WMI查询（推荐，最简单）
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                    "SELECT DeviceID, Description, Caption FROM  Win32_PnPEntity WHERE PNPClass = 'Ports' OR PNPClass = 'SerialPort'");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string portName = queryObj["Caption"]?.ToString();
                    portName = portName.Substring(portName.IndexOf('(') + 1, portName.LastIndexOf(')') - portName.IndexOf('(') - 1);
                    string description = queryObj["Caption"]?.ToString() ??
                                       queryObj["DeviceID"]?.ToString() ??
                                       "Serial Device";

                    if (!string.IsNullOrEmpty(description))
                    {
                        if (!comPorts.Keys.Contains(description))
                        {
                            comPorts.Add(description, portName);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                // 如果WMI查询失败，回退到基本方法
                Console.WriteLine($"WMI查询失败: {ex.Message}");

                try
                {
                    // 方法2: 获取端口后附加默认描述
                    foreach (string port in SerialPort.GetPortNames())
                    {
                        comPorts.Add(port, $"{port}");
                    }
                }
                catch
                {
                    // 如果都失败，记录错误
                    log.Error("获取串口列表失败");
                }
            }

            return comPorts;
        }
        /// <summary>
        /// 获取串口名称和描述
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetComListDic()
        {
            var result = new Dictionary<string, string>();

            try
            {
                // 获取所有COM端口
                string[] ports = GetComlist(false).ToArray();

                foreach (string port in ports)
                {
                    // 尝试获取描述，如果没有则使用默认
                    string description = GetSimplePortDescription(port);
                    result[port] = description;
                }
            }
            catch (Exception ex)
            {
                log.Error($"获取串口列表失败: {ex.Message}");
            }

            return result;
        }

        private static string GetSimplePortDescription(string port)
        {
            try
            {
                // 简化版的描述获取
                if (port.Contains("COM"))
                {
                    return $"Serial Port {port}";
                }
            }
            catch
            {
                // 忽略错误
            }

            return "Unknown Serial Device";
        }


        public void ElapsedEventHandler(object sender, EventArgs e)
        {
            if (BusUseageRateEvent != null)
            {
                double rate = 0;
                double temp;
                lock (_lock)
                {
                    temp = _receivedBufferLast;
                    _receivedBufferLast = _receivedBufferCount;
                }
                rate = (_receivedBufferCount - temp) * _CAN_RateCoeff / _baudRate;//40=2*8,，再乘以1.25的填充位
                //log.Debug($"canRate:{rate}, interval:{_reportInterval}");
                BusUseageRateEvent(rate);
                //Task.Run(() => { BusUseageRateEvent(rate); });
            }
        }




    }
}
