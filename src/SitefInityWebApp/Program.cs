using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloCrowd.Events;
using HelloCrowd.Handlers;

namespace SitefInityWebApp
{
    class Program
    {
        private static SitefinityLogger _logger;

        static Program()
        {
            _logger = new SitefinityLogger();
        }

        static void Main(string[] args)
        {
            _logger.Log("Main created");
            var handler = new NewsHandlers();
            handler.Handle(new NewsCreated("We need to log on the handler because nothing happen"));
            _logger.Log("Main completed");
            Console.ReadLine();

        }
    }
}
