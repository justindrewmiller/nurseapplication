using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    //Nurse object inheriting from Person
    public class Nurse : Person
    {
        public string NurseID { get; set; }
    }
}
