using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareData.DAL
{
    public class PatientDAL
    {

        // Gets the the doctor objects
        public static List<Patient> GetPatients()
        {
            List<Patient> patientList = new List<Patient>();

            string selectStatement =
                "SELECT p.PersonID, pt.PatientID, p.FName +' ' + p.LName AS  'FullName' " +
                "FROM Person p JOIN Patients pt " +
                "ON p.PersonID = pt.PersonID";

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
                                Patient patient = new Patient();
                                patient.PersonID = (int)reader["PersonID"];
                                patient.PatientID = (int)reader["PatientID"];
                                patient.FullName = reader["FullName"].ToString();
                                patientList.Add(patient);
                            }
                        }
                    }
                }


            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            return patientList;
        }

    public static int AddPatient(Patient patient)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string insertStatement =
                "INSERT Patients " +
                  "(PersonID) " +
                "VALUES (@PersonID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PersonID", patient.PersonID);
            try
            {
                connection.Open();

                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Patients') FROM Patients";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int patientID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return patientID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        // Inserts into the Person table
        public static int AddPerson(Person person)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string insertStatement =
                "INSERT Person " +
                  "(DOB, FName, LName, Street, City, State, ZipCode, PhoneNum, SSN) " +
                "VALUES (@DOB, @FName, @LName, @Street, @City, @State, @ZipCode, @PhoneNum, @SSN)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@DOB", person.DOB);
            insertCommand.Parameters.AddWithValue("@FName", person.FName);
            insertCommand.Parameters.AddWithValue("@LName", person.LName);
            insertCommand.Parameters.AddWithValue("@Street", person.Street);
            insertCommand.Parameters.AddWithValue("@City", person.City);
            insertCommand.Parameters.AddWithValue("@State", person.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", person.ZipCode);
            insertCommand.Parameters.AddWithValue("@PhoneNum", person.PhoneNum);
            insertCommand.Parameters.AddWithValue("@SSN", person.SSN);
            try
            {
                connection.Open();

                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Person') FROM Person";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int personID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return personID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        // Gets the Gets the Patient's information via the Person ID
        public static Person GetPatient(int personID)
        {
            Person person = new Person();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
               "Select PersonID, DOB, FName, LName, Street, City, State, ZipCode, PhoneNum, SSN " +
                "FROM Person " +
                "WHERE PersonID = @PersonID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PersonID", personID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    person.PersonID = (int)reader["PersonID"];
                    //Stores formatted date into DOB
                    person.DOB = String.Format("{0:yyyy-MM-dd}", reader["DOB"]);
                    person.FName = reader["FName"].ToString();
                    person.LName = reader["LName"].ToString();
                    person.Street = reader["Street"].ToString();
                    person.City = reader["City"].ToString();
                    person.State = reader["State"].ToString();
                    person.ZipCode = reader["ZipCode"].ToString();
                    person.PhoneNum = reader["PhoneNum"].ToString();
                    person.SSN = reader["SSN"].ToString();
                }
                else
                {
                    person = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return person;
        }

        // Updates the Patient's information
        public static bool UpdatePatient(Person oldPerson, Person newPerson)
        {
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string updateStatement =
                "UPDATE Person SET " +
                  "DOB = @NewDOB, " +
                  "FName = @NewFName, " +
                  "LName = @NewLName, " +
                  "Street = @NewStreet, " +
                  "City = @NewCity, " +
                  "State = @NewState, " +
                  "ZipCode = @NewZipCode, " +
                  "PhoneNum = @NewPhoneNum, " +
                  "SSN = @NewSSN " +
                "WHERE PersonID = @OldPersonID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewDOB", newPerson.DOB);
            updateCommand.Parameters.AddWithValue("@NewFName", newPerson.FName);
            updateCommand.Parameters.AddWithValue("@NewLName", newPerson.LName);
            updateCommand.Parameters.AddWithValue("@NewStreet", newPerson.Street);
            updateCommand.Parameters.AddWithValue("@NewCity", newPerson.City);
            updateCommand.Parameters.AddWithValue("@NewState", newPerson.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", newPerson.ZipCode);
            updateCommand.Parameters.AddWithValue("@NewPhoneNum", newPerson.PhoneNum);
            updateCommand.Parameters.AddWithValue("@NewSSN", newPerson.SSN);

            updateCommand.Parameters.AddWithValue("@OldPersonID", oldPerson.PersonID);
            
            updateCommand.Parameters.AddWithValue("@OldDOB", oldPerson.DOB);
            updateCommand.Parameters.AddWithValue("@OldFName", oldPerson.FName);
            updateCommand.Parameters.AddWithValue("@OldLName", oldPerson.LName);
            updateCommand.Parameters.AddWithValue("@OldStreet", oldPerson.Street);
            updateCommand.Parameters.AddWithValue("@OldCity", oldPerson.City);
            updateCommand.Parameters.AddWithValue("@OldState", oldPerson.State);
            updateCommand.Parameters.AddWithValue("@OldZipCode", oldPerson.ZipCode);
            updateCommand.Parameters.AddWithValue("@OldPhoneNum", oldPerson.PhoneNum);
            updateCommand.Parameters.AddWithValue("@OldSSN", oldPerson.SSN);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

