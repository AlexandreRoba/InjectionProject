using HelloCrowd.Handlers.Solution;

namespace SitefInityWebApp.Solution
{
    public class HandlerLogger : ILogger
    {
        private readonly SitefinityLogger _logger;

        public HandlerLogger(SitefinityLogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}