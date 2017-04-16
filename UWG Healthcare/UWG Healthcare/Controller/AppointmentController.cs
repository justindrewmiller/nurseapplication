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
        public static int CreateAppointment(Appointment appointment)
        {
            return AppointmentDAL.CreateAppointment(appointment);
        }

        public static Appointment GetAppointment(int apptID)
        {
            return AppointmentDAL.GetAppointment(apptID); 
        }

        public static bool UpdateAppointment(Appointment appointment)
        {
            return AppointmentDAL.UpdateAppointment(appointment);
        } 
    }
}
