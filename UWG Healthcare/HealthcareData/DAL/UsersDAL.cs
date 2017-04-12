using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class UsersDAL
    {
        // ValidLogin returns true or false depending if the UserID and Password combination matches.
        public static bool ValidLogin(string UserID, string Password)
        {
            Boolean isValid;

            // Encryptes incoming password to SHA1 Hash
            String encryptedPassword = GetSHA1HashData(Password);
            UserInfo ui = new UserInfo();
            SqlConnection con = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
               "SELECT Username " +
                "FROM UserInfo " +
                "WHERE Username = @Username AND Password = @Password";
            con.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue("@Username", UserID);
            selectCommand.Parameters.AddWithValue("@Password", encryptedPassword);
            SqlDataAdapter da = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            con.Close();
            return isValid;
        }

        // Gets the Gets the User's information via the Username and Password
        public static UserInfo GetUser(string username, string password)
        {

            String encryptedPassword = GetSHA1HashData(password);
            UserInfo user = new UserInfo();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
               "SELECT Username, Password, AdminID, DoctorID, NurseID " +
                "FROM UserInfo " +
                "WHERE Username = @Username AND Password = @Password";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Username", username);
            selectCommand.Parameters.AddWithValue("@Password", encryptedPassword);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    user.userID = reader["Username"].ToString();
                    user.userPassword = reader["Password"].ToString();
                    if (reader.IsDBNull(reader.GetOrdinal("AdminID")) == false) {
                        user.AdminID = (int)reader["AdminID"];
                    }
                    if (reader.IsDBNull(reader.GetOrdinal("DoctorID")) == false)
                    {
                        user.DoctorID = (int)reader["DoctorID"];
                    }
                    if (reader.IsDBNull(reader.GetOrdinal("NurseID")) == false)
                    {
                        user.NurseID = (int)reader["NurseID"];
                    }
                }
                else
                {
                    user = null;
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
            return user;
        }

        /// <summary>
        /// take any string and encrypt it using SHA1 then
        /// return the encrypted data
        /// </summary>
        /// <param name="data">input text you will enterd to encrypt it</param>
        /// <returns>return the encrypted text as hexadecimal string</returns>
        private static string GetSHA1HashData(string data)
        {
            //create new instance of md5
            SHA1 sha1 = SHA1.Create();

            //convert the input text to array of bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            return returnValue.ToString();
        }
    }
}