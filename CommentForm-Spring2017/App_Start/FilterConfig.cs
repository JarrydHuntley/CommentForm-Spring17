﻿using System.Web;
using System.Web.Mvc;

namespace CommentForm_Spring2017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
