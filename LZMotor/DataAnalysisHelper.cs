using CanFDAdapter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMotor
{
    public class DataAnalysisHelper
    {
        ExtendData_ID id;
        Data_Motor motorData;
        static DataTable _dt_motorAck = new DataTable();
        static DataTable _dt_motorReadParameter = new DataTable();
        static DataTable _dt_SetParameterUnhold = new DataTable();
        static DataAnalysisHelper()
        {
            _dt_motorAck.Columns.Add("canIdSend");
            //_dt_motorAck.Columns.Add("canIdRec");
            _dt_motorAck.Columns.Add("Angle");
            _dt_motorAck.Columns.Add("RotSpeed");
            _dt_motorAck.Columns.Add("Torque");
            _dt_motorAck.Columns.Add("Temperature");
            _dt_motorAck.Columns.Add("Mode");
            _dt_motorAck.Columns.Add("Alarm");
            _dt_SetParameterUnhold.Columns.Add("canIdSend");
            //_dt_SetParameterUnhold.Columns.Add("canIdRec");
            _dt_SetParameterUnhold.Columns.Add("canIdReceive");
            _dt_SetParameterUnhold.Columns.Add("parameterID");
            _dt_SetParameterUnhold.Columns.Add("parameterValue");
        }
        public DataAnalysisHelper(ExtendData_ID id, Data_Motor data)
        {
            this.id = id;
            this.motorData = data;

        }

        public string AnalysisData_ReturnString()
        {
            DataTable dt = new DataTable();
            return AnalysisAckData_ReturnString(id, motorData, out dt);
        }
        #region 通过适配器的原始报文来解析出can的信息
        public static LZMotorDataMain AnalysisBytesArrayToCanidAndCandata(CanFDAdapter.CanAdapterEntity canAdapterEntity, byte[] bytes)
        {
            LZMotorDataMain lZMotorData = null;
            CanAdapterDataProcess canAdapterDataProcess;
            switch (canAdapterEntity.ChipType)
            {
                case CanFDAdapter.CanAdapterTypeEnum.CH340:
                    canAdapterDataProcess = new CanAdapterDataProcess_RobstrideDynamics(null);
                    lZMotorData = AnalysisBytesArrayToCanidAndCandataSub(canAdapterDataProcess, bytes);
                    break;
                case CanFDAdapter.CanAdapterTypeEnum.ch341:
                    canAdapterDataProcess = new CanAdapterDataProcess_BaoFengFD(null);
                    lZMotorData = AnalysisBytesArrayToCanidAndCandataSub(canAdapterDataProcess, bytes);
                    break;
                default:
                    Log.log.Error($"AnalysisBytesArrayToCanidAndCandata,unkonwn type:{canAdapterEntity.ChipType}");
                    break;
            }
            return lZMotorData;

        }
        private static LZMotorDataMain AnalysisBytesArrayToCanidAndCandataSub(CanAdapterDataProcess canAdapterDataProcess, byte[] bytes)
        {
           byte[] anaBytes = canAdapterDataProcess.AnalysisMotorRetData(bytes);

                byte[] idArray = new byte[] { anaBytes[3], anaBytes[2], anaBytes[1], anaBytes[0] };
                int dataLength = BitConverter.ToInt16(new byte[] { anaBytes[7], anaBytes[6] }, 0);
                byte[] dataArray = anaBytes.Skip(8).Take(anaBytes[7]).ToArray();
                LZMotorDataMain data = new LZMotorDataMain(new LZMotor.Data_Motor(dataArray), new LZMotor.ExtendData_ID(idArray));
            return data;
        }

        #endregion

        public static string AnalysisAckData_ReturnString(ExtendData_ID id, Data_Motor data, out DataTable dt)
        {
            dt = AnalysisAckDataInternal(id, data);
            if (dt != null && dt.Rows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow item in dt.Rows)
                {
                    for (int i = 0; i < item.ItemArray.Length; i++)
                    {
                        sb.Append($"  {dt.Columns[i].ColumnName}: {item.ItemArray[i]}");
                    }

                }
                return sb.ToString();
            }
            return "";
        }
        /// <summary>
        /// 将报文格式化成string
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string AnalysisMotorVersionAckData_ReturnString(ExtendData_ID id, Data_Motor data, out DataTable dt)
        {
            dt = new DataTable();

            dt.Columns.Add("canIdSend");
            //_dt_motorAck.Columns.Add("canIdRec");
            dt.Columns.Add("MotorVersion");
            DataRow dr = dt.NewRow();
            dr["canIdSend"] = id.MotorIDSend;
            dr["MotorVersion"] = $"{data.DataBytes[3]}.{data.DataBytes[4]}.{data.DataBytes[5]}.{data.DataBytes[6]}";
            dt.Rows.Add(dr);
            StringBuilder sb = new StringBuilder();
            foreach (DataRow item in dt.Rows)
            {
                for (int i = 0; i < item.ItemArray.Length; i++)
                {
                    sb.Append($"  {dt.Columns[i].ColumnName}: {item.ItemArray[i]}");
                }

            }
            return sb.ToString();

        }
        /// <summary>
        /// 通过报文的拓展ID及数据来分析报文的内容
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private static DataTable AnalysisAckDataInternal(ExtendData_ID id, Data_Motor data)
        {
            if (data == null || data.DataBytes == null || id == null)
            {
                Log.log.Error($"AnalysisDataInternal ,id or data is null");
                return null;
            }
            Enum_CommunicationType cType;
            if (!Enum.IsDefined(typeof(Enum_CommunicationType), id.CommunicationTypeByte))
            {
                Log.log.Error($"unknow communicaitonType:{id.CommunicationTypeByte}");
                return null;
            }


            DataTable dataTable = null;
            switch ((Enum_CommunicationType)id.CommunicationTypeByte)
            {
                case Enum_CommunicationType.GetMotorID:
                    break;
                case Enum_CommunicationType.MotionControlInstruction:
                    break;
                case Enum_CommunicationType.AckInformation:
                    dataTable = AnalysisDataInternal_AckInformation(id, data.DataBytes);
                    break;
                case Enum_CommunicationType.MotorEnable:
                    break;
                case Enum_CommunicationType.MotorDisable:
                    break;
                case Enum_CommunicationType.SetMotorZero:
                    break;
                case Enum_CommunicationType.SetMotorCanID:
                    break;
                case Enum_CommunicationType.ReadParameter:

                    break;
                case Enum_CommunicationType.SetParameterUnhold:
                    dataTable= AnalysisDataInternal_SetParameterUnhold(id, data.DataBytes);
                    break;
                case Enum_CommunicationType.FaultFeedback:
                    break;
                case Enum_CommunicationType.MotorReportSet:
                    dataTable = AnalysisDataInternal_AckInformation(id, data.DataBytes);
                    break;
                default:
                    break;
            }
            return dataTable;
        }


        private static DataTable AnalysisDataInternal_AckInformation(ExtendData_ID id, byte[] data)
        {
            DataTable dataTable = _dt_motorAck.Clone();
            dataTable.TableName = "motorAck";
            DataRow dr = dataTable.NewRow();
            dr["canIdSend"] = id.MotorIDSend;
            //dr["canIdRec"] = id.MotorIDReceive;
            dr["Angle"] = (MapUInt16ToFloat(new byte[] { data[1], data[0] }) * 57.29578F).ToString("0.0000");

            if (id.MotorIDSend < 100)
            {
                dr["RotSpeed"] = (MapUInt16ToFloat(new byte[] { data[3], data[2] }, -15, 15) * 19.1082).ToString("0.0000");
                dr["Torque"] = (MapUInt16ToFloat(new byte[] { data[5], data[4] }, -120, 120)).ToString("0.0000");
            }
            else
            {
                dr["RotSpeed"] = (MapUInt16ToFloat(new byte[] { data[3], data[2] }, -50, 50) * 19.1082).ToString("0.0000");//* 114.61968
                dr["Torque"] = (MapUInt16ToFloat(new byte[] { data[5], data[4] }, -5.5f, 5.5f)).ToString("0.0000");
            }

            dr["Temperature"] = BitConverter.ToUInt16(new byte[] { data[7], data[6] }, 0) / 10;
            //检查错误代码
            byte errorCode = (byte)(id.UserDefineByte << 2);
            if (errorCode > 0)
            {
                if ((byte)(id.UserDefineByte & (byte)MotorAralmInfo1.encoderError) == ((byte)MotorAralmInfo1.encoderError))
                {
                    dr["Alarm"] = dr["Alarm"].ToString() + "  " + "encoderError";
                }
                if ((byte)(id.UserDefineByte & (byte)MotorAralmInfo1.highTemperature) == ((byte)MotorAralmInfo1.highTemperature))
                {
                    dr["Alarm"] = dr["Alarm"].ToString() + "  " + "highTemperature";
                }
                if ((byte)(id.UserDefineByte & (byte)MotorAralmInfo1.driverError) == ((byte)MotorAralmInfo1.driverError))
                {
                    dr["Alarm"] = dr["Alarm"].ToString() + "  " + "driverError";
                }
                if ((byte)(id.UserDefineByte & (byte)MotorAralmInfo1.lowVoltage) == ((byte)MotorAralmInfo1.lowVoltage))
                {
                    dr["Alarm"] = dr["Alarm"].ToString() + "  " + "lowVoltage";
                }
                if ((byte)(id.UserDefineByte & (byte)MotorAralmInfo1.unCalibrate) == ((byte)MotorAralmInfo1.unCalibrate))
                {
                    dr["Alarm"] = dr["Alarm"].ToString() + "  " + "unCalibrate";
                }
                if ((byte)(id.UserDefineByte & (byte)MotorAralmInfo1.lockedMotor) == ((byte)MotorAralmInfo1.unCalibrate))
                {
                    dr["Alarm"] = dr["Alarm"].ToString() + "  " + "lockedMotor";
                }
                if (string.IsNullOrEmpty(dr["Alarm"].ToString()))
                {
                    dr["Alarm"] = errorCode;
                }
            }
            //检查电机模式
            byte motorMode = (byte)(id.UserDefineByte >> 6);
            if (Enum.IsDefined(typeof(MotorMode), motorMode))
            {
                switch ((MotorMode)motorMode)
                {
                    case MotorMode.Reset:
                        dr["Mode"] = "Reset";
                        break;
                    case MotorMode.Calibrate:
                        dr["Mode"] = "Calibrate";
                        break;
                    case MotorMode.Run:
                        dr["Mode"] = "Run";
                        break;
                    default:
                        dr["Mode"] = "Unknow";
                        break;
                }
            }

            dataTable.Rows.Add(dr);
            return dataTable;
        }
        /// <summary>
        /// 解析并格式化电机参数写入的信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>

        private static DataTable AnalysisDataInternal_SetParameterUnhold(ExtendData_ID id, byte[] data)
        {
            DataTable dataTable = _dt_SetParameterUnhold.Clone();
            dataTable.TableName = "SetParameterUnhold";
            DataRow dr = dataTable.NewRow();
            dr["canIdSend"] = id.MotorIDSend;
            dr["canIdReceive"] = id.MotorIDReceive;
            dr["parameterID"] = BitConverter.ToString(new byte[] { data[1], data[0] }).Replace("-","");

            Enum_MotorParameter enum_MotorParameter = (Enum_MotorParameter)BitConverter.ToInt16(data, 0);
            object value = MotorParameterValueProcess.GetRealMotorParameterValueByEnumDescription<object>(enum_MotorParameter, data);
            if (value == null)
            {
                return dataTable;
            }
            else
            {
                Log.log.Error($"AnalysisDataInternal_SetParameterUnhold,ExtendData_ID:{BitConverter.ToString(id.DataBytes)},data:{data},解析数据失败");
            }
            switch (enum_MotorParameter)
            {
                case Enum_MotorParameter.drv_fault:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.drv_temp:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.run_mode运行模式:
                    switch ( value.ToString())
                    {
                        case "0":
                            dr["parameterValue"] = "运控模式";
                            break;
                        case "1":
                            dr["parameterValue"] = "位置模式(PP)";
                            break;
                        case "2":
                            dr["parameterValue"] = "速度模式";
                            break;
                        case "3":
                            dr["parameterValue"] = "电流模式";
                            break;
                        case "5":
                            dr["parameterValue"] = "位置模式(CSP)";
                            break;
                        default:
                            dr["parameterValue"] = "";
                            Log.log.Error($"AnalysisDataInternal_SetParameterUnhold: run_mode运行模式 ,未知模式：{value.ToString()}");
                            break;
                    }
                    break;
                case Enum_MotorParameter.limit_torque:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.mechPos负载端机械角度:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.cur_kp电流环增益:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.cur_ki电流环积分:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.loc_kp位置环增益:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.spd_kp速度环增益:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.spd_kI速度环积分:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.loc_ref_电机目标角度:
                    //dr["parameterValue"] = value.ToString();
                    dr["parameterValue"] = ((float)value*57.296).ToString("0.0000");
                    break;
                case Enum_MotorParameter.limit_spd_csp速度限制:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.EPScan_time:
                    dr["parameterValue"] = ((UInt16)value*5+5).ToString();
                    break;
                case Enum_MotorParameter.zero_sta零位状态:
                    dr["parameterValue"] = value.ToString();
                    break;
                case Enum_MotorParameter.add_offset零位偏置:
                    dr["parameterValue"] = value.ToString();
                    break;
                default:
                    dr["parameterValue"] = value.ToString();
                    break;
            }

            dataTable.Rows.Add(dr);
            return dataTable;
        }


        public static float MapUInt16ToFloat(byte[] byteArray, float minOutput = -12.57f, float maxOutput = 12.57f)
        {
            return MapUInt16ToFloat(BitConverter.ToUInt16(byteArray, 0), minOutput, maxOutput);


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minOutput"></param>
        /// <param name="maxOutput"></param>
        /// <returns>输出角度值</returns>
        public static float MapUInt16ToFloat(ushort value, float minOutput = -12.57f, float maxOutput = 12.57f)
        {
            // 输入范围：0 - 65535
            // 输出范围：minOutput - maxOutput

            // 1. 先将value转换为0-1的标准化值
            float normalized = value / 65535f;

            // 2. 进行线性映射
            return minOutput + normalized * (maxOutput - minOutput);
        }




    }
}
