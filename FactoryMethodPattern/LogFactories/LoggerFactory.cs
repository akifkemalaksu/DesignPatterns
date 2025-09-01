using FactoryMethodPattern.Logs;

namespace FactoryMethodPattern.LogFactories
{
    public abstract class LoggerFactory
    {
        public abstract ILog CreateLogger();
    }
}
