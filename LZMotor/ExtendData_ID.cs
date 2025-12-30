using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    /// <summary>
    /// 定义了电机的ID数据
    /// </summary>
    public class ExtendData_ID
    {
        /// <summary>
        /// 输入的数据
        /// </summary>
        byte[] _dataBytes;
        string _hexDataString;
        /// <summary>
        /// 接收信息的can  id   0-7byte
        /// </summary>
        public Byte MotorIDReceive;


        /// <summary>
        /// 发送信息的can  id  8-15 byte
        /// </summary>
        public Byte MotorIDSend;
        /// <summary>
        /// 用户自定义的值，因
        /// </summary>
        public byte UserDefineByte;
        /// <summary>
        /// 通讯类型
        /// </summary>
        public byte CommunicationTypeByte;

        public byte[] DataBytes { get => _dataBytes;  }

        public ExtendData_ID() { }
        public ExtendData_ID(byte[] dataByte)
        {
            this._dataBytes = dataByte;
            MotorIDReceive = _dataBytes[3];
            MotorIDSend = _dataBytes[2];
            UserDefineByte = _dataBytes[1];
            CommunicationTypeByte = _dataBytes[0];
        }
        public ExtendData_ID(string hexDataString)
        {
            this._hexDataString = hexDataString;
            if (string.IsNullOrEmpty(this._hexDataString))
            {
                Log.log.Error($"Data_Motor  input error ,data is null or empry");
            }
            this._hexDataString = hexDataString.Replace("0x", "").Replace(" ", "").Replace("-", "");
            if (this._hexDataString.Length > 8 || this._hexDataString.Length < 7)
            {
                Log.log.Error($"Data_ID  input error ,data:{_hexDataString}");
            }
            else
            {
                if (this._hexDataString.Length == 7)
                {
                    this._hexDataString = this._hexDataString.PadLeft(8, '0');
                }
                try
                {
                    this._dataBytes = HexStringToByteArray(this._hexDataString);
                  //  Array.Reverse(this._dataByte);
                    MotorIDReceive = _dataBytes[0];
                    MotorIDSend = _dataBytes[1];
                    UserDefineByte = _dataBytes[2];
                    CommunicationTypeByte = (byte)((byte)( _dataBytes[3]<<3)>>3);
                }
                catch (Exception ex)
                {
                    Log.log.Error($"Data_ID  input error ,data:{_hexDataString},ex:{ex.ToString()}");
                }
            }
        }





        public static byte[] HexStringToByteArray(string hex)
        {
            // 移除可能的前缀和空格
            hex = hex.Replace("0x", "").Replace(" ", "").Replace("-", "");

            // 检查长度是否为偶数
            if (hex.Length % 2 != 0)
                throw new ArgumentException("十六进制字符串长度必须为偶数");

            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return bytes;
        }









    }
}
