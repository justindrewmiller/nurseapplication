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
        public static List<Patient> SearchPatientsByDOB(string DOB)
        {
            return PatientDAL.SearchPatientByDOB(DOB);
        }

        public static List<Patient> SearchPatientsByFullName(string FName, string LName)
        {
            return PatientDAL.SearchPatientByFullName(FName, LName);
        }

        public static List<Patient> SearchPatientsByLastNameAndDOB(string DOB, string LName)
        {
            return PatientDAL.SearchPatientByLastNameAndDOB(DOB, LName);
        }
    }
}
