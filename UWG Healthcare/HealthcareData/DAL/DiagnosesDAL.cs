using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class DiagnosesDAL
    {
        /// <summary>
        /// Gets a list holding the diagnoses held in the sql database
        /// </summary>
        /// <returns>List of Diagnoses objects</returns>
        public static List<Diagnoses> GetDiagnosesList()
        {

            List<Diagnoses> diagnosesList = new List<Diagnoses>();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "SELECT DiagnosesCode, DiagnosesName FROM Diagnoses Order by DiagnosesCode";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Diagnoses diag = new Diagnoses();
                    diag.DiagnosesCode = (int)reader["DiagnosesCode"];
                    diag.DiagnosesName = reader["DiagnosesName"].ToString();
                    diagnosesList.Add(diag);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return diagnosesList;
        }
    }
}
