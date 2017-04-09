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
        public VisitInfo(UserInfo info, string visitID)
        {
            InitializeComponent();
            this.info = info;
            this.visitID = visitID;
            lblUserName.Text = info.userID;
        }

        private void VisitInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
