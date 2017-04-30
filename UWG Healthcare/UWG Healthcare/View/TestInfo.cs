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
    public partial class TestInfo : Form
    {

        public UserInfo info;
        private Patient patient;
        private Test test;
        PatientInfo _owner; 

        public TestInfo(UserInfo info, Patient patient, Test test, PatientInfo owner)
        {
            InitializeComponent();
            this.info = info;
            lblUserName.Text = info.userID;
            this.patient = patient;
            this.test = test;

            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestInfo_FormClosing);
        }

        private void TestInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            txtPatientName.Text = patient.FullName;
            txtDate.Text = test.TestDate;
            txtTestName.Text = test.TestName; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (txtResults.SelectedItem == null)
            {
                MessageBox.Show("Please select a test result!");
            }
            else
            {
                try
                {
                    this.test.Result = txtResults.SelectedItem.ToString();
                    if (TestController.UpdateTest(this.test))
                    {
                        MessageBox.Show("Test updated!");
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong with the update.");
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
