﻿using System.Web;
using System.Web.Mvc;

namespace www.exclusivepainters.co.nz
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
