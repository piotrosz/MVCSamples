using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModelValidation.Models;

namespace MvcModelValidation.Controllers
{
public class PersonController : Controller
{
    public ActionResult Create()
    {
        return View(new Person());
    }

    [HttpPost]
    public ActionResult Create(Person person)
    {
        if (!ModelState.IsValid)
            return View(person);
        else
            return Content("Walidacja się powiodła!");
    }

}
}
