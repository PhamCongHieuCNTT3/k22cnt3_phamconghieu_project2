﻿using System.Web;
using System.Web.Mvc;

namespace K22CNT3_PHAMCONGHIEU_PROJECT2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
