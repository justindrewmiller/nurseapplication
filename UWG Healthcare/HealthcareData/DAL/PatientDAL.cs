using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class PatientDAL
    {

        public static int AddPerson(Person person)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string insertStatement =
                "INSERT Person " +
                  "(DOB, FName, LName, Street, City, State, ZipCode, PhoneNum, SSN) " +
                "VALUES (@DOB, @FName, @LName, @Street, @City, @State, @ZipCode, @PhoneNum, @SSN)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@DOB", person.DOB);
            insertCommand.Parameters.AddWithValue("@FName", person.FName);
            insertCommand.Parameters.AddWithValue("@LName", person.LName);
            insertCommand.Parameters.AddWithValue("@Street", person.Street);
            insertCommand.Parameters.AddWithValue("@City", person.City);
            insertCommand.Parameters.AddWithValue("@State", person.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", person.ZipCode);
            insertCommand.Parameters.AddWithValue("@PhoneNum", person.PhoneNum);
            insertCommand.Parameters.AddWithValue("@SSN", person.SSN);
            try
            {
                connection.Open();

                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Person') FROM Person";
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

    }
}
