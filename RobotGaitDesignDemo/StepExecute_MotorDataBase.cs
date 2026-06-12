using LZMotor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGaitDesignDemo
{
    /// <summary>
    /// 本类存储电机的ID，电机类型，固件版本等
    /// </summary>
    public class StepExecute_MotorDataBase
    {
        protected  byte motorID;
        protected Enum_MotorType motorType;
        protected string version;
        protected Enum_RunMode motorRunModeType;
        /// <summary>
        /// 需要发送的buffer 根据电机类型，电机运行模式等生成
        /// </summary>
        protected List<byte[]> sendBuffer;

        //public List<byte[]> GetSendBuffer(int addtionOffset)
        //{
        //    if (addtionOffset == 0)
        //    {
        //        return sendBuffer;
        //    }
        //    else
        //    { 
                
        //    }
        //}


        //protected List<byte[]> GenerateSendBuffer(Enum_RunMode runMode)
        //{
        //    List<byte[]> bytes = new List<byte[]>();
        //    switch (Enum_RunMode)
        //    {
        //        case Enum_RunMode.MotionControl:

        //            break;
        //        case Enum_RunMode.PositionPosition:
        //            break;
        //        case Enum_RunMode.Torque:
        //            break;
        //        case Enum_RunMode.CyclicSynchronousPosition:
        //            break;
        //        default:
        //            break;
        //    }
        //}

    }
}
