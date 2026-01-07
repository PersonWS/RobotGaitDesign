using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public enum Enum_RunMode:byte
    {
        MotionControl = 0x0,
        /// <summary>
        /// pp
        /// </summary>
        PositionPosition= 0x01,
        /// <summary>
        /// 速度模式
        /// </summary>
        Torque = 0x03,
        /// <summary>
        /// CSP
        /// </summary>
        CyclicSynchronousPosition = 0x05,
    }
}
