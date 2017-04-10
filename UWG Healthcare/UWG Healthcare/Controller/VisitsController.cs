using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    class VisitsController
    {
        // Adds the person
        public int AddVisit(Visit visit)
        {
            return VisitDAL.AddVisit(visit);
        }
    }
}
