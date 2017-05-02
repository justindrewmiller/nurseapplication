using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    public class SearchController
    {

        //returns a list of patients based on the patient DOB
        public static List<Patient> SearchPatientsByDOB(string DOB)
        {
            return PatientDAL.SearchPatientByDOB(DOB);
        }

        //returns a list of patients based on their full name
        public static List<Patient> SearchPatientsByFullName(string FName, string LName)
        {
            return PatientDAL.SearchPatientByFullName(FName, LName);
        }

        //returns a list of patients based on their last name and dob
        public static List<Patient> SearchPatientsByLastNameAndDOB(string DOB, string LName)
        {
            return PatientDAL.SearchPatientByLastNameAndDOB(DOB, LName);
        }
    }
}
