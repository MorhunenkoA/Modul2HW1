using System;
using System.Text;

namespace Modul2HW1
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private StringBuilder _loggers;

        static Logger()
        {
        }

        private Logger()
        {
            _loggers = new StringBuilder();
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Output(LoggerType type, string message)
        {
            var logger = $"{DateTime.UtcNow}: {type}: {message}";
            _loggers.Append(logger);
            Console.WriteLine(logger);
        }
    }
}
