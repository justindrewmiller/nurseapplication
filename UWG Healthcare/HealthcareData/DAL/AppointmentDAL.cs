using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class AppointmentDAL
    {

        // Inserts into the Appointment table
        public static int CreateAppointment(Appointment appointment)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string insertStatement =
                "INSERT Appointment " +
                  "(PatientID, DoctorID, apptDateTime, Reason) " +
                "VALUES (@PatientID, @DoctorID, @apptDateTime, @Reason)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PatientID", appointment.PatientID);
            insertCommand.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
            insertCommand.Parameters.AddWithValue("@apptDateTime", appointment.apptDateTime);
            insertCommand.Parameters.AddWithValue("@Reason", appointment.Reason);
            try
            {
                connection.Open();

                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Appointment') FROM Appointment";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int ApptID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return ApptID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Appointment> getAppointments(String patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();

            return appointmentList;
        }
    }
}
