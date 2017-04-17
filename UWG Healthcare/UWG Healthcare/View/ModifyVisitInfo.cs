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
            try
            {
                visit = VisitsController.GetVisit(apptID);
                if (visit == null)
                {

                    this.visitDoesntExist();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void visitDoesntExist()
        {
            btnSubmit.Enabled = false;
            txtAppointment.Text = "";
            txtSys.Text = "";
            txtDia.Text = "";
            txtTemp.Text = "";
            txtPulse.Text = "";
            txtSymptoms.Text = "";
            cboDiagnoses.Text = "";
            MessageBox.Show("No Visit found with this ID. " +
            "Please try again.", "Visit Not Found");
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
            cboDiagnoses.Text = visit.DiagnosesCode.ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //{
            //    if (isValidData())
            //    {
            //        Visit newVisit = new Visit();
            //        newVisit.VisitID = visit.VisitID;
            //        this.PutVisitData(newVisit);
            //        try
            //        {
            //            if (!visitsController.UpdateVisit(visit, newVisit))
            //            {
            //                MessageBox.Show("Another user has updated or " +
            //                    "deleted that patient.", "Database Error");
            //                this.DialogResult = DialogResult.Retry;
            //            }
            //            else
            //            {
            //                person = newPerson;
            //                MessageBox.Show("Patient was modified.", "Successful Modification");
            //                PatientInfo newInfo = new PatientInfo(this.userID, person.PersonID.ToString());
            //                newInfo.MdiParent = this.MdiParent;
            //                newInfo.Show();
            //                this.Close();
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message, ex.GetType().ToString());
            //        }

            //    }
            //}
        }

        private void PutVisitData(Visit visit)
        {
            visit.SysBP = txtSys.Text;
            visit.DiaBP = txtDia.Text;
            visit.BodyTemp = txtTemp.Text;
            visit.Pulse = txtPulse.Text;
            visit.Symptoms = txtSymptoms.Text;
            visit.DiagnosesCode = (int)cboDiagnoses.SelectedValue;
            visit.NurseID = userID.userID;
        }
        private bool isValidData()
        {
            if (Validator.IsPresent(txtSys) &&
                Validator.IsPresent(txtDia) &&
                Validator.IsPresent(txtTemp) &&
                Validator.IsPresent(txtPulse) &&
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
    }
}
