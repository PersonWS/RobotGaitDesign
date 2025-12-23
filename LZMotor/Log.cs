using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogHelper;
namespace LZMotor
{
    internal class Log
    { 
        public static readonly ILogEntity log = LogHelper.EasyLogger.GetLoggerInstance_log4Net("LZMotor");


    }
}
