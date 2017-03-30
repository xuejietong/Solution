using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TonglBin.Model;
using TonglBin.Web.ServiceAction;

namespace TonglBin.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //ViewData["Users"] = CommonServiceAction.GetUsers();
            //ViewData["UsersRemote"] = CommonServiceAction.GetUsersRemote();

            ViewData["Users"]= new List<Users>();
            ViewData["UsersRemote"] = new List<Users>();

            logger.Debug("用Log4Net写入数据库日志");
            logger.Error("这是一个错误日志");
            logger.Fatal("这是一个致命的错误日志");
            logger.Warn("这是一个警告日志");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}