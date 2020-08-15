using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using NLog;

namespace CST_247_Topic_3_Activity2.Models
{
    public class ButtonModel
    {
        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");
        public bool State { get; set; }

        public ButtonModel(bool state)
        {

        }
    }
}