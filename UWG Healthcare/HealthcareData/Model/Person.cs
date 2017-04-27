using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{

    //Person class which consists of a PersonID that contains many attributes to identify a person.
    public class Person
    {
        // Gets and sets the person ID
        public int PersonID { get; set; }

        // Gets and sets the date of birth
        public string DOB { get; set; }

        // Gets and sets the first name
        public string FName { get; set; }

        // Gets and sets the last name
        public string LName { get; set; }

        // Gets and sets the street address
        public string Street { get; set; }

        // Gets and sets the city
        public string City { get; set; }

        // Gets and sets the state
        public string State { get; set; }

        // Gets and sets the zip code
        public string ZipCode { get; set; }

        // Gets and sets the phone number
        public string PhoneNum { get; set; }

        // Gets and sets the social security number
        public string SSN { get; set; }
    }
}
