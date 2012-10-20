using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModelValidation.Models;

namespace MvcModelValidation.Controllers
{
    public class AppointmentController : Controller
    {
        private IAppointmentRepository repository;

        public AppointmentController(IAppointmentRepository repo)
        {
            this.repository = repo;
        }

        public ActionResult MakeBooking()
        {
            return View(new Appointment() { Date = DateTime.Now });
        }

        [HttpPost]
        public ActionResult MakeBooking(Appointment appt)
        {
            //if (string.IsNullOrEmpty(appt.ClientName))
            //{
            //    ModelState.AddModelError("ClientName", "Please enter your name");
            //}
            //if (ModelState.IsValidField("Date") && DateTime.Now > appt.Date)
            //{
            //    ModelState.AddModelError("Date", "Please enter a date in the future");
            //}
            //if (!appt.TermsAccepted)
            //{
            //    ModelState.AddModelError("TermsAccepted", "You must accept the terms");
            //}

            if (ModelState.IsValid)
            {
                repository.SaveAppointment(appt);
                return View("Completed", appt);
            }
            else
            {
                return View();
            }
        }

    }
}
