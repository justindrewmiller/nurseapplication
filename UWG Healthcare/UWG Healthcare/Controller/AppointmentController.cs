using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    public class AppointmentController
    {

        // Creates the appointment
        public int CreateAppointment(Appointment appointment)
        {
            return AppointmentDAL.CreateAppointment(appointment);
        }

        public Appointment GetAppointment(int apptID)
        {
            return AppointmentDAL.GetAppointment(apptID); 
        }
    }
}
