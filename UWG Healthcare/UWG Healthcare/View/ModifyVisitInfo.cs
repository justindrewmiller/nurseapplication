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
    public partial class ModifyVisitInfo : Form
    {
        public UserInfo userID;
        public VisitsController visitsController;
        public AppointmentController apptController;
        public DiagnosesController diagController;
        public string patientID;
        public int apptID;
        public string apptText;
        public Visit visit;

        public ModifyVisitInfo(UserInfo info, int apptID, string AppointmentText, string patientID, bool flag)
        {
            this.apptID = apptID;
            this.apptText = AppointmentText;
            this.patientID = patientID;
            InitializeComponent();
            visitsController = new VisitsController();
            apptController = new AppointmentController();
            diagController = new DiagnosesController();
            userID = info;
            lblUserName.Text = userID.userID;
        }

        private void ModifyVisitInfo_Load(object sender, EventArgs e)
        {
            this.loadComboTests();
            this.loadDiagnoses();
            this.GetVisit(this.apptID);
        }

        private void GetVisit(int apptID)
        {

            Appointment appt = AppointmentController.GetAppointment(this.apptID);
            DateTime apptDate = Convert.ToDateTime(appt.apptDateTime);
            try
            {
                visit = VisitsController.GetVisit(apptID);
                if (visit == null)
                {
                    this.visitDoesntExist();
                }
                else
                {
                    if(appt.isCheckedIn == "False" || apptDate.Date > DateTime.Now.Date)
                    {
                        this.DisplayVisit();
                        btnSubmit.Enabled = false;
                        txtSys.Enabled = false;
                        txtDia.Enabled = false;
                        txtTemp.Enabled = false;
                        txtPulse.Enabled = false;
                        txtSymptoms.Enabled = false;
                        cboDiagnoses.Enabled = false;
                    }
                    else
                    {
                    this.DisplayVisit();
                    btnSubmit.Enabled = true;
                    txtSys.Enabled = true;
                    txtDia.Enabled = true;
                    txtTemp.Enabled = true;
                    txtPulse.Enabled = true;
                    txtSymptoms.Enabled = true;
                    cboDiagnoses.Enabled = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void visitDoesntExist()
        {
            btnSubmit.Enabled = false;
            txtAppointment.Text = this.apptText;
            txtSys.Text = "";
            txtDia.Text = "";
            txtTemp.Text = "";
            txtPulse.Text = "";
            txtSymptoms.Text = "";
            cboDiagnoses.Text = "";
            btnSubmit.Enabled = false;
            txtSys.Enabled = false;
            txtDia.Enabled = false;
            txtTemp.Enabled = false;
            txtPulse.Enabled = false;
            txtSymptoms.Enabled = false;
            cboDiagnoses.Enabled = false;
            MessageBox.Show("The patient has not or did not visit on this day. \n" +
            "There is no information to be shown.", "Visit Not Found");
        }

        // Displays the visit information.
        private void DisplayVisit()
        {
            txtAppointment.Text = this.apptText;
            txtSys.Text = visit.SysBP;
            txtDia.Text = visit.DiaBP;
            txtTemp.Text = visit.BodyTemp;
            txtPulse.Text = visit.Pulse;
            txtSymptoms.Text = visit.Symptoms;
            Diagnoses my = (Diagnoses)cboDiagnoses.Items[visit.DiagnosesCode-1];
            cboDiagnoses.Text = my.DiagnosesName;

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

        public void loadDiagnoses()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                if (isValidData())
                {
                    Visit newVisit = new Visit();
                    newVisit.VisitID = visit.VisitID;
                    this.PutVisitData(newVisit);
                    try
                    {
                        if (!VisitsController.UpdateVisit(visit, newVisit))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that patient.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            visit = newVisit;
                            MessageBox.Show("Visit was successfully modified.", "Successful Modification");
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

        private void PutVisitData(Visit visit)
        {
            visit.SysBP = txtSys.Text;
            visit.DiaBP = txtDia.Text;
            visit.BodyTemp = txtTemp.Text;
            visit.Pulse = txtPulse.Text;
            visit.Symptoms = txtSymptoms.Text;
            visit.DiagnosesCode = (int)cboDiagnoses.SelectedValue;
            visit.NurseID = userID.NurseID.ToString();
        }
        private bool isValidData()
        {
            if (Validator.IsPresent(txtSys) &&
                Validator.IsNumbersOnly(txtSys) &&
                Validator.IsPresent(txtDia) &&
                Validator.IsNumbersOnly(txtDia) &&
                Validator.IsPresent(txtTemp) &&
                Validator.IsDecimalNumbersOnly(txtTemp) &&
                Validator.IsPresent(txtPulse) &&
                Validator.IsNumbersOnly(txtPulse) &&
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


        private void txtTemp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtTemp.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
    }
}
