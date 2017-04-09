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

namespace UWG_Healthcare.View
{
    public partial class PatientInfo : Form
    {

        public UserInfo info;
        private Patient patient;
        private string patientID;

        public PatientInfo(UserInfo info, string patientID)
        {
            InitializeComponent();
            this.info = info;
            lblUserName.Text = info.userID;
            this.patientID = patientID;
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            try
            {
                this.patient = InformationController.CurrentPatientInfo(this.patientID);
                txtFName.Text = this.patient.FName;
                txtLName.Text = this.patient.LName;
                txtSSN.Text = this.patient.SSN;
                txtStreet.Text = this.patient.Street;
                txtCity.Text = this.patient.City;
                txtZip.Text = this.patient.ZipCode;
                txtState.Text = this.patient.State;
                txtPhone.Text = this.patient.PhoneNum;
                this.loadComboAppointments();
                this.loadComboTests();
                this.loadComboVisits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Invalid patient id. " +
                   "Please try searching for the patient again.", "Patient Not Found");
            }
        }

        private void loadComboAppointments()
        {
            try
            {
                List<Appointment> appointments = InformationController.GetPatientAppointments(this.patientID);
                cboAppointments.DataSource = appointments;
                cboAppointments.DisplayMember = "apptDateTime";
                cboAppointments.ValueMember = "ApptID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadComboTests()
        {
            try
            {
                List<Test> tests = InformationController.GetPatientTests(this.patientID);
                cboTests.DataSource = tests;
                cboTests.DisplayMember = "TestName";
                cboTests.ValueMember = "TestName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadComboVisits()
        {
            try
            {
                List<Visit> visits = InformationController.GetPatientVisits(this.patientID);
                cboVisits.DataSource = visits;
                cboVisits.DisplayMember = "Symptoms";
                cboVisits.ValueMember = "VisitID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                MessageBox.Show("No patient to modify.", "No patient selected");
            }
            else
            {
                ModifyPatient modifyInfo = new ModifyPatient(this.info, this.patient);
                modifyInfo.MdiParent = this.MdiParent;
                modifyInfo.Show();
                this.Close();
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
