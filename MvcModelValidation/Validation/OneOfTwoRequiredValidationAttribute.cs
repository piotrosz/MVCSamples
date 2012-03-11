using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcModelValidation.Models;

namespace MvcModelValidation.Validation
{
    // Jedna z dwóch nazw jest wymagana
    public class OneOfTwoRequiredValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var appointment = value as Appointment;

            return !string.IsNullOrWhiteSpace(appointment.Name1) ||
                   !string.IsNullOrWhiteSpace(appointment.Name2);
        }

    }
}