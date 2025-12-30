using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public enum MotorAralmInfo1:Byte
    {
        lowVoltage=1,
        driverError=2,
        highTemperature=4,
        encoderError=8,
        lockedMotor=16,
        unCalibrate=32
    }
    public enum MotorMode: Byte
    {
        Reset = 0,
        Calibrate = 1,
        Run = 2
    }
}
