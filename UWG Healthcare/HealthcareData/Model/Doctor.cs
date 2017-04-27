using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // Doctor class inherits from the parent class Person while adding a DoctorID attribute.
    public class Doctor : Person
    {
        // Gets and sets the doctor ID
        public int DoctorID { get; set; }

        // Gets and sets the full name of the doctor.
        public string FullName { get; set; }

        //Must be array as doctor can have multiple specialities
        public Array Speciality { get; set; }
    }
}
