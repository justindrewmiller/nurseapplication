using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // UserInfo  class which keeps track of the object's attributes.
    public class UserInfo
    {
        // Gets and sets the user ID
        public string userID { get; set; }

        // Gets and sets the user's password
        public string userPassword { get; set; }

        // Gets and sets the admin ID
        public int AdminID { get; set; }

        // Gets and sets the doctor ID
        public int DoctorID { get; set; }

        // Gets and sets the nurse ID
        public int NurseID { get; set; }

    }
}
