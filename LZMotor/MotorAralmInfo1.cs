using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public enum MotorAralmInfo1:Byte
    {
        /// <summary>
        /// 欠压故障
        /// </summary>
        [Description("欠压故障")]
        lowVoltage = 1,
        [Description("三相电流故障")]
        driverError =2,
        [Description("过温")]
        highTemperature =4,
        [Description("过温")]
        encoderError =8,
        [Description("堵转过载故障")]
        lockedMotor =16,
        [Description("未标定")]
        unCalibrate =32
    }
    public enum MotorMode: Byte
    {
        Reset = 0,
        Calibrate = 1,
        Run = 2
    }
}
