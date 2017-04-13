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
        private StatesController stateController;
        public Person person;
        public Patient patient;

        public RegisterPatient(UserInfo info)
        {
            InitializeComponent();
            inController = new PatientController();
            stateController = new StatesController();
            userID = info;
            lblUserName.Text = info.userID;
        }


        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
            cmbStatesList.SelectedIndex = -1;

            //Sets the Date time to be a maximum of Today.
            dtpDateTime.MaxDate = DateTime.Today;
        }

        // Loads the State information into comboboxes
        private void LoadComboBox()
        {
            try
            {

                List<US_State> statesList;
                statesList = stateController.GetStates();
                cmbStatesList.DataSource = statesList;
                cmbStatesList.DisplayMember = "Name";
                cmbStatesList.ValueMember = "StateCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
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
                Validator.IsPresent(cmbStatesList) &&
                Validator.IsPresent(txtZip) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsValidPhonNum(txtPhone) &&
                Validator.IsPresent(dtpDateTime) &&
                Validator.IsValidDOB(dtpDateTime))
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
            person.DOB = dtpDateTime.Text;
            person.FName = txtFName.Text;
            person.LName = txtLName.Text;
            person.Street = txtStreet.Text;
            person.City = txtCity.Text;
            person.State = cmbStatesList.Text;
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
                    //Passes PersonID from Person to Patient
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

