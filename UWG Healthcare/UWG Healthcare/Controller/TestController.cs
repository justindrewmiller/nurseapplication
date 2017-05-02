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

        //gets a list of the tests
        public List<Test> GetTests()
        {
            return TestDAL.GetTests();
        }

        //adds a new test to the database
        public void OrderTest(int apptID, DateTime testDate, int testCode)
        {
            TestDAL.OrderTest(apptID, testDate, testCode); 
        }

        //returns true if the test is successfully updated in the database
        public static bool UpdateTest(Test test)
        {
            return TestDAL.UpdateTest(test);
        }

    }
}
