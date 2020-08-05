using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CST_247_Topic_3_Activity2.Models;

namespace CST_247_Topic_3_Activity2.Controllers
{
    public class TestController : Controller
    {
        public List<UserModel> list;
        // GET: Test
        public ActionResult Index()
        {
            list = new List<UserModel>();
            list.Add(new UserModel("Patrick", "FakeEmail1", "FakePhoneNumber1"));
            list.Add(new UserModel("George", "FakeEmail2", "FakePhoneNumber2"));
            list.Add(new UserModel("Felix", "FakeEmail3", "FakePhoneNumber3"));
            list.Add(new UserModel("Jeremy", "FakeEmail4", "FakePhoneNumber4"));
            list.Add(new UserModel("Noah", "FakeEmail5", "FakePhoneNumber5"));
            return View("Test", list);
        }
    }
}