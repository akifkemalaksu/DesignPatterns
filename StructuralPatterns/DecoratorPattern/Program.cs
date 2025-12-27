using DecoratorPattern.Decorators;
using DecoratorPattern.Implementations;
using DecoratorPattern.Interfaces;
using System.Text;

// 1. Basit bir veri kaynağı oluştur (Artık dosya değil, bellek simülasyonu)
IDataSource source = new DataSource("deneme.txt");

source = new CompressionDecorator(source);
source = new EncryptionDecorator(source);

source.WriteData("deneme.txt");

source.ReadData();
