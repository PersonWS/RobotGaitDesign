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
        public override CanAdapterReceivedDataEntity AnalysisMotorRetData(CanAdapterReceivedDataEntity sourceData)
        {
            // Array.Copy(BitConverter.GetBytes(BitConverter.ToInt32(data, 2) >> 3), 0, data, 2, 4);
            byte[] tempid = sourceData.Data.Skip(2).Take(4).ToArray();
            Array.Reverse(tempid);
            tempid = BitConverter.GetBytes(BitConverter.ToUInt32(tempid, 0) >> 3);
            //Array.Reverse(tempid);
            //增加填充序列
            List<byte> tempBuffer = new List<byte>();
            tempBuffer.AddRange(tempid);
            tempBuffer.AddRange(new byte[] { 0, 0, 0, 8 });
            tempBuffer.AddRange(sourceData.Data.Skip(7).Take(sourceData.Data[6]).ToArray());



            sourceData.Data= tempBuffer.ToArray();
            return sourceData;
        }

        public override List<byte[]> GenerateSendMotorData(List<byte[]> sourceData)
        {
            List<byte[]> bytes = new List<byte[]>();
            foreach (byte[] item in sourceData)
            {
                string str = BitConverter.ToString(item);
                byte[] temp = new byte[17];
                temp[0] = 0x41;
                temp[1] = 0x54;
                //转换前4个
                UInt32 id1 = (BitConverter.ToUInt32(new byte[] { item[3], item[2], item[1], item[0] }, 0) << 3) + 4;
                byte[] tempid = BitConverter.GetBytes(id1);
                temp[2] = tempid[3];
                temp[3] = tempid[2];
                temp[4] = tempid[1];
                temp[5] = tempid[0];
                //Array.Copy(item, 0, temp, 1, 4);//拷贝拓展信息
                Array.Copy(item, 4, temp, 6, 9);//拷贝data信息
                temp[15] = 0x0d;
                temp[16] = 0x0a;
                bytes.Add(temp);
                string str2 = BitConverter.ToString(temp);
            }
            return bytes;
            return null;
        }









    }
}
