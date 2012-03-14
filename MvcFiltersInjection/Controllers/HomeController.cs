using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFiltersInjection.Infrastructure;

namespace MvcFiltersInjection.Controllers
{
    // Example copied from:
    // http://www.jacopretorius.net/2011/01/dependency-injection-in-mvc-3.html

    public class HomeController : Controller
    {
        [MessageToAction]
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
