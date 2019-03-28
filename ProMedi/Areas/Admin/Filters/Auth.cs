using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProMedi.Areas.Admin.Filters
{
    public class Auth:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["AdminLogin"] == null)
            {
                filterContext.Result = new RedirectResult("~/admin");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}