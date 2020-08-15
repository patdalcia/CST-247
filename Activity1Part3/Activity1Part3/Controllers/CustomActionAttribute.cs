using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //MyLogger.GetInstance().Info(" OnActionExecuted --> Controller Name: " + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName);
           // MyLogger.GetInstance().Info(" OnActionExecuted --> Action Name: " + filterContext.ActionDescriptor.ActionName);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
          //  MyLogger.GetInstance().Info(" OnActionExecuting --> Controller Name: " + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName);
            //MyLogger.GetInstance().Info(" OnActionExecuting --> Action Name: " + filterContext.ActionDescriptor.ActionName);
        }
    }
}