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

        //returns the patient info based on the patient id
        public static Patient CurrentPatientInfo(string patientID)
        {
            return InformationDAL.CurrentPatientInfo(patientID);
        }

        //returns a list of appointments based on the patient id
        public static List<Appointment> GetPatientAppointments(string patientID)
        {
            return InformationDAL.GetPatientAppointments(patientID);
        }

        //gets patient visit based on the patient id
        public static List<Visit> GetPatientVisits(string patientID)
        {
            return InformationDAL.GetPatientVisits(patientID);
        }

        //gets patient tests based on the patient id
        public static List<Test> GetPatientTests(string patientID)
        {
            return InformationDAL.GetPatientTests(patientID);
        }

        //gets an appointment based on the apptID
        public static Appointment GetAppointment(int apptID)
        {
            return AppointmentDAL.GetAppointment(apptID);
        }

        //Gets a test based on the apptID
        public static Test GetTest(int apptID)
        {
            return TestDAL.GetTest(apptID);
        }

        //Gets a visit based on the apptID
        public static Visit GetVisit(int apptID)
        {
            return VisitDAL.GetVisit(apptID);
        }
    }
}
