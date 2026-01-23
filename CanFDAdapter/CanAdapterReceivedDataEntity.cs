using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanAdapterReceivedDataEntity
    {
        byte[] data;
        DateTime timeStamp;
        /// <summary>
        /// 数据来自通道号
        /// </summary>
        int channel = 0;
        public CanAdapterReceivedDataEntity()
        { }
        public CanAdapterReceivedDataEntity(byte[] data, DateTime timeStamp,int channel=0)
        {
            this.timeStamp = timeStamp;
            this.data = data;
            this.channel = channel;
        }

        public byte[] Data { get => data; set => data = value; }
        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
        public int Channel { get => channel; set => channel = value; }
    }
}
