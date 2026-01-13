using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LZMotor
{
    public enum Enum_MotorParameter : Int16
    {

        ///// <summary>
        ///// 电流kp RW
        ///// </summary>
        //[Description("float")]
        //cur_kp电流 = 0x2012,
        ///// <summary>
        ///// 电流ki RW
        ///// </summary>
        //[Description("float")]
        //cur_ki电流 = 0x2013,
        ///// <summary>
        ///// 速度kp
        ///// </summary>
        //[Description("float")]
        //spd_kp = 0x2014,
        ///// <summary>
        ///// 速度kI
        ///// </summary>
        //[Description("float")]
        //spd_ki = 0x2015,
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
        run_mode运行模式 = 0X7005,


        /// <summary>
        /// 转矩限制
        /// </summary>
        [Description("float")]
        limit_torque = 0x700B,

        /// <summary>
        /// 负载端计圈机械角度
        /// </summary>
        [Description("float")]
        mechPos负载端机械角度 = 0x7019,    


        /// <summary>
        /// 电流环增益
        /// </summary>
        [Description("float")]
        cur_kp电流环增益 = 0x7010,
        /// <summary>
        /// 电流环增益
        /// </summary>
        [Description("float")]
        cur_ki电流环积分 = 0x7011,



        /// <summary>
        /// loc_kp位置环增益
        /// </summary>
        [Description("float")]
        loc_kp位置环增益 = 0x701E,



        /// <summary>
        /// 
        /// </summary>
        [Description("float")]
        spd_kp速度环增益 = 0x701F,

        [Description("float")]
        spd_kI速度环积分 = 0x7020,


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
        [Description("uint16")]
        EPScan_time = 0x7026,

        /// <summary>
        /// 零点标志位，0 代表0-2π,1 代表-π-π
        /// </summary>
        [Description("uint8")]
        zero_sta零位状态 = 0x7029,

        [Description("float")]
        add_offset零位偏置 = 0x702B

    }
    public class MotorParameterValueProcess
    {
        public static T GetRealMotorParameterValueByEnumDescription<T>(Enum_MotorParameter enum_MotorParameter, byte[] Data_MotorDataBytes)
        {
            T value = default(T);
            string description = GetDescription(enum_MotorParameter);
            switch (description)
            {
                case "uint8":
                    value = (T)(object)Data_MotorDataBytes[4];
                    break;
                case "int8":
                    value = (T)(object)Data_MotorDataBytes[4];
                    break;
                case "uint16":
                    value = (T)(object)BitConverter.ToUInt16(Data_MotorDataBytes, 4);
                    break;
                case "int16":
                    value = (T)(object)BitConverter.ToInt16(Data_MotorDataBytes, 4);
                    break;
                case "float":
                    value = (T)(object)BitConverter.ToSingle(Data_MotorDataBytes, 4);
                    break;
                case "int32":
                    value = (T)(object)BitConverter.ToInt32(Data_MotorDataBytes, 4);
                    break;
                case "uint32":
                    value = (T)(object)BitConverter.ToUInt32(Data_MotorDataBytes, 4);
                    break;
                default:
                    Log.log.Error($"电机参数：{enum_MotorParameter}，具备意料之外的description：{description}");
                    break;
            }
            return value;
        }
        /// <summary>
        /// 通过电机属性的描述来获取电机的真实值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enum_MotorParameter"></param>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static T GetRealMotorParameterValueByEnumDescription<T>(Enum_MotorParameter enum_MotorParameter, string inputValue)
        {
            T value = default(T);
            string description = GetDescription(enum_MotorParameter);
            inputValue = inputValue.Trim().Replace("\r", "").Replace("\n", "").Replace(" ", "");
            switch (description)
            {
                case "uint8":
                    value = (T)(object)Convert.ToByte(inputValue);
                    break;
                case "int8":
                    value = (T)(object)Convert.ToByte(inputValue);
                    break;
                case "uint16":
                    value = (T)(object)Convert.ToUInt16(inputValue);
                    break;
                case "int16":
                    value = (T)(object)Convert.ToInt16(inputValue);
                    break;
                case "float":
                    value = (T)(object)Convert.ToSingle(inputValue);
                    break;
                case "int32":
                    value = (T)(object)Convert.ToInt32(inputValue);
                    break;
                case "uint32":
                    value = (T)(object)Convert.ToUInt32(inputValue);
                    break;
                default:
                    throw new Exception($"电机参数：{enum_MotorParameter}，具备意料之外的description：{description}");
                    break;
            }
            return value;
        }
       

        // 简单方法：使用反射获取Description
        public static string GetDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            if (field != null)
            {
                DescriptionAttribute attribute =
                    field.GetCustomAttribute<DescriptionAttribute>();

                return attribute?.Description ?? value.ToString();
            }

            return value.ToString();
        }


    }

}
