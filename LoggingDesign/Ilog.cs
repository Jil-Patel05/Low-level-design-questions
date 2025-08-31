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
                string logMessage = "";
                logMessage += DateTime.Now.ToString();
                logMessage += $"[logType]";
                logMessage += message;
                return logMessage;
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
                string logMessage = "";
                logMessage += DateTime.Now.ToString();
                logMessage += $"[logType]";
                logMessage += message;
                return logMessage;

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
                string logMessage = "";
                logMessage += DateTime.Now.ToString();
                logMessage += $"[logType]";
                logMessage += message;
                return logMessage;
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
            if (logType == LOG_TYPE.INFO)
            {
                string logMessage = "";
                logMessage += DateTime.Now.ToString();
                logMessage += $"[logType]";
                logMessage += message;
                return logMessage;
            }
            else
            {
                return "Logger type not supported";
            }
        }
    }
}