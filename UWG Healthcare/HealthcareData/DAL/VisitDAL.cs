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
                "INSERT INTO Visits " +
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

        /// <summary>
        /// Gets the visit based on the visit id
        /// </summary>
        /// <param name="visitID">visit id used to find the visit</param>
        /// <returns>a visit object</returns>
        public static Visit GetVisit(int visitID)
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
                    visit.DiagnosesCode = (int)reader["DiagnosesCode"];
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

        /// <summary>
        /// Gets the diagnoses based on the diagnoses code
        /// </summary>
        /// <param name="diagnosesCode"> diagnoses code to use for finding the string</param>
        /// <returns>a string</returns>
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

        //Updates the Visit information
        public static bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string updateStatement =
                "UPDATE Visits SET " +
                  "SysBP = @NewSysBP, " +
                  "DiaBP = @NewDiaBP, " +
                  "BodyTemp = @NewBodyTemp, " +
                  "Pulse = @NewPulse, " +
                  "Symptoms = @NewSymptoms, " +
                  "NurseID = @NewNurseID, " +
                  "DiagnosesCode = @NewDiagnoses " +
                "WHERE VisitID = @OldVisitID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewSysBP", newVisit.SysBP);
            updateCommand.Parameters.AddWithValue("@NewDiaBP", newVisit.DiaBP);
            updateCommand.Parameters.AddWithValue("@NewBodyTemp", newVisit.BodyTemp);
            updateCommand.Parameters.AddWithValue("@NewPulse", newVisit.Pulse);
            updateCommand.Parameters.AddWithValue("@NewSymptoms", newVisit.Symptoms);
            updateCommand.Parameters.AddWithValue("@NewNurseID", newVisit.NurseID);
            updateCommand.Parameters.AddWithValue("@NewDiagnoses", newVisit.DiagnosesCode);

            updateCommand.Parameters.AddWithValue("@OldVisitID", oldVisit.VisitID);

            updateCommand.Parameters.AddWithValue("@OldSysBP", oldVisit.SysBP);
            updateCommand.Parameters.AddWithValue("@OldDiaBP", oldVisit.DiaBP);
            updateCommand.Parameters.AddWithValue("@OldBodyTemp", oldVisit.BodyTemp);
            updateCommand.Parameters.AddWithValue("@OldPulse", oldVisit.Pulse);
            updateCommand.Parameters.AddWithValue("@OldSymptoms", oldVisit.Symptoms);
            updateCommand.Parameters.AddWithValue("@OldNurseID", oldVisit.NurseID);
            updateCommand.Parameters.AddWithValue("@OldDiagnoses", oldVisit.DiagnosesCode);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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


    }
}
