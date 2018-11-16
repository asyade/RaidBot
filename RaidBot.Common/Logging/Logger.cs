using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RaidBot.Common.Default.Loging
{
    public delegate void OnLogDelegate(string log,LogLevelEnum logLevel);

    public class Logger

    {
        static Logger()
        {
            Default = new Logger();
        }
        public static Logger Default { get; private set; }

        #region Membres

        public  event OnLogDelegate OnLog;
        private  void OnOnLog(string log, LogLevelEnum logLevel)
        {
            if (OnLog != null)
                OnLog(log, logLevel);
        }

        public  void Log(string info, LogLevelEnum LogLevel = LogLevelEnum.Info)
        {
            OnOnLog(info, LogLevel);
        }

        #endregion
    }
}
