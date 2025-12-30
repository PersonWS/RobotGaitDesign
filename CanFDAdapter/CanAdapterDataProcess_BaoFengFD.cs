using LogHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanAdapterDataProcess_BaoFengFD : CanAdapterDataProcess
    {

        public CanAdapterDataProcess_BaoFengFD(CanAdapterEntity entity)
    : base(entity)
        {
        }
        public override List<byte[]> AnalysisData(byte[] sourceData)
        {
            List<byte[]> retBytes = new List<byte[]>();
            if (sourceData?.Length > 0 && sourceData[0] != 2 || sourceData.Length < 18 && sourceData.Length % 18 != 0)//异常或者粘包的数据
            {
                Log.log.Error($"CanAdapterDataProcess_BaoFengFD-AnalysisData数据，发现异常，数据：{BitConverter.ToString(sourceData).Replace('-', ' ')}");
                return retBytes;
            }
            int total = sourceData.Length / 18;
            for (int i = 0; i < total; i++)
            {
                byte[] data = sourceData.Skip(i * 18).Take(17).ToArray();
                if (data[0] != 0X2 || sourceData[17] != 0Xaa)
                {
                    Log.log.Error($"CanAdapterDataProcess_BaoFengFD-AnalysisData数据，分解报文发现异常，数据：{BitConverter.ToString(sourceData).Replace('-', ' ')}");
                    continue;
                }
                data[4] = (byte)((byte)(data[4] << 3) >> 3);
                retBytes.Add(data.Skip(1).Take(16).ToArray());
            }
            return retBytes;
        }

    }
}
