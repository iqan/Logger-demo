using System;

namespace Log4NetDemo
{
    public interface ILogger
    {
        void WriteInfo(string context, string message, Exception exception = null, string eventCode = null);
        void WriteWarn(string context, string message, Exception exception = null, string eventCode = null);
        void WriteError(string context, string message, Exception exception = null, string eventCode = null);
    }
}
