using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CanFDAdapter;
using CommonUtility;

namespace LZMotor
{
    /// <summary>
    /// 用于连接CAN适配器，监听CAN数据，下发CAN数据的主类
    /// </summary>
    public class LZMotorServerMain : CommonUtility.Engine.ProcessEngineBase
    {
        /// <summary>
        /// CAN适配器
        /// </summary>
        private CanFDAdapter.CanFDAdapterMain _canFDAdapterMain;
        /// <summary>
        /// 电机配置信息
        /// </summary>
        Dictionary<byte,Motor_BaseInfo> _dic_motorConfig_BaseInfos;

        /// <summary>
        /// 输出总线使用率，通过COM速率计算得到的
        /// </summary>
        public event Action<double> BusUseageRateEvent;

        /// <summary>
        /// 读取电机主动上报数据的队列
        /// </summary>
        private Queue<List<byte[]>> _motorMsgReceivedQueue;
        private readonly object _motorMsgReceivedLock = new object();
        /// <summary>
        /// 接收到的条数总数
        /// </summary>
        private int _receivedCount = 0;

        /// <summary>
        /// 处理的数量，作为线程保活的依据
        /// </summary>
        int _processCoutNew = 1;
        /// <summary>
        /// CAN FD的实例信息
        /// </summary>
        CanFDAdapter.CanAdapterEntity _canFDAdapterEntity;
        /// <summary>
        /// 是否继续处理数据
        /// </summary>
        private bool _isProcessQueueThreadContiue = false;

        public LZMotorServerMain(CanAdapterEntity canFDAdapterEntity)
        {
            this._canFDAdapterEntity = canFDAdapterEntity;
        }



        /// <summary>
        /// 连接CAN总线
        /// </summary>
        public bool Connect()
        {
            if (_canFDAdapterMain != null)
            {
                _canFDAdapterMain.BusUseageRateEvent -= BusUseageRate;
                _canFDAdapterMain.MessageReceiveEvent -= ComMessageReceived;
                _canFDAdapterMain.DisConnect();
                _canFDAdapterEntity = null;
            }

            switch (_canFDAdapterEntity.ChipType)
            {
                case CanAdapterTypeEnum.CH340:
                    _canFDAdapterMain = new CanFDAdapter.CanFDAdapterMain_RobstrideDynamics(_canFDAdapterEntity);
                    break;
                case CanAdapterTypeEnum.ch341:
                    _canFDAdapterMain = new CanFDAdapter.CanFDAdapterMain_BaoFeng(_canFDAdapterEntity);
                    break;
                default:
                    Log.Error($"unknown CanAdapterType：{_canFDAdapterEntity.ChipType}");
                    return false;
                    break;
            }

            _canFDAdapterEntity.ChipType = _canFDAdapterEntity.ChipType;
            //_canFDAdapterEntity.Description = txt_batchCan.Text;
            _canFDAdapterEntity.ComPort = _canFDAdapterEntity.ComPort;



            if (_canFDAdapterMain.Connect(500))
            {
                _isProcessQueueThreadContiue = true;
                _canFDAdapterMain.MessageReceiveEvent += ComMessageReceived;
                _canFDAdapterMain.BusUseageRateEvent += BusUseageRate;
                return true;

            }
            else
            {
                return false;
            }
        }

        public void SetMotor_BaseInfoDic(Dictionary<byte, Motor_BaseInfo> dic_motorConfig_BaseInfos)
        {
           this._dic_motorConfig_BaseInfos = dic_motorConfig_BaseInfos;
        }

        private void BusUseageRate(double rate)
        {
            //log.Debug($"canRate222:{rate}");
            BusUseageRateEvent?.Invoke(rate);

        }

        private void ComMessageReceived(List<byte[]> msg)
        {
            lock (_motorMsgReceivedLock)
            {
                _motorMsgReceivedQueue.Enqueue(msg);

                Log.Debug($"ComMessageReceivedCount:{_receivedCount++}");
            }

        }

        /*********************************************************处理COM接收到的数据主函数*******************************************************/
        public override void ProcessMethod_Customer()
        {
            _processCoutNew++;
            List<List<byte[]>> recMsg = null;
            lock (_motorMsgReceivedLock)
            {
                if (_motorMsgReceivedQueue.Count > 0)
                {
                    recMsg = _motorMsgReceivedQueue.ToList();
                    _motorMsgReceivedQueue.Clear();
                }
                else
                {
                    return;
                }
            }
            //while (_connectQueueMain.Count > 0)
            //{
            //    ProcessMethod_CustomerSub(_connectQueueMain);
            //}
            //while (_taskQueueMain.Count > 0)
            //{
            //    ProcessMethod_CustomerSub(_taskQueueMain);
            //}
        }

        private void ProcessMethod_CustomerSub(Queue<List<byte[]>> queue)
        {


        }

        public override void Dispose()
        { }


    }
}
