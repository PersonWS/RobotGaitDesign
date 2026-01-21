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
        public CanAdapterReceivedDataEntity()
        { }
        public CanAdapterReceivedDataEntity(byte[] data, DateTime timeStamp)
        {
            this.timeStamp = timeStamp;
            this.data = data;
        }

        public byte[] Data { get => data; set => data = value; }
        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
    }
}
