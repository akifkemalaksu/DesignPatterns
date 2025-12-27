namespace DecoratorPattern.Interfaces
{
    public interface IDataSource
    {
        void WriteData(string file);
        string ReadData();
    }
}
