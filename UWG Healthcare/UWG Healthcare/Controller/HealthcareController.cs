
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

        public static bool ValidLogin(string UserName, string Password)
        {
            return UsersDAL.ValidLogin(UserName, Password);
        }

        public static UserInfo GetUser(string UserName, string Password)
        {
            return UsersDAL.GetUser(UserName, Password);
        }

    }
}
