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
    public partial class SearchPatient : Form
    {

        public List<Patient> patients;

        public SearchPatient(UserInfo info)
        {
            InitializeComponent();
            lblUserName.Text = info.userID;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtDOB != null && Validator.IsPresent(txtLName))
            {
                this.GetPatientByDOBAndLName(dtDOB.Value, txtLName.Text);
            } else if (Validator.IsPresent(txtLName) && Validator.IsPresent(txtFName))
            {
                this.GetPatientByFullName(txtFName.Text, txtLName.Text);
            } else if (dtDOB != null)
            {
                this.GetPatientByDOB(dtDOB.Value);
            } else
            {
                MessageBox.Show("Please input a dob and last name, a DOB, or a full name", "Invalid search parameters");
            }
        }

        private void GetPatientByDOB(DateTime DOB)
        {
            try
            {
                patients = SearchController.SearchPatientsByDOB(DOB.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("No patient found with this DOB. " +
                   "Please try again.", "Patient Not Found");
            }
        }

        private void GetPatientByFullName(string FName, string LName)
        {
            try
            {
                patients = SearchController.SearchPatientsByFullName(FName, LName);
            }
            catch (Exception)
            {
                MessageBox.Show("No patient found with this first and last name. " +
                   "Please try again.", "Patient Not Found");
            }
        }

        private void GetPatientByDOBAndLName(DateTime DOB, string LName)
        {
            try
            {
                patients = SearchController.SearchPatientsByLastNameAndDOB(DOB.ToString(), LName);
            }
            catch (Exception)
            {
                MessageBox.Show("No patient found with this DOB and last name. " +
                   "Please try again.", "Patient Not Found");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
