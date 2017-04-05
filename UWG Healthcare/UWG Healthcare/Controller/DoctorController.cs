using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    public class DoctorController
    {
        // Gets the Doctors list
        public List<Doctor> GetDoctors()
        {
            return DoctorDAL.GetDoctors();
        }
    }

 
}
