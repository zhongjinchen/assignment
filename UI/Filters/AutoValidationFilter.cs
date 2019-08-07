﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filters
{
    public class AutoValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewDataDictionary viewData = filterContext.Controller.ViewData;

            if (!viewData.ModelState.IsValid)
            {
                filterContext.Controller.TempData[Const.ErrorData] = viewData.ModelState;
                filterContext.Result = new RedirectToRouteResult(filterContext.RouteData.Values);
            }


            base.OnActionExecuting(filterContext);
        }
    }
}