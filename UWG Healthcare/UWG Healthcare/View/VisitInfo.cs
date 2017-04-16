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
        public Appointment appt;
        public int apptID; 

        public VisitInfo(UserInfo info, int apptID)
        {
            InitializeComponent();
            visitsController = new VisitsController();
            apptController = new AppointmentController(); 
            this.info = info;
            //this.visitID = visitID;
            lblUserName.Text = info.userID;
            this.apptID = apptID; 
            
        }

        private void VisitInfo_Load(object sender, EventArgs e)
        {
            this.appt = AppointmentController.GetAppointment(apptID);
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

            txtAppointment.Text = appt.apptDateTime; 
        }

        // Stores the information from textboxes and combo boxes into variables.
        private void PutVisitData(Visit visit)
        {
            visit.ApptID = txtAppointment.Text;
            visit.SysBP = txtSys.Text;
            visit.DiaBP = txtDia.Text;
            visit.BodyTemp = txtTemp.Text;
            visit.Pulse = txtPulse.Text;
            visit.Symptoms = txtSymptoms.Text;
            visit.NurseID = this.info.NurseID.ToString();
            visit.DiagnosesCode = txtDiagnosis.Text;
        }

        private bool isValidData()
        {
            if (Validator.IsPresent(txtAppointment) &&
                Validator.IsPresent(txtSys) &&
                Validator.IsPresent(txtDia) &&
                Validator.IsPresent(txtTemp) &&
                Validator.IsPresent(txtSymptoms) &&
                Validator.IsPresent(txtDiagnosis))
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
    }
}
