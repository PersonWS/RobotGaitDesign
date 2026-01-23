using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanAdapterEntity_CanAlyst2 : CanAdapterEntity
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        UInt32 deviceType;
        /// <summary>
        /// 设备序号，用于连接用，
        /// </summary>
        UInt32 deviceInd;
        /// <summary>
        /// 通道号
        /// </summary>
        List< UInt32> channel;
        UInt32 Reserved;
        /// <summary>
        /// 初始化时候的配置文件
        /// </summary>
        VCI_INIT_CONFIG vci_INIT_CONFIG;
        public CanAdapterEntity_CanAlyst2(string comPort, int comBaud) : base(comPort, comBaud) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType">类型码 ，4:    </param>
        /// <param name="deviceInd">设备序号</param>
        /// <param name="reserved"></param>
        public CanAdapterEntity_CanAlyst2(UInt32 deviceType, UInt32 deviceInd, UInt32 reserved = 0) : base("", 0) //用于连接USB_CAN分析仪
        {
            this.deviceType = deviceType;
            this.deviceInd = deviceInd;
            this.Reserved = reserved;
            Ini_Config();
        }

        public uint DeviceType { get => deviceType; set => deviceType = value; }
        /// <summary>
        /// 设备连接索引号
        /// </summary>
        public uint DeviceIndex { get => deviceInd; set => deviceInd = value; }
        /// <summary>
        /// 连接的CAN通道号
        /// </summary>
        public List<UInt32> Channel { get => channel; set => channel = value; }
        /// <summary>
        /// 连接的配置文件
        /// </summary>
        public VCI_INIT_CONFIG Vci_INIT_CONFIG { get => vci_INIT_CONFIG; set => vci_INIT_CONFIG = value; }

        private void Ini_Config()
        {
            vci_INIT_CONFIG = new VCI_INIT_CONFIG();
            vci_INIT_CONFIG.AccCode = System.Convert.ToUInt32("0x00000000", 16);
            vci_INIT_CONFIG.AccMask = System.Convert.ToUInt32("0xFFFFFFFF", 16);
            vci_INIT_CONFIG.Timing0 = System.Convert.ToByte("0x00", 16);
            vci_INIT_CONFIG.Timing1 = System.Convert.ToByte("0x14", 16);
            vci_INIT_CONFIG.Filter = (Byte)1;
            vci_INIT_CONFIG.Mode = (Byte)0;

        }


    }



}
