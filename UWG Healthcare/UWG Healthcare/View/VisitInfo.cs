using HealthcareData.DAL;
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


    public partial class VisitInfo : Form
    {
        public UserInfo info;
        //public string visitID;
        public Visit currentVisit;
        public Visit newVisit;
        private VisitsController visitsController;
        private AppointmentController apptController;
        private DiagnosesController diagController;
        public int apptID;
        public string patientID;
        public Appointment appt;
        public bool flag; 

        public VisitInfo(UserInfo info, int apptID, string patientID, bool flag)
        {
            InitializeComponent();
            visitsController = new VisitsController();
            apptController = new AppointmentController();
            diagController = new DiagnosesController(); 
            this.info = info;
            //this.visitID = visitID;
            lblUserName.Text = info.userID;
            this.apptID = apptID;
            this.patientID = patientID;
            this.flag = flag;                    
        }

        private void VisitInfo_Load(object sender, EventArgs e)
        {
            appt = AppointmentController.GetAppointment(this.apptID);
            txtAppointment.Text = appt.apptDateTime; 
            this.loadComboTests();
            this.loadDiagnoses();

            //hide the update button on whether or not they're checking in
            if (flag == false)
            {
                btnUpdate.Visible = false; 
            } else
            {
                btnUpdate.Visible = true;
            }

            //try
            //{
            //    currentVisit = VisitDAL.GetVisit(this.visitID);
            //    txtAppointment.Text = currentVisit.ApptID;
            //    txtSys.Text = currentVisit.SysBP;
            //    txtDia.Text = currentVisit.DiaBP;
            //    txtTemp.Text = currentVisit.BodyTemp;
            //    txtPulse.Text = currentVisit.Pulse;
            //    txtSymptoms.Text = currentVisit.Symptoms;
            //    txtDiagnosis.Text = VisitDAL.GetDiagnoses(currentVisit.DiagnosesCode);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

        }

        // Stores the information from textboxes and combo boxes into variables.
        private void PutVisitData(Visit visit)
        {
            visit.SysBP = txtSys.Text;
            visit.DiaBP = txtDia.Text;
            visit.BodyTemp = txtTemp.Text;
            visit.Pulse = txtPulse.Text;
            visit.Symptoms = txtSymptoms.Text;
            visit.NurseID = this.info.NurseID.ToString();
            visit.DiagnosesCode = cboDiagnoses.Text;
        }

        private bool isValidData()
        {
            if (Validator.IsPresent(txtAppointment) &&
                Validator.IsPresent(txtSys) &&
                Validator.IsPresent(txtDia) &&
                Validator.IsPresent(txtTemp) &&
                Validator.IsPresent(txtSymptoms) &&
                Validator.IsPresent(cboDiagnoses))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                if(txtSymptoms.TextLength < 20)
                {
                    MessageBox.Show("Symptoms description should be more than 20 characters");
                    return;
                }
                newVisit = new Visit();
                this.PutVisitData(newVisit);
                try
                {
                    //Inserts the Visit into the table and stores VisitID
                    newVisit.VisitID = visitsController.AddVisit(newVisit);
                    MessageBox.Show("The visit was successfully added.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderTest orderTests = new OrderTest(info);
            orderTests.MdiParent = this.MdiParent;
            orderTests.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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

        private void loadDiagnoses()
        {
            try
            {
                List<Diagnoses> diagnoses = diagController.GetDiagnosesList();
                cboDiagnoses.DataSource = diagnoses;
                cboDiagnoses.DisplayMember = "DiagnosesName";
                cboDiagnoses.ValueMember = "DiagnosesCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
