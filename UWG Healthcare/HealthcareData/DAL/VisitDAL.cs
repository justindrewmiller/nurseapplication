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
                    visit.VisitID = reader["VisitID"].ToString();
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
    }
}
