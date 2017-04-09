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

        public TestInfo(UserInfo info, Patient patient)
        {
            InitializeComponent();
            this.info = info;
            lblUserName.Text = info.userID;
            this.patient = patient;
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
