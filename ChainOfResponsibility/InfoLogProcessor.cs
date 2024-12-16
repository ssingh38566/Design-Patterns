using NotifyMe.ChainOfResponsibility.Enums;
using System;

namespace NotifyMe.ChainOfResponsibility
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor nextLogProcessor) : base(nextLogProcessor)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if (logLevel == (int)LogTypes.Info)
            {
                Console.WriteLine("Information logged : " + message);
            }
            else
            {
                base.Log(logLevel, message);
            }
        }
    }
}

