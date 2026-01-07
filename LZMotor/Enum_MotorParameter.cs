using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public enum Enum_MotorParameter : Int16
    {

        /// <summary>
        /// 电流kp RW
        /// </summary>
        [Description("float")]
        cur_kp = 0x2012,
        /// <summary>
        /// 电流ki RW
        /// </summary>
        [Description("float")]
        cur_ki = 0x2013,
        /// <summary>
        /// 速度kp
        /// </summary>
        [Description("float")]
        spd_kp = 0x2014,
        /// <summary>
        /// 速度kI
        /// </summary>
        [Description("float")]
        spd_ki = 0x2015,
        /// <summary>
        /// 电机故障码1
        /// </summary>
        [Description("uint16")]
        drv_fault = 0X3025,
        /// <summary>
        /// 电机故障码2驱动芯片故障
        /// </summary>
        [Description("int16")]
        drv_temp = 0X3026,

        /// <summary>
        /// 0: 运控模式
        /// 1: 位置模式（PP）
        /// 2: 速度模式
        /// 3: 电流模式
        /// 5：位置模式（CSP）
        /// </summary>
        [Description("uint8")]
        run_mode = 0X7005,

        /// <summary>
        /// 位置kp
        /// </summary>
        [Description("float")]
        loc_kp = 0x701E,
        /// <summary>
        /// 位置模式电机目标角度指令  float
        /// </summary>
        [Description("float")]
        loc_ref_电机目标角度 = 0X7016,

        [Description("float")]
        limit_spd_csp速度限制 = 0X7017,
        /// <summary>
        /// 上报时间设置，1 代表10ms，加1 递增5ms
        /// </summary>
        [Description("unit16")]
        EPScan_time = 0x7026

    }
}
