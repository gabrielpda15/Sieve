using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Extensions.Log
{
    public class SvLoggerProvider : ILoggerProvider
    {
        public static string Log = "";
        private readonly LogFileHandler _logHandler;

        public SvLoggerProvider(LogFileHandler logHandler)
        {
            _logHandler = logHandler;
        }

        public ILogger CreateLogger(string categoryName)
        => new LocalLogger(_logHandler);

        public void Dispose()
        { }

        private class LocalLogger : ILogger
        {
            private readonly LogFileHandler _logHandler;

            public LocalLogger(LogFileHandler logHandler)
            {
                _logHandler = logHandler;
            }

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }

            public bool IsEnabled(LogLevel logLevel)
            {
                return logLevel != LogLevel.None;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                string log = $"[{DateTime.Now}] [{logLevel.ToString().ToUpper()}] {formatter(state, exception)}\n";
                SvLoggerProvider.Log += log;
                SelectColor(logLevel);
                Console.WriteLine(log);
                Console.ResetColor();
                if (logLevel != LogLevel.Debug)
                {
                    _logHandler.Enqueue(log);
                    _logHandler.Run().GetAwaiter().GetResult();
                }
            }

            private void SelectColor(LogLevel logLevel)
            {
                switch (logLevel)
                {
                    case LogLevel.Information:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case LogLevel.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case LogLevel.Debug:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case LogLevel.Critical:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case LogLevel.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case LogLevel.Trace:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case LogLevel.None:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}
