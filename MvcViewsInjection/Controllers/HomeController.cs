using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewsInjection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            ViewBag.X = 2;
            ViewBag.Y = 3;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
