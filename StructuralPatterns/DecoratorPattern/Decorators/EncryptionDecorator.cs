using DecoratorPattern.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace DecoratorPattern.Decorators
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source)
        {
        }

        public override void WriteData(string file)
        {
            Console.WriteLine($"EncryptionDecorator: Veri şifreleniyor...");
            base.WriteData(file);
        }

        public override string ReadData()
        {
            Console.WriteLine($"EncryptionDecorator: Veri açılıyor...");
            return base.ReadData();
        }
    }
}
