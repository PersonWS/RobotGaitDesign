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
        public Motor_Data data_Motor;
        public Motor_ExtendData_ID extendData_ID;
        public MotorCommunicationDataMain()
        {
            data_Motor = new Motor_Data(new byte[8]);
            extendData_ID=new Motor_ExtendData_ID(new byte[8]);
        }
        public MotorCommunicationDataMain(Motor_ExtendData_ID e ,Motor_Data d)
        {
            data_Motor = d;
            extendData_ID = e;
        }

    }
}
