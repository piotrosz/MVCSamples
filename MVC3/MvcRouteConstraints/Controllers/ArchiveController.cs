using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MvcRouteConstraints.Controllers
{
    public class ArchiveController : Controller
    {
        public ActionResult Index(int year, int month, int day)
        {
            ViewData["Year"] = year;
            ViewData["Month"] = month;
            ViewData["Day"] = day;

            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //List<Tuple<int, string>> vals = new List<Tuple<int,string>>()
            //{   new Tuple<int, string>(0, "x"),
            //    new Tuple<int, string>(1, "y") };
            //string serialized = serializer.Serialize(vals);

            return View();
        }
    }
}
