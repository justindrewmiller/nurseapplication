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
using UWG_Healthcare.View;

namespace UWG_Healthcare
{
    public partial class ModifyPatient : Form
    {
        public UserInfo userID;
        public Patient currentPatient;
        private PatientController inController;
        private StatesController stateController;
        Person person;
        public ModifyPatient(UserInfo info)
        {
            InitializeComponent();
            inController = new PatientController();
            userID = info;
            lblUserName.Text = userID.userID;
        }

        public ModifyPatient(UserInfo info, Patient currentPatient)
        {
            InitializeComponent();
            this.currentPatient = currentPatient;
            inController = new PatientController();
            stateController = new StatesController();
            userID = info;
            lblUserName.Text = userID.userID;
            this.LoadComboBox();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                if (isValidData())
                {
                    Person newPerson = new Person();
                    newPerson.PersonID = person.PersonID;
                    this.PutPersonData(newPerson);
                    try
                    {
                        if (!inController.UpdatePatient(person, newPerson))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that patient.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            person = newPerson;
                            MessageBox.Show("Patient was modified.", "Successful Modification");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtPersonID) &&
                Validator.IsInt32(txtPersonID))
            {

                int personID = Convert.ToInt32(txtPersonID.Text);
                this.GetPatient(personID);

            }

        }

        // Gets information based on the specific Person based on the personID.
        private void GetPatient(int personID)
        {
            try
            {
                person = PatientController.GetPatient(personID);
                if (person == null)
                {

                    this.personDoesntExist();
                }
                else
                {
                    this.DisplayPerson();
                    btnSubmit.Enabled = true;
                    btnCancel.Enabled = true;
                    txtFName.Enabled = true;
                    txtLName.Enabled = true;
                    txtSSN.Enabled = true;
                    txtStreet.Enabled = true;
                    txtCity.Enabled = true;
                    txtZip.Enabled = true;
                    cmbStatesList.Enabled = true;
                    txtPhone.Enabled = true;
                    dtpDateTime.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Displays the person information.
        private void DisplayPerson()
        {
            txtPersonID.Text = person.PersonID.ToString();
            txtPersonID.Enabled = false; 
            txtFName.Text = person.FName;
            txtLName.Text = person.LName;
            txtSSN.Text = person.SSN;
            txtStreet.Text = person.Street;
            txtCity.Text = person.City;
            txtZip.Text = person.ZipCode;
            cmbStatesList.Text = person.State;
            txtPhone.Text = person.PhoneNum;
            dtpDateTime.Text = person.DOB;
        }
        // Sets person object values to values based on person id
        private void PutPersonData(Person person)
        {
            person.FName = txtFName.Text;
            person.LName = txtLName.Text;
            person.SSN = txtSSN.Text;
            person.Street = txtStreet.Text;
            person.City = txtCity.Text;
            person.ZipCode = txtZip.Text;
            person.State = cmbStatesList.Text;
            person.PhoneNum = txtPhone.Text;
            person.DOB = dtpDateTime.Text;
        }

        private void personDoesntExist()
        {
            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            txtFName.Text = "";
            txtLName.Text = "";
            txtSSN.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            cmbStatesList.Text = "";
            txtPhone.Text = "";
            dtpDateTime.Text = "";
            MessageBox.Show("No Patient found with this ID. " +
            "Please try again.", "Patient Not Found");

        }

        // Inserts the Patient information if not null
        private void ModifyPatient_Load(object sender, EventArgs e)
        {
            if (this.currentPatient == null)
            {
                btnSubmit.Enabled = false;
                btnCancel.Enabled = false;
                txtFName.Enabled = false;
                txtLName.Enabled = false;
                txtSSN.Enabled = false;
                txtStreet.Enabled = false;
                txtCity.Enabled = false;
                txtZip.Enabled = false;
                cmbStatesList.Enabled = false;
                txtPhone.Enabled = false;
                dtpDateTime.Enabled = false;
            } else
            {
                this.GetPatient(this.currentPatient.PersonID);
            }
            this.LoadComboBox();
            //Sets the Date time to be a maximum of Today.
            dtpDateTime.MaxDate = DateTime.Today;

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
    }
}
