using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcModelValidation.Validation;

namespace MvcModelValidation.Models
{
    [AppointmentValidator]
    public class Appointment
    {
        [Required]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a date")]
        [FutureDate(ErrorMessage="Please enter future date")]
        public DateTime Date { get; set; }
        
        //[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms")]
        [MustBeTrue(ErrorMessage = "You must accept the terms")]
        public bool TermsAccepted { get; set; }

        public string Name1 { get; set; }
        public string Name2 { get; set; }
    }
}