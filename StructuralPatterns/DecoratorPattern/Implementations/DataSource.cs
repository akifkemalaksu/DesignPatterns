using DecoratorPattern.Interfaces;
using System.Text;

namespace DecoratorPattern.Implementations
{
    public class DataSource : IDataSource
    {
        private string _fileName = string.Empty;

        public DataSource(string fileName)
        {
            _fileName = fileName;
        }

        public string ReadData()
        {
            Console.WriteLine($"DataSource ({_fileName}): Veri okunuyor...");
            return _fileName;
        }

        public void WriteData(string file)
        {
            Console.WriteLine($"DataSource ({_fileName}): Veri belleğe yazıldı.");
        }
    }
}
