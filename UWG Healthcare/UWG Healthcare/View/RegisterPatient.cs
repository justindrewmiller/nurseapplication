using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        // Stores the information from textboxes and combo boxes into variables.
        private void PutPersonData(Person person)
        {
            person.DOB = txtDOB.Text;
            person.FName = txtFName.Text;
            person.LName = txtLName.Text;
            person.Street = txtStreet.Text;
            person.City = txtCity.Text;
            person.State = cboState.Text;
            person.ZipCode = txtZip.Text;
            person.PhoneNum = txtPhone.Text;
            person.SSN = txtSSN.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            person = new Person();
            this.PutPersonData(person);
            try
            {
                person.PersonID = inController.AddPerson(person);
                MessageBox.Show("The person was successfully added.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
    }

