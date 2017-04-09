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
    public partial class ModifyPatient : Form
    {
        public UserInfo userID;
        public Patient currentPatient;
        private PatientController inController;
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
            userID = info;
            lblUserName.Text = userID.userID;
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
                                "deleted that incident.", "Database Error");
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
                this.GetIncident(personID);

            }

        }

        // Gets information based on the specific Person based on the personID.
        private void GetIncident(int personID)
        {
            try
            {
                person = inController.GetPatient(personID);
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
                    txtState.Enabled = true;
                    txtPhone.Enabled = true;
                    txtDOB.Enabled = true;
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
            txtFName.Text = person.FName;
            txtLName.Text = person.LName;
            txtSSN.Text = person.SSN;
            txtStreet.Text = person.Street;
            txtCity.Text = person.City;
            txtZip.Text = person.ZipCode;
            txtState.Text = person.State;
            txtPhone.Text = person.PhoneNum;
            txtDOB.Text = person.DOB;
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
            person.State = txtState.Text;
            person.PhoneNum = txtPhone.Text;
            person.DOB = txtDOB.Text;
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
            txtState.Text = "";
            txtPhone.Text = "";
            txtDOB.Text = "";
            MessageBox.Show("No Patient found with this ID. " +
            "Please try again.", "Patient Not Found");

        }

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
                txtState.Enabled = false;
                txtPhone.Enabled = false;
                txtDOB.Enabled = false;
            } else
            {
                btnSubmit.Enabled = true;
                btnCancel.Enabled = true;
                txtFName.Text = this.currentPatient.FName;
                txtLName.Text = this.currentPatient.LName;
                txtSSN.Text = this.currentPatient.SSN;
                txtStreet.Text = this.currentPatient.Street;
                txtCity.Text = this.currentPatient.City;
                txtZip.Text = this.currentPatient.ZipCode;
                txtState.Text = this.currentPatient.FName;
                txtPhone.Text = this.currentPatient.PhoneNum;
                txtDOB.Text = this.currentPatient.DOB;
            }

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
    }
}
