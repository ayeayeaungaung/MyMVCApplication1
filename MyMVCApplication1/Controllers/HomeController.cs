using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome To Winnie Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page ,You can know contact";

            return View();
        }
    }
}