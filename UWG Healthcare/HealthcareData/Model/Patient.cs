using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Patient class inherits from the parent class Person while adding a PatientID attribute.
    public class Patient : Person
    {
        // Gets and sets the patient ID
        public int PatientID { get; set; }

        // Gets and sets the full name of the patient
        public string FullName { get; set; }

    }
}
