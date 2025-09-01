namespace FactoryMethodPattern.Logs
{
    public class FileLogger : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged to file, message: {message}");
        }
    }
}
