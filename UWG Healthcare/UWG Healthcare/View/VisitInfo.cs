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

namespace UWG_Healthcare.View
{


    public partial class VisitInfo : Form
    {
        public UserInfo info;
        public string visitID;
        public Visit currentVisit;

        public VisitInfo(UserInfo info, string visitID)
        {
            InitializeComponent();
            this.info = info;
            this.visitID = visitID;
            lblUserName.Text = info.userID;
        }

        private void VisitInfo_Load(object sender, EventArgs e)
        {
            try
            {
                currentVisit = VisitDAL.GetVisit(this.visitID);
                txtAppointment.Text = currentVisit.ApptID;
                txtSys.Text = currentVisit.SysBP;
                txtDia.Text = currentVisit.DiaBP;
                txtTemp.Text = currentVisit.BodyTemp;
                txtPulse.Text = currentVisit.Pulse;
                txtSymptoms.Text = currentVisit.Symptoms;
                txtDiagnosis.Text = VisitDAL.GetDiagnoses(currentVisit.DiagnosesCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
