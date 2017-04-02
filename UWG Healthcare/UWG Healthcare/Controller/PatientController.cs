using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    class PatientController
    {

        // Adds the person
        public int AddPerson(Person person)
        {
            return PatientDAL.AddPerson(person);
        }

        // Adds the patient
        public int AddPatient(Patient patient)
        {
            return PatientDAL.AddPatient(patient);
        }
    }
}
