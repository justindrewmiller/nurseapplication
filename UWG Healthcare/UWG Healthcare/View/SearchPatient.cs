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
    public partial class SearchPatient : Form
    {

        public List<Patient> patients;
        public UserInfo info;

        public SearchPatient(UserInfo info)
        {
            InitializeComponent();
            this.info = info;
            patients = new List<Patient>();
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
                if (patients.Count == 0) {
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
            try
            {
                cboPatients.DataSource = patients;
                cboPatients.DisplayMember = "FullName";
                cboPatients.ValueMember = "PatientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void GetPatientByFullName(string FName, string LName)
        {
            try
            {
                patients = SearchController.SearchPatientsByFullName(FName, LName);
                if (patients.Count == 0)
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
                if (patients.Count == 0)
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

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (cboPatients.SelectedValue == null)
            {
                MessageBox.Show("Please search for a patient.", "No value searched");
            }
            else
            {
                PatientInfo newInfo = new PatientInfo(this.info, cboPatients.SelectedValue.ToString());
                newInfo.MdiParent = this.MdiParent;
                newInfo.Show();
                this.Close();
            }

        }
    }
}
