using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource source) : base(source)
        {
        }

        public override void WriteData(string file)
        {
            Console.WriteLine($"CompressionDecorator: Veri sıkıştırılıyor...");
            base.WriteData(file);
        }

        public override string ReadData()
        {
            Console.WriteLine($"CompressionDecorator: Veri açılıyor...");
            return base.ReadData();
        }
    }
}
