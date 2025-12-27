namespace SingletonPattern
{
    public class Logger
    {
        public static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        private readonly string _logFilePath;

        private Logger()
        {
            _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.log");
        }

        public static Logger GetInstance() => _instance.Value;

        public void Log(string message)
        {
            var logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            File.AppendAllText(_logFilePath, logMessage);

            Console.WriteLine("Log entry added. {0}", logMessage);
        }
    }
}
