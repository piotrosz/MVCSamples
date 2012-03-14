using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTemplatedViewHelpers.Models;

namespace MvcTemplatedViewHelpers.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            var person = PersonRepository.GetPerson();

            return View(person);
        }

    }
}
