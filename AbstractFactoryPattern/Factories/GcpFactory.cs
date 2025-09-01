using AbstractFactoryPattern.Factories.Interfaces;
using AbstractFactoryPattern.Products.Gcp;
using AbstractFactoryPattern.Products.Interfaces;

namespace AbstractFactoryPattern.Factories
{
    public class GcpFactory : ICloudServiceFactory
    {
        public ILogging CreateLogging() => new StackDriverLogger();

        public IQueue CreateQueue() => new PubSubQueue();

        public IStorage CreateStorage() => new GoogleCloudStorage();
    }
}
