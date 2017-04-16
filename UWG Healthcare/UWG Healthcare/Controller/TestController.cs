using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWG_Healthcare.Controller
{
    public class TestController
    {

        public List<Test> GetTests()
        {
            return TestDAL.GetTests();
        }

        public void OrderTest(int apptID, DateTime testDate, int testCode)
        {
            TestDAL.OrderTest(apptID, testDate, testCode); 
        }

    }
}
