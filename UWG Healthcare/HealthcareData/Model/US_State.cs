using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.Model
{
    // US_State class which gets data to populate the state combobox
    public class US_State
    {
        // The Name and StateCode variables are set to null
        public US_State()
        {
            Name = null;
            StateCode = null;
        }

        // The Name and StateCode uses the parameter values to store into the variables.
        public US_State(string code, string name)
        {
            Name = name;
            StateCode = code;
        }

        // Gets and sets the name of the state
        public string Name { get; set; }

        // Gets and sets the statecode of the state
        public string StateCode { get; set; }

    }
}