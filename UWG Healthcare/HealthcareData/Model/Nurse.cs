using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Nurse class inherits from the parent class Person while adding a NurseID attribute.
    public class Nurse : Person
    {
        // Gets and sets the nurse ID
        public string NurseID { get; set; }
    }
}
