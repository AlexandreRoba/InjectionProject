using System;
using HelloCrowd.Events;

namespace HelloCrowd.Handlers.Solution
{
    public class NewsHandlersWithLogger
    {
        private ILogger _logger;

        public NewsHandlersWithLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Handle(NewsCreated message)
        {
            _logger.Log("We are logging from the logger");
            //We still do nothing but at least it is logged.....
        }

    }
}