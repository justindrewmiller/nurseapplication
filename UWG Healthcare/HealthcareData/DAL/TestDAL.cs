using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class TestDAL
    {
        //return the test from the appointment ID
        public static Test GetTest(int ApptID)
        {
            Test test = new Test();
            return test;
        }


        //get list of available tests
        public static List<Test> GetTests()
        {

            List<Test> testList = new List<Test>();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "SELECT TestCode, TestName FROM LabTests Order by TestName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Test test = new Test();
                    test.TestCode = (int)reader["TestCode"];
                    test.TestName = reader["TestName"].ToString();
                    testList.Add(test);
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
            return testList;
        }

        //submit an order for a test
        public static void OrderTest(int apptID, DateTime testDate, int testCode)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string insertStatement =
                "INSERT INTO TestResults " +
                  "(TestCode, ApptID, TestDate) " +
                "VALUES (@TestCode, @ApptID, @TestDate)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@TestCode", testCode);
            insertCommand.Parameters.AddWithValue("@ApptID", apptID);
            insertCommand.Parameters.AddWithValue("@TestDate", testDate);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
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

        //update the test result
        public static bool UpdateTest(Test test)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string updateStatement =
                "Update TestResults SET " +
                   "Result = @Result " +
                 "WHERE ApptID = @ApptID " +
                 "AND TestCode = @TestCode AND testDate = @TestDate ";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@ApptID", test.ApptID);
            updateCommand.Parameters.AddWithValue("@TestCode", test.TestCode);
            updateCommand.Parameters.AddWithValue("@TestDate", test.TestDate);
            updateCommand.Parameters.AddWithValue("@Result", test.Result);
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
