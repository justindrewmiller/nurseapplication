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

    public partial class OrderTest : Form
    {
        private TestController testController;
        public UserInfo userID;
        public Appointment appt; 

        public OrderTest(UserInfo info, Appointment appt)
        {
            InitializeComponent();
            testController = new TestController();
            userID = info;
            lblUserName.Text = userID.userID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Test> testList;
                testList = testController.GetTests();
                cmbTests.DataSource = testList;
                cmbTests.DisplayMember = "TestName";
                cmbTests.ValueMember = "TestCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            cmbAppt.Text = this.appt.apptDateTime; 
        }
    }
}
