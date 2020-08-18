using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService3Controller : Controller
    {
        private ILogger Logger { get; }

        private ITestService Service { get; }

        public TestLoggingService3Controller(ILogger logger, ITestService service)
        {
            this.Logger = logger;
            this.Service = service;
        }

        // GET: TestLoggingService3
        public String Index()
        {
            Logger.Info("This is my test string 3");
            Service.TestLogger();
            return "This is my test string 3";
        }
    }
}