using log4net;
using log4net.Config;
using System;

namespace Log4NetDemo
{
    public class Log4NetLogger : ILogger
    {
        private readonly ILog _logger;
        private readonly string _messageFormat;

        public Log4NetLogger(ILog log)
        {
            _logger = log;
            _messageFormat = "\r\nContext: {0}\r\nMessage: {1}\r\nEventCode: {2}\r\n";
        }

        public void WriteInfo(string context, string message, Exception exception = null, string eventCode = null)
        {
            var logMessage = string.Format(_messageFormat, context, message, eventCode);
            _logger.Info(logMessage, exception);
        }

        public void WriteWarn(string context, string message, Exception exception = null, string eventCode = null)
        {
            var logMessage = string.Format(_messageFormat, context, message, eventCode);
            _logger.Warn(logMessage, exception);
        }

        public void WriteError(string context, string message, Exception exception = null, string eventCode = null)
        {
            var logMessage = string.Format(_messageFormat, context, message, eventCode);
            _logger.Error(logMessage, exception);
        }
    }
}
