using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.LoggingDesign
{
    public class Logger
    {
        private Ilog log;
        private static Logger instance;
        private static Object obj = new Object();
        private Logger()
        {

        }
        public static Logger getInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public void initializeLogger()
        {
            log = new InfoLog(new DebugLog(new ErrorLog(new WarningLog(null))));
        }

        public void logMessage(string message, LOG_TYPE logType)
        {
            string logMessage = this.log.logMessage(message, logType);
            // Write message to File
            Console.WriteLine(logMessage);
        }
    }
}