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
    public partial class CurrentAppointment : Form
    {

        public UserInfo userID;
        public string apptID;

        public CurrentAppointment(UserInfo info, string apptID)
        {
            InitializeComponent();
            userID = info;
            this.apptID = apptID;
            lblUserID.Text = userID.userID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}
