using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    class PatientDAL
    {

        //public static int AddIncident(Incident incident)
        //{
        //    SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
        //    string insertStatement =
        //        "INSERT Incidents " +
        //          "(CustomerID, ProductCode, DateOpened, Title, Description) " +
        //        "VALUES (@CustomerID, @ProductCode, @DateOpened, @Title, @Description)";
        //    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
        //    insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
        //    insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
        //    insertCommand.Parameters.AddWithValue("@DateOpened", incident.DateOpened);
        //    insertCommand.Parameters.AddWithValue("@Title", incident.Title);
        //    insertCommand.Parameters.AddWithValue("@Description", incident.Description);
        //    try
        //    {
        //        connection.Open();

        //        insertCommand.ExecuteNonQuery();
        //        string selectStatement =
        //            "SELECT IDENT_CURRENT('Incidents') FROM Incidents";
        //        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        //        int incidentID = Convert.ToInt32(selectCommand.ExecuteScalar());
        //        return incidentID;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
    }
}
