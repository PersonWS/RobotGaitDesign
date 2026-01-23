using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanFDAdapterMain_CanAlyst2 : CanFDAdapterMain
    {
        CanAdapterEntity_CanAlyst2 _canAdapterEntity_CanAlyst2;

        VCI_BOARD_INFO? _VCI_BOARD_INFOS = null;

        static UInt32 m_devtype = 4;//USBCAN2

        UInt32 m_bOpen = 0;
        UInt32 m_canind = 0;
        /// <summary>
        /// 接收到的数据
        /// </summary>
        VCI_CAN_OBJ[] m_recobj = new VCI_CAN_OBJ[1000];

        Thread _receivedThread;
        /// <summary>
        /// 开始建立连接的时间
        /// </summary>
        DateTime m_ConnecTime;
        /// <summary>
        /// 是否继续接收数据
        /// </summary>
        bool _isReceivedContinue = false;
        /// <summary>
        /// can分析仪的基础信息
        /// </summary>
        public VCI_BOARD_INFO? VCI_BOARD_INFOS { get => _VCI_BOARD_INFOS; set => _VCI_BOARD_INFOS = value; }
        /// <summary>
        /// 通道总数
        /// </summary>
        int channelSum = 1;

        public CanFDAdapterMain_CanAlyst2(CanAdapterEntity canAdapterEntity) : base(canAdapterEntity)
        {
            _canAdapterEntity_CanAlyst2 = (CanAdapterEntity_CanAlyst2)canAdapterEntity;
            if (_canAdapterEntity_CanAlyst2 == null)
            {
                log.Error($"CanFDAdapterMain_CanAlyst2 传递的canAdapterEntity类型错误！传递的类型为：{canAdapterEntity.GetType().Name}");
                _canAdapterEntity_CanAlyst2 = new CanAdapterEntity_CanAlyst2(0, 0);
            }
            Ini();
        }
        ~CanFDAdapterMain_CanAlyst2()
        {
            if (_receivedThread != null)
            {
                _isReceivedContinue = false;
                Thread.Sleep(50);
                _receivedThread.Abort();
                _receivedThread = null;
            }
        }

        private void Ini()
        {
            _receivedThread = new Thread(ReceivedPool);
            _receivedThread.IsBackground = true;
            _receivedThread.Name = "ReceivedPool";
            _receivedThread.Start();
        }

        public override bool Connect(int canChannelID = 0, int reserved = 0)
        {
            lock (_lock)
            {

                bool ret = false;
                if (m_bOpen == 1)
                {
                    CanAlyst2_Interope.VCI_CloseDevice(this._canAdapterEntity_CanAlyst2.DeviceType, this._canAdapterEntity_CanAlyst2.DeviceIndex);
                    m_bOpen = 0;
                }

                int ret1 = CanAlyst2_Interope.VCI_OpenDevice(this._canAdapterEntity_CanAlyst2.DeviceType, this._canAdapterEntity_CanAlyst2.DeviceIndex, 0);
                if (ret1 == 0)
                {
                    log.Error($"打开设备失败,请检查设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex}是否正确");
                    return false;
                }
                else if (ret1 == -1)
                {

                    log.Error($"该设备不存在或已离线,设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex}");
                    return false;
                }
                else
                {
                    m_ConnecTime = DateTime.UtcNow;
                    log.Info($"设备连接成功,设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex}");
                }

                m_bOpen = 1;

                //打开CAN通道

                if (this._VCI_BOARD_INFOS != null)
                {
                    channelSum = _VCI_BOARD_INFOS.Value.can_Num;
                }
                channelSum = 1;
                for (int i = 0; i < channelSum; i++)
                {
                    ///初始化
                    VCI_INIT_CONFIG vCI_INIT_CONFIG = _canAdapterEntity_CanAlyst2.Vci_INIT_CONFIG;
                    ret1 = CanAlyst2_Interope.VCI_InitCAN(this._canAdapterEntity_CanAlyst2.DeviceType, this._canAdapterEntity_CanAlyst2.DeviceIndex, (uint)i, ref vCI_INIT_CONFIG);
                    if (ret1 == 0)
                    {
                        log.Error($"初始化设备失败,请检查设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex},CAN通道:{i}是否正确");
                        return false;
                    }
                    else if (ret1 == -1)
                    {

                        log.Error($"初始化设备失败，该设备不存在或已离线,设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex},CAN通道:{i}");
                        return false;
                    }
                    else
                    {
                        log.Info($"初始化设备成功,设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex},CAN通道:{i}");
                    }
                    ret1 = CanAlyst2_Interope.VCI_StartCAN(this._canAdapterEntity_CanAlyst2.DeviceType, this._canAdapterEntity_CanAlyst2.DeviceIndex, (uint)i);
                    if (ret1 == 0)
                    {
                        log.Error($"打开CAN通道:{i} 失败,请检查设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex}是否正确");
                        continue;
                    }
                    else if (ret1 == -1)
                    {

                        log.Error($"打开CAN通道:{i} 失败, 该设备不存在或已离线,设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex}");
                        continue;
                    }
                    else
                    {
                        log.Info($"打开CAN通道:{i} 成功, 设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex}");
                    }
                }

                ret = ret1 == 1 ? true : false;

                AfterConnect(ret);
                return ret;
            }
        }

        public override void AfterConnect(bool isConnectSuccess)
        {
            if (isConnectSuccess)
            {
                _isReceivedContinue = true;

                Ini();//启动接收线程
            }
        }

        private void ReceivedPool()
        {
            while (_isReceivedContinue)
            {
                ReceivedPoolSub();
                CommonUtility.ThreadHelper.ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(10);
            }
        }
        /// <summary>
        /// 轮询缓存区是否收到了数据
        /// </summary>
        private void ReceivedPoolSub()
        {
            List<CanAdapterReceivedDataEntity> dataList = new List<CanAdapterReceivedDataEntity>();
            try
            {
                Int32 res = 0;

                res = CanAlyst2_Interope.VCI_Receive(this._canAdapterEntity_CanAlyst2.DeviceType, this._canAdapterEntity_CanAlyst2.DeviceIndex, m_canind, m_recobj, 1000, 100);

                if (res == 0xFFFFFFFF || res == 0)
                { return; };//当设备未初始化时，返回0xFFFFFFFF，不进行列表显示。

                for (UInt32 i = 0; i < res; i++)
                {
                    //格式化报文
                    List<byte> bytes = new List<byte>();
                    //Array.Reverse(m_recobj[i].ID);
                    bytes.AddRange(m_recobj[i].ID);
                    bytes.AddRange(new byte[] { 0, 0, 0, (byte)m_recobj[i].DataLen });
                    bytes.AddRange(m_recobj[i].Data);
                    dataList.Add(new CanAdapterReceivedDataEntity(bytes.ToArray(), DateTime.Now));
                    //dataList.Add(new CanAdapterReceivedDataEntity(bytes.ToArray(), this.m_ConnecTime.AddMilliseconds(m_recobj[i].TimeStamp/10)));
                }
                base.MessageReceiveEventExecute(dataList);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public override int Send(List<byte[]> sendList)
        {
            if (m_bOpen == 0)
            {
                return -1;
            }
            int sendCount = 0;
            //int ret = _comServer.SendDataASync(sendList);
            List<CanAdapterReceivedDataEntity> list = new List<CanAdapterReceivedDataEntity>();
            foreach (byte[] send in sendList)
            {
                try
                {
                    CanAdapterReceivedDataEntity aaa = new CanAdapterReceivedDataEntity(send, DateTime.Now, 0);
                    list.Add(aaa);
                }
                catch (Exception ex)
                {
                    Log.log.Error($"sendError , ex:{ex.ToString()}");
                }
            }
            return this.Send(list);
        }

        public override int Send(List<CanAdapterReceivedDataEntity> sendList)
        {
            if (m_bOpen == 0)
            {
                return -1;
            }
            int sendCount = 0;
            //int ret = _comServer.SendDataASync(sendList);

            foreach (CanAdapterReceivedDataEntity send in sendList)
            {
                try
                {
                    //格式化发给can分析仪的数据

                    VCI_CAN_OBJ sendobj = new VCI_CAN_OBJ();
                    //sendobj.Init();
                    sendobj.RemoteFlag = (byte)0;
                    sendobj.ExternFlag = (byte)1;
                    sendobj.ID = send.Data.Skip(0).Take(4).ToArray();
                    Array.Reverse(sendobj.ID);
                    sendobj.DataLen = send.Data[4];
                    sendobj.Data = send.Data.Skip(5).Take(sendobj.DataLen).ToArray();
                    int ret = CanAlyst2_Interope.VCI_Transmit(_canAdapterEntity_CanAlyst2.DeviceType, _canAdapterEntity_CanAlyst2.DeviceIndex, (uint)send.Channel, ref sendobj, 1);
                    if ( ret== 1)
                    {
                        log.Debug($"CAN发送成功:{BitConverter.ToString(send.Data)}, index:{this._canAdapterEntity_CanAlyst2.DeviceIndex}，channel:{send.Channel}");
                       
                    }
                    else
                    {
                        log.Error($"CAN发送数据失败,设备类型:{this._canAdapterEntity_CanAlyst2.DeviceType}，设备索引号:{this._canAdapterEntity_CanAlyst2.DeviceIndex}，通道:{send.Channel}, ret:{ret}!");
                    }
                    sendCount += 1;
                }
                catch (Exception ex)
                {
                    Log.log.Error($"sendError , ex:{ex.ToString()}");
                }
            }
            return sendCount;
        }


        public override void DisConnect()
        {
            lock (_lock)
            {
                if (m_bOpen == 1)
                {
                    for (uint i = 0; i < channelSum; i++)
                    {
                        CanAlyst2_Interope.VCI_ResetCAN(_canAdapterEntity_CanAlyst2.DeviceType, _canAdapterEntity_CanAlyst2.DeviceIndex, i);
                    }
                    m_bOpen = 0;
                }
            }


        }



    }
}
