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
        public override byte[] AnalysisMotorRetData(byte[] sourceData)
        {
            byte[] data = sourceData.Skip(1).Take(sourceData.Length - 2).ToArray();
            data[4] = (byte)((byte)(data[4] << 3) >> 3);

            return data;
        }

        public override List<byte[]> GenerateSendMotorData(List<byte[]> sourceData)
        {
            List<byte[]> bytes = new List<byte[]>();
            foreach (byte[] item in sourceData)
            {
                byte[] temp = new byte[18];
                temp[0] = 0x82;
                temp[1] = item[3];
                temp[2] = item[2];
                temp[3] = item[1];
                temp[4] = (byte)(item[0] + 128);
                //Array.Copy(item, 0, temp, 1, 4);//拷贝拓展信息
                Array.Copy(item, 4, temp, 8, 9);//拷贝data信息
                temp[17] = 0xAA;
                bytes.Add(temp);
            }
            return bytes;
        }

    }
}
