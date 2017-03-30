using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{

    //basic person class that can basic person objects
    public class Person
    {
        public string PersonID { get; set; }

        public string DOB { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNum { get; set; }

        public string SSN { get; set; }
    }
}
