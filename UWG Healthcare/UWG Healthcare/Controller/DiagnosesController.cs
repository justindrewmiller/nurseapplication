using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    public class DiagnosesController
    {

        //returns a list of the diagnoses
        public List<Diagnoses> GetDiagnosesList()
        {
            return DiagnosesDAL.GetDiagnosesList(); 
        }
    }
}
