using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    /// <summary>
    /// 电机报文数据主类
    /// </summary>
    public class LZMotorDataMain
    {
        private Motor_Data _data_Motor;
        private Motor_ExtendData_ID _extendData_ID;

        public LZMotorDataMain(Motor_Data data_Motor, Motor_ExtendData_ID extendData_ID)
        {
            this._data_Motor = data_Motor;
            this._extendData_ID = extendData_ID;
        }

        public Motor_Data Data_Motor { get => _data_Motor; set => _data_Motor = value; }
        public Motor_ExtendData_ID ExtendData_ID { get => _extendData_ID; set => _extendData_ID = value; }
    }
}
