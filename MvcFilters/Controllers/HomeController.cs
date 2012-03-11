using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFilters.Infrastructure.Filters;

namespace MvcFilters.Controllers
{
    public class HomeController : Controller
    {
        //[MyException]
        //[Authorize(Users = "adam, steve, bob", Roles = "admin")]
        //[HandleError(ExceptionType = typeof(NullReferenceException), View = "SpecialError")]
        //[MyActionFilter]
        //[Profile] // Czas wykonania akcji
        //[ProfileResult] // Czas wykonania ActionResult
        [ProfileAll]
        public ActionResult Index()
        {
            //throw new NullReferenceException();
            return View();
        }
        

    }
}
