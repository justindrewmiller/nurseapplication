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
    public class UsersDAL
    {
        // ValidLogin returns true or false depending if the UserID and Password combination matches.
        //REMEMBER TO CHANGE DATASOURCE TO YOUR SERVER AND MAKE SURE INITIAL CATALOG IS CS6232-G2 FOR OUR DATABASE.
        public static bool ValidLogin(string UserID, string Password)
        {
            Boolean isValid;
            UserInfo ui = new UserInfo();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=CS6232-g2;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username FROM UserInfo WHERE Username='" + UserID + "'AND Password='" + Password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        // Gets the user name of the person who is logged in.
        public static String GetUserInfo(string UserID, string Password)
        {
            string userName;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-FDKRONK;Initial Catalog=CS6232-g2;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username FROM UserInfo WHERE Username='" + UserID + "'AND Password='" + Password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                userName = dt.Rows[0][0].ToString();
            }
            else
            {
                userName = "";
            }
            con.Close();
            return userName;
        }
    }
}