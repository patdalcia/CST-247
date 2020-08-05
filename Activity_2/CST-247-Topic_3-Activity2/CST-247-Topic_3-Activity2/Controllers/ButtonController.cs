using CST_247_Topic_3_Activity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CST_247_Topic_3_Activity2.Controllers
{
    public class ButtonController : Controller
    {
        public static List<ButtonModel> buttonList = new List<ButtonModel>();

        // GET: Button
        public ActionResult Index()
        {
            buttonList.Add(new ButtonModel(false));
            buttonList.Add(new ButtonModel(false));
            return View("Button", buttonList);
        }

        public ActionResult OnButtonClick(String mine)
        {
            switch (mine)
            {
                case "1":
                    if (buttonList[0].State)
                    {
                        buttonList[0].State = false;
                    }
                    else
                    {
                        buttonList[0].State = true;
                    }
                    break;

                case "2":
                    if (buttonList[1].State)
                    {
                        buttonList[1].State = false;
                    }
                    else
                    {
                        buttonList[1].State = true;
                    }
                    break;

                default:

                    break;
            }
            return View("Button", buttonList);
        }
    }
}