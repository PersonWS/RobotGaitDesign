using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanAdapterEntity
    {
        public int Id { get; set; }
        public string ComPort { get; set; }
        public int ComBaud { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VID { get; set; }
        public string PID { get; set; }
        public CanAdapterTypeEnum ChipType { get; set; }
        public bool IsReadOnly { get; set; } = false;
        public CanAdapterEntity(string comPort, int comBaud)
        {
            this.ComPort = comPort;
            this.ComBaud = comBaud;
        }

    }
}
