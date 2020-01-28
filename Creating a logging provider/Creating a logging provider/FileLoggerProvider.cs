using Microsoft.Extensions.Logging;

namespace Creating_a_logging_provider
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private string path;

        public FileLoggerProvider(string _path)
        {
            path = _path;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(path);
        }

        public void Dispose()
        {
        }
    }
}