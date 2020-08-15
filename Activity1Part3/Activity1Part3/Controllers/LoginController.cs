using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
using System.Web.Script.Serialization;
using Activity1Part3.Services.Utility;
using System.Runtime.Caching;

namespace Activity1Part3.Controllers
{
    [CustomAction]
    public class LoginController : Controller
    {
        

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            MyLogger.GetInstance().Info("Entering LoginController.Login()");
            MyLogger.GetInstance().Info("Parameters are:" + new JavaScriptSerializer().Serialize(model));

            if (!ModelState.IsValid)
            {
                return View("Login");
            }    

            SecurityService s = new SecurityService();
            bool flag = s.Authenticate(model);
            try
            {
                if (flag == true)
                {
                    Session["user"] = model;
                    MyLogger.GetInstance().Info(" Exit LoginController.Login() with login passing");
                    return View("LoginPassed");
                }
                else
                {
                    Session.Clear();
                    MyLogger.GetInstance().Info(" Exit LoginController.Login() with login failing");
                    return View("LoginFailed");
                }
            }
            catch(Exception e)
            {
                MyLogger.GetInstance().Error(" Exception in LoginController.Login()" + e.Message);
                return View("LoginFailed");
            }
            
        }

        [HttpGet]
        [CustomAuthorization]
        public String Protected()
        {
            return "Did It work??";
        }

        public ActionResult GetUsers()
        {
            List<UserModel> users = new List<UserModel>();
            var cache = MemoryCache.Default;

            users = (List<UserModel>) cache.Get("users");

            if(users == null)//Nothing in cache
            {
                users = new List<UserModel>();
                for (int i = 0; i < 10; i++)
                {
                    var user = new UserModel();
                    user.Username = "USERNAME " + i.ToString();
                    user.Password = "PASSWORD " + i.ToString();
                    users.Add(user);  
                }
                MyLogger.GetInstance().Info(" Users were not found in the cache. I got them from the data source (slow) at " + DateTime.Now);

                var policy = new CacheItemPolicy().AbsoluteExpiration = DateTime.Now.AddMinutes(1);
                cache.Set("users", users, policy);
            }
            else
            {
                MyLogger.GetInstance().Info(" Users were found in the cache (fast) at " + DateTime.Now);
            }
            
            return Content(new JavaScriptSerializer().Serialize(users));
        }
    }
}