using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using LogHelper;

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
        internal event Action<byte[]> ReceivedMessage;



        string _targetCOMPort;

        int _baudRate = 9600;


        public COM_Server(string targetCOMPort, Int32 baudRate = 115200)
        {
            this._targetCOMPort = targetCOMPort;
            this._baudRate = baudRate;
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
                //_serialPort.Write(data, 0, data.Length);
                //查找截止及开始符号
               // byte[] readBuffer = new byte[] { 0X02, 0X2B, 0X30, 0X30, 0X30, 0X30, 0X38, 0X30, 0X30, 0X31, 0X33, 0X03 };//+000080013
               //// byte[] readBuffer = new byte[] { 0X02, 0X2B, 0X30, 0X30, 0X30, 0X30, 0X30, 0X30, 0X30, 0X31, 0X42, 0X03 };//+000080013
               // int start = 0, end = 0;
               // if (ReceivedMessage != null)
               // {

               //     Utils.ErrorLog_custom(string.Format("{0},{1}", "接收到的信息 ，接收到原始数据", "", Encoding.UTF8.GetString(readBuffer)));
               //     ReceivedMessage(readBuffer);
               // }

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
                System.Threading.Thread.Sleep(100);
                //Comm.BytesToRead中为要读入的字节长度
                int len = _serialPort.BytesToRead;
                Byte[] readBuffer = new Byte[len];

                _serialPort.Read(readBuffer, 0, len); //将数据读入缓存
                log.Debug($"原始数据：{BitConverter.ToString(readBuffer)}");
                if (ReceivedMessage != null)
                {

                    //log.Debug(string.Format("{0},{1}", "接收到的信息 ，处理后的信息：", "", Encoding.UTF8.GetString(readBuffer)));
                    ReceivedMessage(readBuffer);
                }
                ////处理readBuffer中的数据，自定义处理过程
                //string msg = Encoding.UTF8.GetString(readBuffer, 0, len); //获取出入库产品编号
                //log.Debug(string.Format("{0},{1}", "接收到的原始信息", msg));
            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0},{1}", "提示信息", "接收返回消息异常！具体原因：" + ex.Message));
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

    }
}
