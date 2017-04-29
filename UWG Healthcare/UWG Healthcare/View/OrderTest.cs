using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        VisitInfo _owner;

        public OrderTest(UserInfo info, Appointment appt, VisitInfo owner)
        {
            InitializeComponent();
            testController = new TestController();
            userID = info;
            lblUserName.Text = userID.userID;
            this.appt = appt;

            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderTest_FormClosing);
        }

        private void OrderTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
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
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                testController.OrderTest(appt.ApptID, dateTimePicker1.Value, int.Parse(cmbTests.SelectedValue.ToString())); 
                MessageBox.Show("The test was successfully ordered.");
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("You have already ordered that test for today!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
           
        }

    }
}
