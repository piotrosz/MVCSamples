using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNinjectApplication.Controllers
{
    public class HomeController : Controller
    {
        private IMessageService service;

        public HomeController(IMessageService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            ViewBag.Message = service.TodaysMessage;

            return View();
        }

    }
}
