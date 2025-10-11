using AbstractFactoryPattern.Factories.Interfaces;
using AbstractFactoryPattern.Products.Azure;
using AbstractFactoryPattern.Products.Interfaces;

namespace AbstractFactoryPattern.Factories
{
    public class AzureFactory : ICloudServiceFactory
    {
        public ILogging CreateLogging() => new AppInsightsLogger();

        public IQueue CreateQueue() => new ServiceBusQueue();

        public IStorage CreateStorage() => new BlobStorage();
    }
}
