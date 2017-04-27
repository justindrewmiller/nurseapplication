using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Diagnoses class which keeps track of the object's attributes.
    public class Diagnoses
    {
        // Gets and sets the diagnoses code
        public int DiagnosesCode { get; set;  } 

        // Gets and sets the diagnoses name
        public string DiagnosesName { get; set; }
    }
}
