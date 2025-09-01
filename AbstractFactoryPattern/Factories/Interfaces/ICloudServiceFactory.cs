using AbstractFactoryPattern.Products.Interfaces;

namespace AbstractFactoryPattern.Factories.Interfaces
{
    public interface ICloudServiceFactory
    {
        ILogging CreateLogging();
        IQueue CreateQueue();
        IStorage CreateStorage();
    }
}
