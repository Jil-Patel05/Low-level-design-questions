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
            try
            {
                string logMessage = this.log.logMessage(message, logType);
                string filePath = "./logs/log.txt";
                using (StreamWriter sw = new StreamWriter(filePath, append: true))
                {
                    sw.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}