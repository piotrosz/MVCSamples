using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModelBinding.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(List<string> movies)
        {
            return View();
        }

        public ActionResult Clock(DateTime currentTime)
        {
            return Content("The time is " + currentTime.ToLongTimeString());
        }
    }
}
