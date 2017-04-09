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
            if (txtFName.Text != "" && txtLName.Text != "")
            {
                this.GetPatientByFullName(txtFName.Text, txtLName.Text);
            } else if (txtLName.Text != "" && dtDOB.Value != DateTime.Today)
            {
                this.GetPatientByDOBAndLName(dtDOB.Value, txtLName.Text);
            } else if (dtDOB.Value != DateTime.Today)
            {
                this.GetPatientByDOB(dtDOB.Value);
            } else
            {
                MessageBox.Show("Please choose a dob, dob and last name, or first and last name. " +
                   "Please try again.", "Improper parameters");
            }


        }

        private void GetPatientByDOB(DateTime DOB)
        {
            try
            {
                patients = SearchController.SearchPatientsByDOB(DOB.ToString());
                if (patients == null) {
                    MessageBox.Show("No patient found with this DOB. " +
                       "Please try again.", "Patient Not Found");
                } else
                this.DisplayPatients();
            }
            catch (Exception)
            {
                MessageBox.Show("No patient found with this DOB. " +
                   "Please try again.", "Patient Not Found");
            }
        }

        private void DisplayPatients()
        {
            cboPatients.DataSource = patients;
            cboPatients.DisplayMember = "FullName";
            cboPatients.ValueMember = "PatientID";
            cboPatients.SelectedIndex = 0;
        }

        private void GetPatientByFullName(string FName, string LName)
        {
            try
            {
                patients = SearchController.SearchPatientsByFullName(FName, LName);
                if (patients == null)
                {
                    MessageBox.Show("No patient found with this name. " +
                       "Please try again.", "Patient Not Found");
                }
                else
                    this.DisplayPatients();
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
                if (patients == null)
                {
                    MessageBox.Show("No patient found with this DOB and last name. " +
                       "Please try again.", "Patient Not Found");
                }
                else
                    this.DisplayPatients();
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
