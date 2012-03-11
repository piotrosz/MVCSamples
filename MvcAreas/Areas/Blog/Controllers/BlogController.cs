using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAreas.Areas.Blog.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult ShowRecent()
        {
            return View();
        }

        public ActionResult ShowArchive()
        {
            return View();
        }
    }
}
