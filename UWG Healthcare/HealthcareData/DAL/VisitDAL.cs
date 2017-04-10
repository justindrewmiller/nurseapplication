using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class VisitDAL
    {

        // Inserts into the Visits table
        public static int AddVisit(Visit visit)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string insertStatement =
                "INSERT Visits " +
                  "(ApptID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms, NurseID, DiagnosesCode) " +
                "VALUES (@ApptID, @SysBP, @DiaBP, @BodyTemp, @Pulse, @Symptoms, @NurseID, @DiagnosesCode)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@ApptID", visit.ApptID);
            insertCommand.Parameters.AddWithValue("@SysBP", visit.SysBP);
            insertCommand.Parameters.AddWithValue("@DiaBP", visit.DiaBP);
            insertCommand.Parameters.AddWithValue("@BodyTemp", visit.BodyTemp);
            insertCommand.Parameters.AddWithValue("@Pulse", visit.Pulse);
            insertCommand.Parameters.AddWithValue("@Symptoms", visit.Symptoms);
            insertCommand.Parameters.AddWithValue("@NurseID", visit.NurseID);
            insertCommand.Parameters.AddWithValue("@DiagnosesCode", visit.DiagnosesCode);
            try
            {
                connection.Open();

                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Visits') FROM Visits";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int personID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return personID;
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

        public static Visit GetVisit(string visitID)
        {
            Visit visit = new Visit();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "SELECT v.VisitID, v.ApptID, v.SysBP, v.DiaBP, v.BodyTemp, v.Pulse, v.Symptoms, v.NurseID, v.DiagnosesCode " +
                "FROM Visits v " +
                "WHERE v.VisitID = @VisitID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@VisitID", visitID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    visit.VisitID = (int)reader["VisitID"];
                    visit.ApptID = reader["ApptID"].ToString();
                    visit.SysBP = reader["SysBP"].ToString();
                    visit.DiaBP = reader["DiaBP"].ToString();
                    visit.BodyTemp = reader["BodyTemp"].ToString();
                    visit.Pulse = reader["Pulse"].ToString();
                    visit.Symptoms = reader["Symptoms"].ToString();
                    visit.NurseID = reader["NurseID"].ToString();
                    visit.DiagnosesCode = reader["DiagnosesCode"].ToString();
                }
                else
                {
                    visit = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return visit;
        }

        public static string GetDiagnoses(string diagnosesCode)
        {
            string diagnoses = "";
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "SELECT DiagnosesName " +
                "FROM Diagnoses " +
                "WHERE DiagnosesCode = @DiagnosesCode";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@DiagnosesCode", diagnosesCode);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    diagnoses = reader["DiagnosesName"].ToString();
                }
                else
                {
                    diagnoses = "";
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return diagnoses;
        }
    }
}
