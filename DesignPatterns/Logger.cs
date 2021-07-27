using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface ILogger 
    {
        void Log(string message);
        void LogError(string message, Exception ex);
        string Nome { get; set; }
    }

    public class Logger : ILogger
    {
        private Logger() { }
        public string Nome { get; set; }

        private static ILogger _singleton_object;
        public static ILogger GetInstance() 
        {
            if (_singleton_object == null)
                _singleton_object = new Logger();

            return _singleton_object;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(string message, Exception ex)
        {
            Console.WriteLine($"message -> {message}\n" +
                $"error message -> {ex.Message}");
        }
    }
}
