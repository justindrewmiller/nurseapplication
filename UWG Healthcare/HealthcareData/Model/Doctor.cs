using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    public class Doctor : Person
    {

        public string DoctorID { get; set; }

        //Must be array as doctor can have multiple specialities
        public Array Speciality { get; set; }
    }
}
