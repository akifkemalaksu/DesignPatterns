namespace FactoryMethodPattern.Logs
{
    public class DatabaseLogger : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged to database, message: {message}");
        }
    }
}
