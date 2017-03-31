using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TonglBin.Web.Controllers
{
    public class BaseController : Controller
    {
        protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Equals(Session["User"], null))
            {
                filterContext.HttpContext.Response.Redirect("Login/Index", true);
            }
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            logger.Error("应用程序错误：" + filterContext.Exception.Message);
        }
    }
}