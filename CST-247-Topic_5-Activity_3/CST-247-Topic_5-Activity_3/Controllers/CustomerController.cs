using CST_247_Topic_5_Activity_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST_247_Topic_5_Activity_3.Controllers
{
    public class CustomerController : Controller
    {
        public List<CustomerModel> customers;

        public CustomerController()
        {
            customers = new List<CustomerModel>();
            for(int i = 0; i < 5; i++)
            {
                customers.Add(new CustomerModel(i, "Name" + i.ToString(), i + 20));
            }
        }

        // GET: Customer
        public ActionResult Index()
        {
            var c = Tuple.Create(customers, customers[0]);
            return View(c);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(String customerId)
        {
            var i = int.Parse(customerId);
            var c = Tuple.Create(customers, customers[i]);
            return View(c);
        }
    }
}