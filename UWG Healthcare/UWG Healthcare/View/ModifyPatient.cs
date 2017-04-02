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
        private PatientController inController;
        Person person;
        public ModifyPatient(UserInfo info)
        {
            InitializeComponent();
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
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

                    MessageBox.Show("No Patient found with this ID. " +
                    "Please try again.", "Patient Not Found");
                }
                else
                {
                    this.DisplayPerson();
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
            cboState.Text = person.State;
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
            person.State = cboState.Text;
            person.PhoneNum = txtPhone.Text;
            person.DOB = txtDOB.Text;
        }
    }
}
