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
        public static Test GetTest(int ApptID)
        {
            Test test = new Test();

            return test;
        }

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
    }
}
