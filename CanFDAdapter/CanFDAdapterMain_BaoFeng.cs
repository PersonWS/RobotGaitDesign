using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanFDAdapterMain_BaoFeng : CanFDAdapterMain
    {
        public CanFDAdapterMain_BaoFeng(CanAdapterEntity canAdapterEntity) : base(canAdapterEntity)
        {

        }

        public override void AfterConnect(bool isConnectSuccess)
        {
            if (isConnectSuccess)
            {
                base.Send(new byte[] { 0x81, 0xEE, 0xAA });//打开CAN总线的通讯发送
            }
        }
    }
}
