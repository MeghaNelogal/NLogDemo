using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    public class NLog
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebugMode(string message)
        {
            logger.Debug(message);
        }

        public void LogErroring(string message)
        {
            logger.Error(message);
        }

        public void LogInformation(string message)
        {
            logger.Info(message);
        }




    }
}
