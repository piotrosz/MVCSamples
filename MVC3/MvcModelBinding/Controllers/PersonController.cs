using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModelBinding.Models;

namespace MvcModelBinding.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            Person person = new Person()
            {
                BirthDate = new DateTime(1943, 12, 12),
                FirstName = "Wiktor",
                LastName = "Stoczkowski",
                IsApproved = true,
                PersonId = 34,
                Role = Role.Guest
            };

            return View(person);
        }

        [HttpPost]
        public ActionResult Index(

            //[Bind(Include="FirstName")]
            [Bind(Exclude="IsApproved, Role")]
            Person firstPerson, 
            
            [Bind(Prefix="myPerson")]
            Person myPerson)
        {


            return View();
        }

        public ActionResult List()
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person());
            personList.Add(new Person());
            personList.Add(new Person());

            return View(personList);
        }

        [HttpPost]
        public ActionResult List(List<Person> people, FormCollection collection)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(people[i].FirstName))
                {
                    ModelState.AddModelError("[" + i + "].FirstName", "FirstName " + i + " error");
                }

                if (string.IsNullOrWhiteSpace(people[i].LastName))
                {
                    ModelState.AddModelError("[" + i + "].LastName", "LastName " + i + " error");
                }

                if (string.IsNullOrWhiteSpace(people[i].Letter))
                {
                    ModelState.AddModelError("[" + i + "].Letter", "Letter " + i + " error");
                }
            }

            return View(people);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(IDictionary<string, Person> people)
        {

            return View();
        }
    }
}
