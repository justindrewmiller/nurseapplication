using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class InformationDAL
    {

        public static Patient CurrentPatientInfo(string patientID)
        {
            Patient patient = new Patient();
            return patient;
        }

        public static List<Appointment> GetPatientAppointments(string patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }

        public static List<Test> GetPatientTests(string patientID)
        {
            List<Test> testList = new List<Test>();
            return testList;
        }

        public static List<Visit> GetPatientVisits(string patientID)
        {
            List<Visit> visitList = new List<Visit>();
            return visitList;
        }
    }
}
