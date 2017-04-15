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
            //try
            //{
            //    if (cboTests.ValueMember == "")
            //    {
            //        MessageBox.Show("No test to select.", "No test selected");
            //    }
            //    else
            //    {
            //        TestInfo testInfo = new TestInfo(this.info, this.patient);
            //        testInfo.MdiParent = this.MdiParent;
            //        testInfo.Show();
            //        this.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            if (!(lstTests.SelectedItems.Count > 0))
                {
                    MessageBox.Show("Please select a test!");
                } else
            {    
            try
            {
                string txtResult = lstTests.FocusedItem.SubItems[4].Text;
                if (txtResult != "")
                {
                    MessageBox.Show("Results have already been recorded for this test!");
                } 
                else
                {
                    Test test = new Test();
                    test.TestCode = Convert.ToInt32(lstTests.FocusedItem.SubItems[0].Text);
                    test.TestDate = lstTests.FocusedItem.SubItems[2].Text;
                    test.TestName = lstTests.FocusedItem.SubItems[1].Text;
                    test.ApptID = lstTests.FocusedItem.SubItems[3].Text;
                    TestInfo testInfo = new TestInfo(this.info, this.patient, test);
                    testInfo.MdiParent = this.MdiParent;
                    testInfo.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                cboAppointments.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadComboTests()
        {

            //load the test information 
            List<Test> testList;
            try
            {
                testList = InformationController.GetPatientTests(this.patientID);

                if (testList.Count > 0)
                {
                    Test test;
                    for (int i = 0; i < testList.Count; i++)
                    {
                        test = testList[i];
                        lstTests.Items.Add(test.TestCode.ToString());
                        lstTests.Items[i].SubItems.Add(test.TestName);
                        lstTests.Items[i].SubItems.Add(test.TestDate);
                        lstTests.Items[i].SubItems.Add(test.ApptID);
                        lstTests.Items[i].SubItems.Add(test.Result);
                    }
                }
                else
                {
                    MessageBox.Show("There are no test results");
                    this.BeginInvoke(new MethodInvoker(Close));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }

            lstTests.FullRowSelect = true;
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
                DateTime apptDate = Convert.ToDateTime(cboAppointments.Text);
                if (cboAppointments.ValueMember == "")
                {
                    MessageBox.Show("No applicable appointment.", "No appointment selected");
                } else if (apptDate.Date < DateTime.Now.Date ){
                    MessageBox.Show("You may not change a date in the past!");
                }
                else
                {
                    int apptID = int.Parse(cboAppointments.SelectedValue.ToString());
                    CurrentAppointment currentApt = new CurrentAppointment(this.info, apptID);
                    currentApt.MdiParent = this.MdiParent;
                    currentApt.Show();
                    this.Close();
                }
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
                DateTime apptDate = Convert.ToDateTime(cboAppointments.Text); 
                if (cboAppointments.ValueMember == "")
                {
                    MessageBox.Show("No applicable appointment.", "No appointment selected");
                }
                else if (apptDate.Date != DateTime.Now.Date)
                {
                    MessageBox.Show("This date is not today, you may not check in!");
                }
                else
                {
                    int apptID = int.Parse(cboAppointments.SelectedValue.ToString());
                    VisitInfo visitInfo = new VisitInfo(this.info, apptID);
                    visitInfo.MdiParent = this.MdiParent;
                    visitInfo.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCrtAppointment_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                MessageBox.Show("No patient to create appointment.", "No patient selected");
            }
            else
            {
                CreateAppointment createAppt = new CreateAppointment(this.info, this.patient);
                createAppt.MdiParent = this.MdiParent;
                createAppt.Show();
                this.Close();
            }

        }

    }
}
