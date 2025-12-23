using LogHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGaitDesignDemo
{
    internal class ProcessEngine:CommonUtility.Engine.ProcessEngineBase
    {
        public static readonly ILogEntity log = LogHelper.EasyLogger.GetLoggerInstance_log4Net("demo_ProcessEngine");

        private Queue<byte[]> _motorMsgReceivedQueue;
        private readonly object _motorMsgReceivedLock = new object();
        public override void ProcessMethod_Customer()
        { 
            
        }
        public override void Dispose()
        {

        }


    }
}
