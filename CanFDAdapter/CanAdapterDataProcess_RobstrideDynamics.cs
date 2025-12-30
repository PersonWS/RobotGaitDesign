using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanAdapterDataProcess_RobstrideDynamics : CanAdapterDataProcess
    {
        public CanAdapterDataProcess_RobstrideDynamics(CanAdapterEntity entity)
            : base(entity)
        {
        }
        public override List<byte[]> AnalysisData(byte[] sourceData)
        {
            List<byte[]> retBytes = new List<byte[]>();
            if (sourceData?.Length < 17 || (sourceData[15] != 0X0d || sourceData[16] != 0X0a) || sourceData.Length % 17 != 0)//异常或者粘包的数据
            {
                Log.log.Error($"CanAdapterDataProcess_RobstrideDynamics-AnalysisData数据，发现异常，数据：{BitConverter.ToString(sourceData).Replace('-', ' ')}");
                return retBytes;
            }
            int total = sourceData.Length / 17;
            for (int i = 0; i < total; i++)
            {
                byte[] data = sourceData.Skip(i * 17).Take(17).ToArray();
                if (data[15] != 0X0d || sourceData[16] != 0X0a)
                {
                    Log.log.Error($"CanAdapterDataProcess_RobstrideDynamics-AnalysisData数据，分解报文发现异常，数据：{BitConverter.ToString(sourceData).Replace('-', ' ')}");
                    continue;
                }
                // Array.Copy(BitConverter.GetBytes(BitConverter.ToInt32(data, 2) >> 3), 0, data, 2, 4);
                byte[] tempid = data.Skip(2).Take(4).ToArray();
                Array.Reverse(tempid);
                tempid = BitConverter.GetBytes(BitConverter.ToUInt32(tempid, 0) >> 3);
                //Array.Reverse(tempid);
                //增加填充序列
                List<byte> tempBuffer= new List<byte>();
                tempBuffer.AddRange(tempid);
                tempBuffer.AddRange(new byte[] { 0, 0, 0, 8 });
                tempBuffer.AddRange(data.Skip(7).Take(8).ToArray());
                retBytes.Add(tempBuffer.ToArray());
                //byte temp
                ////调换4个拓展id的值
                //byte temp= data[3];
                //data[3] = data[6];
                //data[6] = temp;
                //temp = data[4];
                //data[4] = data[5];		BitConverter.ToUInt32(data, 2) >> 3	495050768	uint

                //data[5] = temp;
               // retBytes.Add(data);
            }
            return retBytes;
        }
    }
}
