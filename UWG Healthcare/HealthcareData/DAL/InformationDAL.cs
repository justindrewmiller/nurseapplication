﻿using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareData.DAL
{
    public class InformationDAL
    {

        public static Patient CurrentPatientInfo(string patientID)
        {
            Patient patient = new Patient();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "SELECT p.PersonID, pt.PatientID, p.FName, p.LName, p.FName +' ' + p.LName AS  'FullName', p.DOB, p.Street, p.City, p.State, p.ZipCode, p.PhoneNum, p.SSN " +
                "FROM Person p JOIN Patients pt " +
                "ON p.PersonID = pt.PersonID " +
                "WHERE pt.PatientID = @PatientID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    patient.PersonID = (int)reader["PersonID"];
                    patient.PatientID = (int)reader["PatientID"];
                    patient.FullName = reader["FullName"].ToString();
                    patient.FName = reader["FName"].ToString();
                    patient.LName = reader["LName"].ToString();
                    patient.DOB = reader["DOB"].ToString();
                    patient.Street = reader["Street"].ToString();
                    patient.City = reader["City"].ToString();
                    patient.State = reader["State"].ToString();
                    patient.ZipCode = reader["ZipCode"].ToString();
                    patient.PhoneNum = reader["PhoneNum"].ToString();
                    patient.SSN = reader["SSN"].ToString();
                }
                else
                {
                    patient = null;
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("it broke at sql and variable is " + patientID + ex.ToString());
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return patient;
        }

        public static List<Appointment> GetPatientAppointments(string patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Appointment appointment = new Appointment();
                    appointment.ApptID = (int)reader["ApptID"];
                    appointment.PatientID = (int)reader["PatientID"];
                    appointment.DoctorID = (int)reader["DoctorID"];
                    appointment.apptDateTime = reader["apptDateTime"].ToString();
                    appointment.Reason = reader["Reason"].ToString();
                    appointmentList.Add(appointment);
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return appointmentList;
        }

        public static List<Test> GetPatientTests(string patientID)
        {
            List<Test> testList = new List<Test>();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Test test = new Test();
                    test.TestCode = reader["TestCode"].ToString();
                    test.TestName = reader["TestName"].ToString();
                    test.TestDate = reader["TestDate"].ToString();
                    test.ApptID = reader["ApptID"].ToString();
                    test.Result = reader["Result"].ToString();
                    testList.Add(test);
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return testList;
        }

        public static List<Visit> GetPatientVisits(string patientID)
        {
            List<Visit> visitList = new List<Visit>();
            SqlConnection connection = HealthCareUWGDBConnection.GetConnection();
            string selectStatement =
                "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Visit visit = new Visit();
                    visit.VisitID = reader["VisitID"].ToString();
                    visit.ApptID = reader["ApptID"].ToString();
                    visit.SysBP = reader["SysBP"].ToString();
                    visit.DiaBP = reader["DiaBP"].ToString();
                    visit.BodyTemp = reader["BodyTemp"].ToString();
                    visit.Pulse = reader["Pulse"].ToString();
                    visit.Symptoms = reader["Symptoms"].ToString();
                    visit.NurseID = reader["NurseID"].ToString();
                    visit.DiagnosesCode = reader["DiagnosesCode"].ToString();
                    visitList.Add(visit);
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return visitList;
        }
    }
}