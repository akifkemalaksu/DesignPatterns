using AbstractFactoryPattern.Factories.Interfaces;
using AbstractFactoryPattern.Products.Aws;
using AbstractFactoryPattern.Products.Interfaces;

namespace AbstractFactoryPattern.Factories
{
    public class AwsFactory : ICloudServiceFactory
    {
        public ILogging CreateLogging() => new CloudWatchLogger();

        public IQueue CreateQueue() => new SqsQueue();

        public IStorage CreateStorage() => new S3Storage();
    }
}
