using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogHelper;

namespace RobotGaitDesignDemo
{
    public class ShowMessage
    {
        public string msg;
        public bool isAppendTimeStamp = true;
        public Enum_Log4Net_RecordLevel level = Enum_Log4Net_RecordLevel.DEBUG;

        public ShowMessage(string msg, bool isAppendTimeStamp = true, Enum_Log4Net_RecordLevel level = Enum_Log4Net_RecordLevel.DEBUG)
        {
            this.msg = msg;
            this.isAppendTimeStamp= isAppendTimeStamp;
            this.level = level;
        }


    }
}
