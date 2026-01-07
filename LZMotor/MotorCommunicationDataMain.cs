using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    /// <summary>
    /// 
    /// </summary>
    public class MotorCommunicationDataMain
    {
        public Data_Motor data_Motor;
        public ExtendData_ID extendData_ID;
        public MotorCommunicationDataMain()
        {
            data_Motor = new Data_Motor(new byte[8]);
            extendData_ID=new ExtendData_ID(new byte[8]);
        }
        public MotorCommunicationDataMain(ExtendData_ID e ,Data_Motor d)
        {
            data_Motor = d;
            extendData_ID = e;
        }

    }
}
