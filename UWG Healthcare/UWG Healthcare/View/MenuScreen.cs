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
    public partial class MenuScreen : Form
    {
        UserInfo userID;
        public MenuScreen(UserInfo info)
        {
            InitializeComponent();
            lblUserName.Text = info.userID;
            userID = info;
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {

            //CreateAppointment newApt = new CreateAppointment(userID);
            //newApt.MdiParent = this.MdiParent;
            //newApt.Show();
            //this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPatient newPat = new RegisterPatient(userID);
            newPat.MdiParent = this.MdiParent;
            newPat.Show();
            this.Close();
        }

        private void btnOrderTests_Click(object sender, EventArgs e)
        {
            //TestInfo newTest = new TestInfo();
            //newTest.MdiParent = this.MdiParent;
            //newTest.Show();
            //this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPatient newSearch = new SearchPatient(userID);
            newSearch.MdiParent = this.MdiParent;
            newSearch.Show();
            this.Close();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            VisitInfo newVisit = new VisitInfo(userID, "");
            newVisit.MdiParent = this.MdiParent;
            newVisit.Show();
            this.Close();
        }
    }
}
