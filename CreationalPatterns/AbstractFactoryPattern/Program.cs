using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Factories.Interfaces;

ICloudServiceFactory factory = new GcpFactory();

var logger = factory.CreateLogging();
var queue = factory.CreateQueue();
var storage = factory.CreateStorage();