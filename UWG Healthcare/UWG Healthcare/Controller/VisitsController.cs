using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    public class VisitsController
    {
        // Adds the person
        public int AddVisit(Visit visit)
        {
            return VisitDAL.AddVisit(visit);
        }

        //Gets a visit based on the visit id
        public static Visit GetVisit(int apptID)
        {
            return VisitDAL.GetVisit(apptID);
        }

        //gets the diagnoses based on the diagnoses code
        public static string GetDiagnoses(string diagnosesCode)
        {
            return VisitDAL.GetDiagnoses(diagnosesCode);
        }

        //returns a boolean that is true if the visit was sucessfully updated
        public static bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            return VisitDAL.UpdateVisit(oldVisit, newVisit);
        }


    }
}
