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
            Users user = new Users();
            user.UserName = "TXJ";
            user.Email = "abcd@qq.com";
            user.Address = "武汉";
            ViewBag.Msg = CommonServiceAction.InserTest(user);
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