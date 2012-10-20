using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomViewEngine.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["Message"] = "Hello MVC";
            ViewData["Time"] = DateTime.Now.ToShortTimeString();

            return View("DebugData");
        }

    }
}
