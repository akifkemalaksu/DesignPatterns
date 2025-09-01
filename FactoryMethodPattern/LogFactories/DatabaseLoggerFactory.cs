using FactoryMethodPattern.Logs;

namespace FactoryMethodPattern.LogFactories
{
    public class DatabaseLoggerFactory : LoggerFactory
    {
        public override ILog CreateLogger()
        {
            return new DatabaseLogger();
        }
    }
}
