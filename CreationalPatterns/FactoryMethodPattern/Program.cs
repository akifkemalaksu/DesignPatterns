using FactoryMethodPattern.LogFactories;

LoggerFactory factory = new DatabaseLoggerFactory();

var logger = factory.CreateLogger();

logger.Log("log atildi.");