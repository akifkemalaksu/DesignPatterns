using FactoryMethodPattern.Logs;

namespace FactoryMethodPattern.LogFactories
{
    public class FileLoggerFactory : LoggerFactory
    {
        public override ILog CreateLogger()
        {
            return new FileLogger();
        }
    }
}
