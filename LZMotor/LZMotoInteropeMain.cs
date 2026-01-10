using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LZMotor
{
    /// <summary>
    /// 本类作为电机交互操作的主类
    /// </summary>
    public class LZMotoInteropeMain
    {
        private Data_Motor _data_Motor;
        private ExtendData_ID _extendData_ID;
        public Data_Motor Data_Motor { get => _data_Motor; set => _data_Motor = value; }
        public ExtendData_ID ExtendData_ID { get => _extendData_ID; set => _extendData_ID = value; }
        public LZMotoInteropeMain()
        {

        }

        #region 写入电机参数
        /// <summary>
        /// 电机上使能
        /// </summary>
        /// <param name="motorIds"></param>
        /// <returns></returns>
        public static List<byte[]> W_MotorEnable(List<byte> motorIds)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"MC_MotorEnable,motorIds is null or empty");
                return null;
            }
            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.MotorEnable);

            return GenerateSendBytes(id);
        }
        /// <summary>
        /// 电机下使能
        /// </summary>
        /// <param name="motorIds"></param>
        /// <returns></returns>
        public static List<byte[]> W_MotorDisEnable(List<byte> motorIds,bool isClearError)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"W_MotorDisEnable,motorIds is null or empty");
                return null;
            }
            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.MotorDisable);
            if (!isClearError)
            {

                return GenerateSendBytes(id);
            }
            else
            {
                List<MotorCommunicationDataMain> mc = new List<MotorCommunicationDataMain>();
                foreach (ExtendData_ID item in id)
                {
                    Data_Motor da = new Data_Motor(new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 });
                    MotorCommunicationDataMain m = new MotorCommunicationDataMain(item, da);
                    mc.Add(m);
                }
                return GenerateSendBytes(mc);
            }


        }
        /// <summary>
        /// 电机设置0位
        /// </summary>
        /// <param name="motorIds"></param>
        /// <returns></returns>
        public static List<byte[]> W_SetMotorZero(List<byte> motorIds)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"W_SetMotorZero,motorIds is null or empty");
                return null;
            }
            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.SetMotorZero);
            List<MotorCommunicationDataMain> mc = new List<MotorCommunicationDataMain>();
            foreach (ExtendData_ID item in id)
            {
                Data_Motor da = new Data_Motor(new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 });
                MotorCommunicationDataMain m = new MotorCommunicationDataMain(item, da);
                mc.Add(m);

            }
            return GenerateSendBytes(mc);
        }
        /// <summary>
        /// 设置电机id
        /// </summary>
        /// <param name="motorIds"></param>
        /// <returns></returns>
        public static List<byte[]> W_MotorEnable(List<byte> motorIds,byte destinationID)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"W_MotorEnable,motorIds is null or empty");
                return null;
            }
            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.SetMotorCanID);
            foreach (var item in id)
            {
                item.UserDefineByte = destinationID;
            }
            return GenerateSendBytes(id);
        }

        /// <summary>
        /// 电机上报开关
        /// </summary>
        /// <param name="motorIds"></param>
        /// <returns></returns>
        public static List<byte[]> W_MotorReport(List<byte> motorIds, bool isEnable)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"MC_MotorEnable,motorIds is null or empty");
                return null;
            }
            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.MotorReportSet);
            List<MotorCommunicationDataMain> mc = new List<MotorCommunicationDataMain>();
            foreach (ExtendData_ID item in id)
            {
                Data_Motor da = new Data_Motor(new byte[] { 1, 2, 3, 4, 5, 6, (byte)(isEnable ? 1 : 0), 0 });
                MotorCommunicationDataMain m = new MotorCommunicationDataMain(item, da);
                mc.Add(m);
            }
            return GenerateSendBytes(mc);
        }

        /// <summary>
        /// 电机非易失性参数设定,第一步修改值
        /// </summary>
        /// <param name="motorIds"></param>
        /// <param name="enum_MotorParameter"></param>
        /// <param name="parameter"></param>
        /// <param name="userDefine">用户自定义字段</param>
        /// <returns></returns>
        public static List<byte[]> W_SetMotorParameter<T>(List<byte> motorIds, Enum_MotorParameter enum_MotorParameter, T parameter, byte userDefine = 0)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"MC_MotorEnable,motorIds is null or empty");
                return null;
            }

            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.SetParameterUnhold);
            List<MotorCommunicationDataMain> mc = new List<MotorCommunicationDataMain>();
            byte[] para = ConvertToBytes(parameter);
            foreach (ExtendData_ID item in id)
            {
                Data_Motor da = new Data_Motor(new byte[] { ((Byte)enum_MotorParameter), (byte)(((Int16)enum_MotorParameter) >> 8), 0, 0, para[0], para[1], para[2], para[3] });
                MotorCommunicationDataMain m = new MotorCommunicationDataMain(item, da);
                mc.Add(m);

            }
            return GenerateSendBytes(mc);
        }
        /// <summary>
        /// 电机非易失性参数设定,第二步保存修改
        /// </summary>
        /// <param name="motorIds"></param>
        /// <param name="enum_MotorParameter"></param>
        /// <param name="parameter"></param>
        /// <param name="userDefine"></param>
        /// <returns></returns>
        public static List<byte[]> W_SetMotorParameterHoldSave<T>(List<byte> motorIds, Enum_MotorParameter enum_MotorParameter, T parameter, byte userDefine = 0) 
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"MC_MotorEnable,motorIds is null or empty");
                return null;
            }

            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.SetParameterHold, userDefine);
            List<MotorCommunicationDataMain> mc = new List<MotorCommunicationDataMain>();
            //byte[] para = ConvertToBytes(parameter);
            foreach (ExtendData_ID item in id)
            {
                Data_Motor da = new Data_Motor(new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 });
                MotorCommunicationDataMain m = new MotorCommunicationDataMain(item, da);
                mc.Add(m);

            }
            return GenerateSendBytes(mc);
        }

        #endregion

        #region 电机数据读取
        public static List<byte[]> R_ReadMotorVersion(List<byte> motorIds)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"MC_MotorEnable,motorIds is null or empty");
                return null;
            }
            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.MotorVersionRead);
            List<MotorCommunicationDataMain> mc = new List<MotorCommunicationDataMain>();
            foreach (ExtendData_ID item in id)
            {
                Data_Motor da = new Data_Motor(new byte[] { 0, 0xc4,0, 0, 0, 0, 0, 0 });
                MotorCommunicationDataMain m = new MotorCommunicationDataMain(item, da);
                mc.Add(m);

            }

            return GenerateSendBytes(mc);
        }


        /// <summary>
        /// 读取电机参数
        /// </summary>
        /// <param name="motorIds"></param>
        /// <param name="enum_MotorParameter"></param>
        /// <returns>返回需要发送的数组</returns>
        public static List<byte[]> R_ReadMotorParameter(List<byte> motorIds, Enum_MotorParameter enum_MotorParameter)
        {
            if (motorIds == null || motorIds.Count == 0)
            {
                Log.log.Error($"MC_MotorEnable,motorIds is null or empty");
                return null;
            }

            List<ExtendData_ID> id = GenerateSendBytesByCommunicationType(motorIds, (byte)Enum_CommunicationType.ReadParameter);
            List<MotorCommunicationDataMain> mc = new List<MotorCommunicationDataMain>();
            byte[] para = BitConverter.GetBytes((UInt16)enum_MotorParameter);
            foreach (ExtendData_ID item in id)
            {
                Data_Motor da = new Data_Motor(new byte[] { para[0], para[1], 0, 0, 0, 0, 0, 0 });
                MotorCommunicationDataMain m = new MotorCommunicationDataMain(item, da);
                mc.Add(m);

            }
            return GenerateSendBytes(mc);
        }


        #endregion

        #region 共用函数
        /// <summary>
        /// CommunicationTypeByte不同的命令生成对应不同的实例，应用于命令生成部分
        ///  生成发送的拓展ID字段
        /// </summary>
        /// <param name="motorIds"></param>
        /// <param name="communicationTypeByte"></param>
        /// <param name="userDefine">用户自定义功能码</param>
        /// <returns></returns>
        private static List<ExtendData_ID> GenerateSendBytesByCommunicationType(List<byte> motorIds, byte communicationTypeByte, byte userDefine = 0)
        {
            List<ExtendData_ID> mc = new List<ExtendData_ID>();

            foreach (var motorId in motorIds)
            {
                ExtendData_ID m = new ExtendData_ID(new byte[8]);
                m.CommunicationTypeByte = communicationTypeByte;
                m.MotorIDSend = 253;
                m.MotorIDReceive = motorId;
                m.UserDefineByte = userDefine;
                mc.Add(m);
            }
            return mc;
        }
        private static List<byte[]> GenerateSendBytes(List<MotorCommunicationDataMain> communicationData)
        {
            List<byte[]> ret = new List<byte[]>();
            List<byte> temp = new List<byte>();
            foreach (var item in communicationData)
            {
                temp.AddRange(item.extendData_ID.DataBytes);
                temp.Add((byte)(item.data_Motor.DataBytes.Length));
                temp.AddRange(item.data_Motor.DataBytes);
                ret.Add(temp.ToArray());
                temp.Clear();
            }
            return ret;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="extendData_ID"></param>
        /// <param name="userDefined">用户自定义码</param>
        /// <returns></returns>
        private static List<byte[]> GenerateSendBytes(List<ExtendData_ID> extendData_ID, byte userDefined = 0)
        {
            List<byte[]> ret = new List<byte[]>();
            List<byte> temp = new List<byte>();
            foreach (var item in extendData_ID)
            {
                temp.AddRange(item.DataBytes);
                //temp.Add((byte)(item.DataBytes.Length));
                temp.AddRange(new byte[] { 08, 00, 00, 00, 00, 00, 00, 00, 00 });

                ret.Add(temp.ToArray());
                temp.Clear();
            }
            return ret;
        }

        /// <summary>
        /// 数据类型转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        private static byte[] ConvertToBytes<T>(T value)
        {
            // 根据类型大小创建字节数组
            //int size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(T));
            byte[] bytes = new byte[4];

            // 使用Buffer.BlockCopy进行快速内存复制
            switch (value)
            {
                case byte byteValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(byteValue), 0, bytes, 0, sizeof(byte));
                    break;
                case int intValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(intValue), 0, bytes, 0, sizeof(int));
                    break;
                case float floatValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(floatValue), 0, bytes, 0, sizeof(float));
                    break;
                case double doubleValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(doubleValue), 0, bytes, 0, sizeof(double));
                    break;
                case bool boolValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(boolValue), 0, bytes, 0, sizeof(bool));
                    break;
                case char charValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(charValue), 0, bytes, 0, sizeof(char));
                    break;
                case short shortValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(shortValue), 0, bytes, 0, sizeof(short));
                    break;
                case ushort ushortValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(ushortValue), 0, bytes, 0, sizeof(ushort));
                    break;
                case uint uintValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(uintValue), 0, bytes, 0, sizeof(uint));
                    break;
                case long longValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(longValue), 0, bytes, 0, sizeof(long));
                    break;
                case ulong ulongValue:
                    Buffer.BlockCopy(BitConverter.GetBytes(ulongValue), 0, bytes, 0, sizeof(ulong));
                    break;
                default:
                    throw new NotSupportedException($"不支持的类型: {typeof(T).Name}");
            }

            return bytes;
        }


        #endregion



    }
}
