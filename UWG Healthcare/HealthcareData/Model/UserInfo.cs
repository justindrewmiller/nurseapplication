﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    public class UserInfo
    {
        public string userID { get; set; }

        public string userPassword { get; set; }

        public int AdminID { get; set; }

        public int DoctorID { get; set; }

        public int NurseID { get; set; }

    }
}
