
using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    //Controller to prevent coupling
    public class HealthcareController
    {

        //checks if login is valid
        public static bool ValidLogin(string UserName, string Password)
        {
            return UsersDAL.ValidLogin(UserName, Password);
        }

        //gets the user info based on the username and their password
        public static UserInfo GetUser(string UserName, string Password)
        {
            return UsersDAL.GetUser(UserName, Password);
        }

    }
}
