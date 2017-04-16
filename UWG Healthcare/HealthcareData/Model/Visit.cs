using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    public class Visit
    {
        public int VisitID { get; set; }

        public string ApptID { get; set; }

        public string SysBP { get; set; }

        public string DiaBP { get; set; }

        public string BodyTemp { get; set; }

        public string Pulse { get; set; }

        public string Symptoms { get; set; }

        public string NurseID { get; set; }

        public string DiagnosesCode { get; set; }

        public DateTime ApptDateTime { get; set; }
        public string DiagnosesName { get; set; }
    }
}
