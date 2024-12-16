using System;

namespace NotifyMe.ChainOfResponsibility
{
    public class LogProcessor
    {
        private LogProcessor _nextLogProcessor;

        public LogProcessor(LogProcessor nextLogProcessor)
        {
            this._nextLogProcessor = nextLogProcessor;
        }

        public virtual void Log(int logLevel, string message)
        {
            if (_nextLogProcessor != null)
            {
                _nextLogProcessor.Log(logLevel, message);
            }
        }
    }
}

