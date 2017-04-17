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

        public static Visit GetVisit(int apptID)
        {
            return VisitDAL.GetVisit(apptID);
        }

        public static string GetDiagnoses(string diagnosesCode)
        {
            return VisitDAL.GetDiagnoses(diagnosesCode);
        }

        public static bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            return VisitDAL.UpdateVisit(oldVisit, newVisit);
        }


    }
}
