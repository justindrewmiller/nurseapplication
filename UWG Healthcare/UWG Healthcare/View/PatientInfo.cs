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
        private AppointmentController apptController;


        public PatientInfo(UserInfo info, string patientID)
        {
            InitializeComponent();
            this.info = info;
            lblUserName.Text = info.userID;
            this.patientID = patientID;
            this.apptController = new AppointmentController();
        }

        //this method adds results for a test
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
                    TestInfo testInfo = new TestInfo(this.info, this.patient, test, this);
                    testInfo.MdiParent = this.MdiParent;
                    testInfo.Show();
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
            List<Appointment> appointments;
            try
            {
                appointments = InformationController.GetPatientAppointments(this.patientID);
                if (appointments.Count > 0)
                {
                    cboAppointments.DataSource = appointments;
                    cboAppointments.DisplayMember = "apptDateTime";
                    cboAppointments.ValueMember = "ApptID";
                    cboAppointments.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.BeginInvoke(new MethodInvoker(Close));
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
            
            List<Visit> visitList;
            try
            {
                visitList = InformationController.GetPatientVisits(this.patientID);
                if (visitList.Count > 0)
                {
                    Visit visit;
                    for (int i = 0; i < visitList.Count; i++)
                    {
                        visit = visitList[i];
                        lstVisits.Items.Add(visit.VisitID.ToString());
                        lstVisits.Items[i].SubItems.Add(visit.ApptDateTime.ToString());
                        lstVisits.Items[i].SubItems.Add(visit.Symptoms);
                        lstVisits.Items[i].SubItems.Add(visit.DiagnosesName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }

            lstVisits.FullRowSelect = true;
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
                modifyInfo.FormClosing += new FormClosingEventHandler(this.ModifyPatient_FormClosing);
                modifyInfo.Show();

            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            SearchPatient sp = new SearchPatient(info);
            sp.MdiParent = this.MdiParent;
            sp.Show();
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
                    currentApt.FormClosing += new FormClosingEventHandler(this.UpdateAppointment_FormClosing);
                    currentApt.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            Appointment appt = AppointmentController.GetAppointment(Convert.ToInt32(cboAppointments.SelectedValue));

            try
            {
                DateTime apptDate = Convert.ToDateTime(cboAppointments.Text); 
                if (cboAppointments.ValueMember == "")
                {
                    MessageBox.Show("No applicable appointment.", "No appointment selected");
                }
                else if (appt.isCheckedIn == "False" && apptDate.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("The patient did not visit, they missed the appointment!");
                }
                else if (apptDate.Date != DateTime.Now.Date)
                {
                    MessageBox.Show("This date is not today, you may not check in!");
                    //String appointmentText = cboAppointments.Text;
                    //int apptID = int.Parse(cboAppointments.SelectedValue.ToString());
                    //ModifyVisitInfo visitInfo = new ModifyVisitInfo(this.info, apptID, appointmentText, this.patientID, false);
                    //visitInfo.MdiParent = this.MdiParent;
                    //visitInfo.FormClosing += new FormClosingEventHandler(this.Visits_FormClosing);
                    //visitInfo.Show();
                }
                else if(appt.isCheckedIn == "True" || appt.isCheckedIn == "1")
                {
                    MessageBox.Show("You have already checked in today!");
                    //String appointmentText = cboAppointments.Text;
                    //int apptID = int.Parse(cboAppointments.SelectedValue.ToString());
                    //ModifyVisitInfo visitInfo = new ModifyVisitInfo(this.info, apptID, this.patientID, false);
                    //visitInfo.MdiParent = this.MdiParent;
                    //visitInfo.FormClosing += new FormClosingEventHandler(this.Visits_FormClosing);
                    //visitInfo.Show();
                }
                else
                {
                    int apptID = int.Parse(cboAppointments.SelectedValue.ToString());
                    VisitInfo visitInfo = new VisitInfo(this.info, apptID, this.patientID, false, this);
                    visitInfo.MdiParent = this.MdiParent;
                    visitInfo.Show();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while trying to check in, please try again!");
            }
        }

        private void Visits_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Invalid patient id. " +
                   "Please try searching for the patient again.", "Patient Not Found");
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
                createAppt.FormClosing += new FormClosingEventHandler(this.CreateAppointment_FormClosing);
                createAppt.Show();
            }

        }

        private void btnUpdateDiagnosis_Click(object sender, EventArgs e)
        {
            //Appointment appt = AppointmentController.GetAppointment(Convert.ToInt32(cboAppointments.SelectedValue));
             
            try
            {
                if (!(lstVisits.SelectedItems.Count > 0))
                {
                    MessageBox.Show("Please select a visit to update!");
                }
                else
                {
                    string apptDateTime = lstVisits.FocusedItem.SubItems[1].Text; 
                    int visitID = int.Parse(lstVisits.FocusedItem.SubItems[0].Text);
                    ModifyVisitInfo visitInfo = new ModifyVisitInfo(this.info, visitID, this.patientID, false, apptDateTime);
                    visitInfo.MdiParent = this.MdiParent;
                    visitInfo.FormClosing += new FormClosingEventHandler(this.Visits_FormClosing);
                    visitInfo.Show();
                }

                //DateTime apptDate = Convert.ToDateTime(cboAppointments.Text);
                //if (cboAppointments.ValueMember == "")
                //{
                //    MessageBox.Show("No applicable appointment.", "No appointment selected");
                //}
                //else if (appt.isCheckedIn == "False" && apptDate.Date < DateTime.Now.Date)
                //{
                //    MessageBox.Show("The patient did not visit, they missed the appointment!");
                //}
                //else
                //{
                //    String appointmentText = cboAppointments.Text;
                //    int apptID = int.Parse(cboAppointments.SelectedValue.ToString());
                //    ModifyVisitInfo visitInfo = new ModifyVisitInfo(this.info, apptID, appointmentText, this.patientID, false);
                //    visitInfo.MdiParent = this.MdiParent;
                //    visitInfo.FormClosing += new FormClosingEventHandler(this.Visits_FormClosing);
                //    visitInfo.Show();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void ModifyPatient_FormClosing(object sender, FormClosingEventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Invalid patient id. " +
                   "Please try searching for the patient again.", "Patient Not Found");
            }

        }

        private void CreateAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.loadComboAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Invalid patient id. " +
                   "Please try searching for the patient again.", "Patient Not Found");
            }

        }

        private void UpdateAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.loadComboAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Invalid patient id. " +
                   "Please try searching for the patient again.", "Patient Not Found");
            }

        }

        public void PerformRefresh()
        {
            lstTests.Items.Clear();
            lstVisits.Items.Clear();
            this.loadComboTests();
            this.loadComboVisits();
        }

        private void PatientInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            SearchPatient sp = new SearchPatient(info);
            sp.MdiParent = this.MdiParent;
            sp.Show();
        }
    }
}
