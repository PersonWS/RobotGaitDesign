using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public class Motor_Data
    {
        /// <summary>
        /// 输入的数据
        /// </summary>
        byte[] _dataBytes;
        string _hexDataString;
        public byte[] DataBytes { get => _dataBytes;  }

        public Motor_Data(byte[] data)
        {
            this._dataBytes = data;
        }
        public Motor_Data(string hexDataString, int length=8)
        {
            this._hexDataString = hexDataString;
            if (string.IsNullOrEmpty(this._hexDataString))
            {
                Log.log.Error($"Data_Motor  input error ,data is null or empry");
            }
            this._hexDataString  = hexDataString.Replace("0x", "").Replace(" ", "").Replace("-", "");
            if (this._hexDataString.Length > length*2 || this._hexDataString.Length < length*2-1)
            {
                Log.log.Error($"Data_Motor  input error ,data:{_hexDataString}");
            }
            else
            {
                if (this._hexDataString.Length == length * 2 - 1)
                {
                    this._hexDataString = this._hexDataString.PadLeft(length * 2, '0');
                }
                try
                {
                    this._dataBytes = Motor_ExtendData_ID.HexStringToByteArray(this._hexDataString);
                    //Array.Reverse(this._dataByte);
                }
                catch (Exception ex)
                {
                    Log.log.Error($"Data_Motor  input error ,data:{_hexDataString},ex:{ex.ToString()}");
                }
            }

        }


    }
}
