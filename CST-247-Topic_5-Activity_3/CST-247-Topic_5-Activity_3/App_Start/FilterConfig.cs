﻿using System.Web;
using System.Web.Mvc;

namespace CST_247_Topic_5_Activity_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}