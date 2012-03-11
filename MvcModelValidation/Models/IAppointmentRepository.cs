using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcModelValidation.Models
{
    public interface IAppointmentRepository
    {
        void SaveAppointment(Appointment appointment);
    }
}