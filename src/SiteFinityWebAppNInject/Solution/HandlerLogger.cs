using HelloCrowd.Handlers.Solution;

namespace SiteFinityWebAppNInject.Solution
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