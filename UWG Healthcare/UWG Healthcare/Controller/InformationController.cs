using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    public class InformationController
    {

        public static Patient CurrentPatientInfo(string patientID)
        {
            return InformationDAL.CurrentPatientInfo(patientID);
        }

        public static List<Appointment> GetPatientAppointments(string patientID)
        {
            return InformationDAL.GetPatientAppointments(patientID);
        }

        public static List<Visit> GetPatientVisits(string patientID)
        {
            return InformationDAL.GetPatientVisits(patientID);
        }

        public static List<Test> GetPatientTests(string patientID)
        {
            return InformationDAL.GetPatientTests(patientID);
        }
    }
}
