// See https://aka.ms/new-console-template for more information
using NotifyMe.ChainOfResponsibility;
using NotifyMe.ChainOfResponsibility.Enums;

Console.WriteLine("Hello, World!");

var logProcessor = new InfoLogProcessor(new ErrorLogProcessor(new DebugLogProcessor(null)));

logProcessor.Log((int)LogTypes.Info, "Test");
logProcessor.Log((int)LogTypes.Debug, "Test");
logProcessor.Log((int)LogTypes.Error, "Test");
Console.Read();
