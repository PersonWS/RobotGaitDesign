using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using LogHelper;
using System.IO.Ports;
using CanFDAdapter;

namespace CanFDAdapter
{
    public class CanFDAdapterMain
    {
        public static readonly ILogEntity log = LogHelper.EasyLogger.GetLoggerInstance_log4Net("CanFDAdapterMain");
        /// <summary>
        /// 服务器
        /// </summary>
        COM_Server _server;
        bool _isConnected = false;

        public event Action<byte[]> MessageReceiveEvent;

        /// <summary>
        /// 接收处理后的信息   bool  1：稳定  0：不稳定  int:公斤数
        /// </summary>
        public event Action<bool, int> ReceivedMessage_Stand;

        CanAdapterEntity _canAdapterEntity;

        public CanAdapterEntity CanAdapterEntity { get => _canAdapterEntity; }


        CanAdapterDataProcess _canAdapterDataProcess;
        public CanAdapterDataProcess CanAdapterDataProcess { get => _canAdapterDataProcess; }
        /// <summary>
        /// 构造 地磅连接
        /// </summary>
        /// <param name="targetCOM">使用哪个COM口连接就填哪个 ，例如：COM1 ，则targetCOM="COM1"</param>
        /// <param name="baudRate">波特率，默认9600，无指定值可不传</param>
        public CanFDAdapterMain(CanAdapterEntity canAdapterEntity)
        {
            this._canAdapterEntity = canAdapterEntity;
            switch (canAdapterEntity.ChipType)
            {
                case CanAdapterTypeEnum.CH340:
                    _canAdapterDataProcess = new CanAdapterDataProcess_RobstrideDynamics(canAdapterEntity);
                    break;
                case CanAdapterTypeEnum.ch341:

                    _canAdapterDataProcess = new CanAdapterDataProcess_BaoFengFD(canAdapterEntity);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 建立连接
        /// </summary>
        /// <returns>true：连接成功   false ：连接失败，查看日志确定错误信息</returns>
        public bool Connect()
        {
            List<string> comList = COM_Server.GetComlist(false); //首先获取本机关联的串行端口列表            
            if (comList.Count == 0)
            {
                log.Error(string.Format("{0},{1}", "提示信息：", "当前设备不存在串行端口！"));
                return false;
            }
            else if (!comList.Contains(_canAdapterEntity.ComPort)) //判断串口列表中是否存在目标串行端口
            {
                log.Error(string.Format("提示信息：当前设备不存在配置为{0}的串行端口或端口已被占用！", _canAdapterEntity.ComPort));
                return false;
            }
            else
            {
                _server = new COM_Server(_canAdapterEntity.ComPort, _canAdapterEntity.ComBaud);
                _server.ReceivedMessage += Receive;
                bool ret = _server.StartSerialPortMonitor();
                AfterConnect(ret);
                return ret;
            }
        }

        public virtual void AfterConnect(bool isConnectSuccess) { }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Send(object obj)
        {
            obj = new byte[] { 123 };
            byte[] sendArray;
            switch (obj.GetType().ToString())
            {
                case "System.String":
                    sendArray = Encoding.UTF8.GetBytes((string)obj);
                    break;
                case "System.Byte[]":
                    sendArray = obj as byte[];
                    break;
                case "System.Int16":
                    sendArray = BitConverter.GetBytes((Int16)obj);
                    break;
                case "System.Int32":
                    sendArray = BitConverter.GetBytes((Int32)obj);
                    break;
                case "System.Int64":
                    sendArray = BitConverter.GetBytes((Int32)obj);
                    break;
                case "System.Single":
                    sendArray = BitConverter.GetBytes((float)obj);
                    break;
                case "System.Double":
                    sendArray = BitConverter.GetBytes((Double)obj);
                    break;
                case "System.Decimal":
                    sendArray = BitConverter.GetBytes((float)obj);
                    break;
                default:
                    log.Error(string.Format("COM Send传入类型错误，传入类型：{0}", obj.GetType().ToString().ToLower()));
                    return false;
            }
            return _server.SendData(sendArray);
        }

        public int Send(List<byte[]> sendList)
        {
            int sendCount = 0;
            foreach (byte[] send in sendList)
            {
                try
                {
                    _server.SendData(send);
                    sendCount += send.Length;
                }
                catch (Exception ex)
                {
                    Log.log.Error($"sendError , ex:{ex.ToString()}");
                }
            }
            return sendCount;
        }

        private void Receive(byte[] b)
        {
            if (MessageReceiveEvent != null)
            {
                MessageReceiveEvent(b);
            }
            if (ReceivedMessage_Stand != null)
            {
                bool isStable = false;
                int weight = 0;
                //ReceiveMessageProcess(b, out isStable, out weight);
                //ReceivedMessage_Stand(isStable, weight);

            }
        }


        /// <summary>
        /// 断开COM连接，不用时必须要断开，否则下次就连接不上了
        /// </summary>
        public void DisConnect()
        {
            if (_server != null)
            {
                _server.ReceivedMessage -= Receive;
                _server.Stop();
                _server = null;

            }
        }



    }
}
