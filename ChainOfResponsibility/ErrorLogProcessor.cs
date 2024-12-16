using NotifyMe.ChainOfResponsibility.Enums;
using System;

namespace NotifyMe.ChainOfResponsibility
{
    public class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor nextLogProcessor) : base(nextLogProcessor)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if (logLevel == (int)LogTypes.Error) { 
                Console.WriteLine("Error logged : " + message);
            } else
            {
                base.Log(logLevel, message);
            }
        }
    }
}

