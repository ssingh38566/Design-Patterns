using NotifyMe.ChainOfResponsibility.Enums;
using System;

namespace NotifyMe.ChainOfResponsibility
{
    public class DebugLogProcessor : LogProcessor
    {
        public DebugLogProcessor(LogProcessor nextLogProcessor) : base(nextLogProcessor)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if (logLevel == (int)LogTypes.Debug)
            {
                Console.WriteLine("Debug logged : " + message);
            }
            else
            {
                base.Log(logLevel, message);
            }
        }
    }
}

