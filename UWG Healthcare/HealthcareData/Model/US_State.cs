using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    public class US_State
    {

        public US_State()
        {
            Name = null;
            StateCode = null;
        }

        public US_State(string code, string name)
        {
            Name = name;
            StateCode = code;
        }

        public string Name { get; set; }

        public string StateCode { get; set; }

    }
}