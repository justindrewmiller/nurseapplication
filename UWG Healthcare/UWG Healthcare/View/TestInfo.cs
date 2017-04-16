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
    public partial class TestInfo : Form
    {

        public UserInfo info;
        private Patient patient;
        private Test test; 

        public TestInfo(UserInfo info, Patient patient, Test test)
        {
            InitializeComponent();
            this.info = info;
            lblUserName.Text = info.userID;
            this.patient = patient;
            this.test = test; 
        }

        private void Test_Load(object sender, EventArgs e)
        {
            txtPatientName.Text = patient.FullName;
            txtDate.Text = test.TestDate;
            txtTestName.Text = test.TestName; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
