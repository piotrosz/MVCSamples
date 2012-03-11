using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcModelValidation.Models
{
    public class DummyAppointmentRepository : IAppointmentRepository
    {
        public void SaveAppointment(Appointment app)
        {
            // do nothing
        }
    }
}