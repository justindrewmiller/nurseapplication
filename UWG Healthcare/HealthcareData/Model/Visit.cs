using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Visit class which keeps track of the object's attributes.
    public class Visit
    {
        // Gets and sets the visit ID
        public int VisitID { get; set; }

        // Gets and sets the appointment ID
        public string ApptID { get; set; }

        // Gets and sets the systolic blood pressure value
        public string SysBP { get; set; }

        // Gets and sets the diastolic blood pressure value
        public string DiaBP { get; set; }

        // Gets and sets the body temperature value
        public string BodyTemp { get; set; }

        // Gets and sets the pulse value
        public string Pulse { get; set; }

        // Gets and sets the symptoms information
        public string Symptoms { get; set; }

        // Gets and sets the nurse ID
        public string NurseID { get; set; }

        // Gets and sets the diagnoses code
        public int DiagnosesCode { get; set; }

        // Gets and sets the appointment date and time
        public DateTime ApptDateTime { get; set; }

        // Gets and sets the diagnoses name
        public string DiagnosesName { get; set; }
    }
}
