using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UWG_Healthcare.Controller;

namespace UWG_Healthcare
{
    public partial class RegisterPatient : Form
    {
        public UserInfo userID;
        private PatientController inController;
        public Person person;
        public Patient patient;

        public RegisterPatient(UserInfo info)
        {
            InitializeComponent();
            inController = new PatientController();
            userID = info;
            lblUserName.Text = info.userID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidData()
        {
            if (Validator.IsPresent(txtFName) &&
                Validator.IsPresent(txtLName) &&
                Validator.IsPresent(txtSSN) &&
                Validator.IsValidSSN(txtSSN) &&
                Validator.IsPresent(txtStreet) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(txtState) &&
                Validator.IsPresent(txtZip) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsValidPhonNum(txtPhone) &&
                Validator.IsPresent(txtDOB) &&
                Validator.IsValidDOB(txtDOB))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        // Stores the information from textboxes and combo boxes into variables.
        private void PutPersonData(Person person)
        {
            person.DOB = txtDOB.Text;
            person.FName = txtFName.Text;
            person.LName = txtLName.Text;
            person.Street = txtStreet.Text;
            person.City = txtCity.Text;
            person.State = txtState.Text;
            person.ZipCode = txtZip.Text;
            person.PhoneNum = txtPhone.Text;
            person.SSN = txtSSN.Text;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                person = new Person();
                patient = new Patient();
                this.PutPersonData(person);
                try
                {
                    //Inserts the Person into the table and stores PersonID
                    person.PersonID = inController.AddPerson(person);
                    //Passes PersonID from Person to Patien
                    patient.PersonID = person.PersonID;
                    //Inserts Patient by using PersonID
                    inController.AddPatient(patient);
                    MessageBox.Show("The patient was successfully added.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

        }
    }
}

