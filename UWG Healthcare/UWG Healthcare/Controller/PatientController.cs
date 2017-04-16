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
        
        //Updates the patient
        public bool UpdatePatient(Person oldPerson, Person newPerson)
        {
            return PatientDAL.UpdatePatient(oldPerson, newPerson);
        }

        // Gets the person based on personID
        public static Person GetPatient(int personID)
        {
            return PatientDAL.GetPatient(personID);
        }

        // Gets the Patients list
        public List<Patient> GetPatients()
        {
            return PatientDAL.GetPatients();
        }
    }
}
