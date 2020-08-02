using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Topic_5_Activity_3.Models;

namespace Topic_5_Activity_3.Controllers
{
    public class CustomerController : Controller
    {
        public List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            for(int i = 0; i < 5; i++)
            {
                customers.Add(new CustomerModel(i, "Name" + i.ToString(), i + 20));
            }
        }

        // GET: Customer
        public ActionResult Index()
        {
            var c = Tuple.Create(customers, customers[0]);
            return View("Customer", c);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(String CustomerNumber)
        {
            var c = Tuple.Create(customers, customers[int.Parse(CustomerNumber)]);
            return PartialView("_CustomerDetails", customers[int.Parse(CustomerNumber)]);
        }

        [HttpPost]
        public String GetMoreInfo(String CustomerNumber)
        {

            return "Coming from GetMoreInfo()";
        }
    }
}