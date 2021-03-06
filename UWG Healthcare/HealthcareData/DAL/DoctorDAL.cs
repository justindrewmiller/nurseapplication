﻿using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class DoctorDAL
    {
        /// <summary>
        /// gets a list of the Doctors from the SQL database
        /// </summary>
        /// <returns>list of Doctor objects</returns>
        public static List<Doctor> GetDoctors()
        {
            List<Doctor> docList = new List<Doctor>();

            string selectStatement =
                "SELECT p.PersonID, d.DoctorID, p.FName +' ' + p.LName AS  'FullName' " +
                "FROM Person p JOIN Doctors d " +
                "ON p.PersonID = d.PersonID";

            try
            {
                using (SqlConnection connection = HealthCareUWGDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               Doctor doctor = new Doctor();
                                doctor.PersonID = (int)reader["PersonID"];
                                doctor.DoctorID = (int)reader["DoctorID"];
                                doctor.FullName = reader["FullName"].ToString();
                                docList.Add(doctor);
                            }
                        }
                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return docList;
        }
    }
}
