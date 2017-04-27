using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    // HealthCareUWGDBConnection class which handles the application's connection.
    class HealthCareUWGDBConnection
    {
        // GetConnection sets the connectionString throughout the program.
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=CS6232-g2;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
