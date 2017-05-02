using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    class StatesController
    {

        //returns a list of the states
        public List<US_State> GetStates()
        {
            return StateDAL.GetStates();
        }
    }
}
