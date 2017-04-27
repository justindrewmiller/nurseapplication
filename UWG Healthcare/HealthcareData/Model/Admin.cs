using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Admin class inherits from the parent class Person while adding an AdminID attribute.
    public class Admin : Person
    {
        // Gets and sets the AdminID
        public string AdminID { get; set; }
    }
}
