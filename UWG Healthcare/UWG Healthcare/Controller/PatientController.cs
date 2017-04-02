using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    class PatientController
    {
    }

    // Adds the incident
    public int AddPerson(Person person)
    {
        return PatientDAL.AddPerson(person));
    }
}
