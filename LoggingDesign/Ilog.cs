using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.LoggingDesign
{
    public enum LOG_TYPE
    {
        INFO,
        DEBUG,
        ERROR,
        WARNING
    }
    public interface Ilog
    {
        public string logMessage(string message, LOG_TYPE logType);
    }

    public abstract class Log : Ilog
    {
        public Ilog nextLog;
        public Log(Ilog log)
        {
            this.nextLog = log;
        }
        public abstract string logMessage(string message, LOG_TYPE logType);
        public string logDifferentMessage(string message, LOG_TYPE logType)
        {
            string logMessage = "";
            logMessage += DateTime.Now.ToString();
            logMessage += " ";
            logMessage += $"[{logType}]";
            logMessage += " ";
            logMessage += message;

            return logMessage;
        }
    }

    public class InfoLog : Log
    {
        public InfoLog(Ilog nextLogger) : base(nextLogger)
        {
        }
        public override string logMessage(string message, LOG_TYPE logType)
        {
            if (logType == LOG_TYPE.INFO)
            {
                return this.logDifferentMessage(message, logType);
            }
            else
            {
                return this.nextLog.logMessage(message, logType);
            }
        }
    }
    public class DebugLog : Log
    {
        public DebugLog(Ilog nextLogger) : base(nextLogger)
        {
        }
        public override string logMessage(string message, LOG_TYPE logType)
        {
            if (logType == LOG_TYPE.DEBUG)
            {
                return this.logDifferentMessage(message, logType);
            }
            else
            {
                return this.nextLog.logMessage(message, logType);
            }
        }
    }
    public class ErrorLog : Log
    {
        public ErrorLog(Ilog nextLogger) : base(nextLogger)
        {
        }
        public override string logMessage(string message, LOG_TYPE logType)
        {
            if (logType == LOG_TYPE.ERROR)
            {
                return this.logDifferentMessage(message, logType);
            }
            else
            {
                return this.nextLog.logMessage(message, logType);
            }
        }
    }
    public class WarningLog : Log
    {
        public WarningLog(Ilog nextLogger) : base(nextLogger)
        {
        }
        public override string logMessage(string message, LOG_TYPE logType)
        {
            if (logType == LOG_TYPE.WARNING)
            {
                return this.logDifferentMessage(message, logType);
            }
            else
            {
                return "Logger type not supported";
            }
        }
    }
}