using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    public class Appointment
    {
        public string ApptID { get; set; }

        public string PatientID { get; set; }

        public string DoctorID { get; set; }

        public string apptDateTime { get; set; }

        public string Reason { get; set; }
    }
}
