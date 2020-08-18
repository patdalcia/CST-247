using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService1Controller : Controller
    {
        private ILogger Logger { get; }

        public TestLoggingService1Controller(ILogger logger)
        {            
            this.Logger = logger;
        }

        // GET: TestLoggingService1
        public String Index()
        {
            Logger.Info("This is my test string response");
            return "This is my test String response"; 
        }
    }
}