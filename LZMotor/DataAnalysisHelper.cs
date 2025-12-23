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
        public DataAnalysisHelper(ExtendData_ID id, Data_Motor data)
        {
            this.id = id;
            this.motorData = data;
        }

        public string AnalysisData_ReturnString()
        {
            return AnalysisData_ReturnString(id, motorData);
        }

        public static string AnalysisData_ReturnString(ExtendData_ID id, Data_Motor data)
        {
            DataTable dt = AnalysisDataInternal(id, data);
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

        private static DataTable AnalysisDataInternal(ExtendData_ID id, Data_Motor data)
        {
            if (data == null || data.DataByte == null || id == null)
            {
                Log.log.Error($"AnalysisDataInternal ,id or data is null");
                return null;
            }
            Enum_CommunicationType cType;
            if (Enum.IsDefined(typeof(Enum_CommunicationType), id.CommunicationTypeByte))
            {
            }
            else
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
                    dataTable = AnalysisDataInternal_AckInformation(id, data.DataByte);
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
                    break;
                case Enum_CommunicationType.FaultFeedback:
                    break;
                case Enum_CommunicationType.MotorInformationFeedbackOrSet:
                    dataTable = AnalysisDataInternal_AckInformation(id, data.DataByte);
                    break;
                default:
                    break;
            }
            return dataTable;
        }


        private static DataTable AnalysisDataInternal_AckInformation(ExtendData_ID id, byte[] data)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Angle");
            dataTable.Columns.Add("RotSpeed");
            dataTable.Columns.Add("Torque");
            dataTable.Columns.Add("Temperature");
            DataRow dr = dataTable.NewRow();
            dr["Angle"] = MapUInt16ToFloat(new byte[] { data[1], data[0] }).ToString("0.0000");
            if (id.MotorIDSend < 100)
            {
                dr["RotSpeed"] = (MapUInt16ToFloat(new byte[] { data[3], data[2] }, -15, 15) * 19.1082).ToString("0.0000");
                dr["Torque"] = (MapUInt16ToFloat(new byte[] { data[5], data[4] }, -120, 120)).ToString("0.0000");
            }
            else
            {
                dr["RotSpeed"] = (MapUInt16ToFloat(new byte[] { data[3], data[2] }, -50 ,50)*19.1082 ).ToString("0.0000");//* 114.61968
                dr["Torque"] = (MapUInt16ToFloat(new byte[] { data[5], data[4] }, -5.5f, 5.5f)).ToString("0.0000");
            }

            dr["Temperature"] = BitConverter.ToUInt16(new byte[] { data[7], data[6] }, 0) / 10;
            dataTable.Rows.Add(dr);
            return dataTable;
        }


        public static float MapUInt16ToFloat(byte[] byteArray, float minOutput = -12.57f, float maxOutput = 12.57f)
        {
            return MapUInt16ToFloat(BitConverter.ToUInt16(byteArray, 0), minOutput, maxOutput);


        }


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
