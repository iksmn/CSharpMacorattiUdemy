// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var logger = NLog.LogManager.GetLogger("nlog");
logger.Info("Logger Started");

logger.Error("Logger Started");
logger.Warn("Logger Started");