using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloCrowd.Events;
using HelloCrowd.Handlers;
using HelloCrowd.Handlers.Solution;
using Ninject;
using Ninject.Modules;
using SiteFinityWebAppNInject.Solution;

namespace SiteFinityWebAppNInject
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


            //_logger.Log("Main created");
            //var kernel = new StandardKernel(new SitefinityModule());
            //var handler = kernel.Get<NewsHandlersWithLogger>();
            //handler.Handle(new NewsCreated("We need to log on the handler because nothing happen"));
            //_logger.Log("Main completed");
            //Console.ReadLine();


        }
    }


    //internal class SitefinityModule : NinjectModule
    //{
    //    public override void Load()
    //    {
    //        this.Bind<ILogger>().To<HandlerLogger>();
    //        this.Bind<NewsHandlersWithLogger>().To<NewsHandlersWithLogger>();
    //    }
    //}
}
