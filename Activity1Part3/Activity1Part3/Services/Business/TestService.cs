﻿using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Activity1Part3.Services.Business
{
    public class TestService : ITestService
    {
        private ILogger logger { get; set; }

        public TestService() { }

        [InjectionMethod]
        public void Initialize(ILogger logger)
        {
            this.logger = logger;
        }

        public void TestLogger()
        {
            logger.Info("Test Logging in TestService.TestLogger() invoked.");
        }
    }
}