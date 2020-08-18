using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService2Controller : Controller
    {
        [Unity.Dependency]
        public ILogger logger { get; set; }

        public TestLoggingService2Controller()
        {
            
        }

        // GET: TestLoggingService2
        public String Index()
        {
            logger.Info("This is my test string response2");
            return "This is my test string response2";
        }
    }
}