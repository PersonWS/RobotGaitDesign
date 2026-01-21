using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public class Motor_BaseInfo
    {
        public byte ID;
        public Enum_MotorType Type;
        private string _version;
        public string Version { get { return _version; } }
        private byte[] _versionBytes = new byte[4];
        public byte[] VersionBytes
        {
            set
            {
                if (value != null && value.Length == 4)
                {
                    _versionBytes = value;
                    _version = $"{_versionBytes[0]}.{_versionBytes[1]}.{_versionBytes[2]}.{_versionBytes[3]}";
                }
                else
                {
                    Log.log.Error($"VersionBytes设定错误，长度不为4或者实例为空");
                }
            }
            get { return _versionBytes; }
        }
        /// <summary>
        /// 电机对应的CAN盒子所使用的通道号
        /// </summary>
        public int AdapterChannelID;

        public Motor_BaseInfo() { }
        public Motor_BaseInfo(byte id, Enum_MotorType type)
        {
            this.ID = id;
            this.Type = type;
        }
    }
}
