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
using UWG_Healthcare.View;

namespace UWG_Healthcare
{
    public partial class MainContainer : Form
    {

        UserInfo userLoggedIn;
        String role = "";

        private HealthcareController inController;
        public MainContainer(UserInfo user)
        {
            userLoggedIn = user;

            InitializeComponent();
            inController = new HealthcareController();
            String role = userRole(userLoggedIn);
            lblUserID.Text = lblUserID.Text + userLoggedIn.userID +"\nRole: " + role;
        }

        // Sets the role of the user after logging in.
        private String userRole(UserInfo user)
        {
            if(user.AdminID > 0)
            {
                role = "ADMINISTRATOR";
                registerNewPatientToolStripMenuItem.Visible = false;
                modifyPatientProfileToolStripMenuItem.Visible = false;
                createAppointmentToolStripMenuItem.Visible = false;
                searchPatientToolStripMenuItem.Visible = false;
                generateReportToolStripMenuItem.Visible = true;
            }
            if (user.DoctorID > 0)
            {
                role = "DOCTOR";
                registerNewPatientToolStripMenuItem.Visible = false;
                modifyPatientProfileToolStripMenuItem.Visible = false;
                createAppointmentToolStripMenuItem.Visible = false;
                searchPatientToolStripMenuItem.Visible = false;
                generateReportToolStripMenuItem.Visible = false;
            }
            if (user.NurseID > 0)
            {
                role = "NURSE";
                generateReportToolStripMenuItem.Visible = false;
            }
            return role;
        }

        // Exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Contains form to Register New Patient
        private void registerNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterPatient rp = new RegisterPatient(userLoggedIn);
            rp.MdiParent = this;
            rp.Show();
        }

        // Contains form to Modify Patient
        private void modifyPatientProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyPatient mp = new ModifyPatient(userLoggedIn);
            mp.MdiParent = this;
            mp.Show();
        }

        // Contains form to Create New Appointment
        private void createAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAppointment ca = new CreateAppointment(userLoggedIn);
            ca.MdiParent = this;
            ca.Show();
        }

        // Contains form to Search for Patient or Appointment
        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPatient sp = new SearchPatient(userLoggedIn);
            sp.MdiParent = this;
            sp.Show();

        }

        private void MainContainer_Load(object sender, EventArgs e)
        {
            //if (role == "NURSE")
            //{
            //    MenuScreen ms = new MenuScreen(userLoggedIn);
            //    ms.MdiParent = this;
            //    ms.Show();
            //}
            
        }

        private void logIn_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn li = new LogIn();
            li.Show();
        }

        private void menuScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen(userLoggedIn);
            ms.MdiParent = this;
            ms.Show();
        }

        // Generates form for running the admin report
        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAdminReport gr = new CreateAdminReport(userLoggedIn);
            gr.MdiParent = this;
            gr.Show();

        }
    
    }
}
