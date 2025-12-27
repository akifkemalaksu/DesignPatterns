using DecoratorPattern.Interfaces;
using System.Security.Cryptography;

namespace DecoratorPattern.Decorators
{
    public class DataSourceDecorator : IDataSource
    {
        protected readonly IDataSource _wrappee;

        public DataSourceDecorator(IDataSource source)
        {
            _wrappee = source;
        }

        public virtual string ReadData()
        {
            Console.WriteLine($"DataSourceDecorator: Veri okunuyor...");
            return _wrappee.ReadData();
        }

        public virtual void WriteData(string file)
        {
            Console.WriteLine($"DataSourceDecorator: Veri yazılıyor...");
            _wrappee.WriteData(file);
        }
    }
}
