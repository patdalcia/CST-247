using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class CustomAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            SecurityService service = new SecurityService();

            var user = (UserModel)filterContext.HttpContext.Session["user"];
            bool flag = false;

            if(user != null)
            {
                flag = service.Authenticate(user);
            }

            if (flag)
            {
                //Do nothing
            }
            else
            {
                filterContext.Result = new RedirectResult("/Login");
            }
        }
    }
}