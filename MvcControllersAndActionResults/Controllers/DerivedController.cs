using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcControllersAndActionResults.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from DerivedController.Index()";

            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];

            return View("MyView");
        }

        public ActionResult Redirect()
        {
            //return new RedirectResult("/Derived/Index");
            //return Redirect("/Derived/Index");
            //return RedirectToAction("Index");
            //return RedirectToAction("Action", "MyController");

            TempData["Message"] = "Hello tempdata";
            TempData["Date"] = DateTime.Now;

            return RedirectToRoute(new
            {
                controller = "Derived",
                action = "Index",
                ID = "MyID"
            });
        }
    }
}
