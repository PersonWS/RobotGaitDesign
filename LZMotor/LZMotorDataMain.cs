using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public class LZMotorDataMain
    {
        private Data_Motor _data_Motor;
        private ExtendData_ID _extendData_ID;
        public LZMotorDataMain(Data_Motor data_Motor, ExtendData_ID extendData_ID)
        {
            this._data_Motor = data_Motor;
            this._extendData_ID = extendData_ID;
        }

        public Data_Motor Data_Motor { get => _data_Motor; set => _data_Motor = value; }
        public ExtendData_ID ExtendData_ID { get => _extendData_ID; set => _extendData_ID = value; }
    }
}
