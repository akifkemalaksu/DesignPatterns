using FactoryMethodPattern.Logs;

namespace FactoryMethodPattern.LogFactories
{
    public abstract class LoggerFactory
    {
        public abstract ILog CreateLogger();
    }

    public class FileLoggerFactory : LoggerFactory
    {
        public override ILog CreateLogger()
        {
            return new FileLogger();
        }
    }

    public class DatabaseLoggerFactory : LoggerFactory
    {
        public override ILog CreateLogger()
        {
            return new DatabaseLogger();
        }
    }
}
