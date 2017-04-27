using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Test class which consists of attributes that make up the object
    public class Test
    {
        // Gets and sets the test code
        public int TestCode { get; set; }

        // Gets and sets the test name
        public string TestName { get; set; }

        // Gets and sets the test date
        public string TestDate { get; set; }

        // Gets and sets the appointment ID
        public string ApptID { get; set; }
        
        // Gets and sets the results
        public string Result { get; set; }
    }
}
