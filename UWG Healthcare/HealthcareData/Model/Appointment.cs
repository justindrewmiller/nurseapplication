using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    public class Appointment
    {
        public int ApptID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public string apptDateTime { get; set; }

        public string Reason { get; set; }

        public string isCheckedIn { get; set; }
    }
}
