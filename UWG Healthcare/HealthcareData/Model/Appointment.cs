using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Appointment class which keeps track of the object's attributes.
    public class Appointment
    {
        // Gets and sets the appointment ID
        public int ApptID { get; set; }

        // Gets and sets the patient ID
        public int PatientID { get; set; }

        // Gets and sets the doctor ID
        public int DoctorID { get; set; }

        // Gets and sets the appointment date and time
        public string apptDateTime { get; set; }

        // Gets and sets the reason for the appointment
        public string Reason { get; set; }

        // Gets and sets if the patient is checked into the appointment
        public string isCheckedIn { get; set; }
    }
}
