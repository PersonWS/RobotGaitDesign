using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public enum Enum_CommunicationType : byte
    {
        /// <summary>
        /// 获取电机ID号
        /// </summary>
        GetMotorID=0x0,
        /// <summary>
        /// 运控模式电机控制指令
        /// </summary>
        MotionControlInstruction = 0x01,
        /// <summary>
        /// 电机反馈数据
        /// </summary>
        AckInformation = 0x02,
        /// <summary>
        /// 电机使能运行
        /// </summary>
        MotorEnable = 0x03,

        /// <summary>
        /// 电机停止运行 / 清除故障
        /// </summary>
        MotorDisable = 0x04,



        /// <summary>
        /// 设置电机机械零位
        /// </summary>
        SetMotorZero = 0x06,


        /// <summary>
        /// 设置电机CAN_ID
        /// </summary>
        SetMotorCanID = 0x07,

        /// <summary>
        /// 单个参数读取
        /// </summary>
        ReadParameter = 0x11,

        /// <summary>
        /// 单个参数写入（掉电丢失）
        /// </summary>
        SetParameterUnhold= 0x12,

        /// <summary>
        /// 单个参数写入（掉电保存，写20开头的参数）
        /// </summary>
        SetParameterHold = 0x16,
        /// <summary>
        /// 单个参数写入（掉电保存，写20开头的参数）
        /// </summary>
        SetParameterHold01 = 0x8,
        /// <summary>
        /// 单个参数写入（掉电保存，写20开头的参数）
        /// </summary>
        SetParameterHold02 = 0x16,

        /// <summary>
        /// 故障反馈帧
        /// </summary>
        FaultFeedback = 0x15,

        /// <summary>
        /// 电机波特率修改帧
        /// </summary>
        MotorBaudSet = 0x17,

        /// <summary>
        /// 电机主动上报帧（0.3.1.0后为该协议）
        /// </summary>
        MotorReportSet = 0x18,

        /// <summary>
        /// 电机协议修改帧
        /// </summary>
        MotorProtocolSet = 0x17,

        /// <summary>
        /// 电机主动上报帧（0.3.1.0后为该协议）
        /// </summary>
        MotorVersionRead = 0x4,



    }
}
