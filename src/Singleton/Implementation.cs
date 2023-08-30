namespace Singleton
{
    public class Logger
    {
        private static Logger? _instance;

        public static Logger Instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        protected Logger() { }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LazyLogger
    {
        private static readonly Lazy<LazyLogger> _lazyLogger = new(() => new LazyLogger());

        public static LazyLogger Instance => _lazyLogger.Value;

        protected LazyLogger() { }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

