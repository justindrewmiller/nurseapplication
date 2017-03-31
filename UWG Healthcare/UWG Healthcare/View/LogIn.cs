using HealthcareData;
using HealthcareData.DAL;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

 
        private void LogIn_Load(object sender, EventArgs e)
        {
            lblInvalid.Text = "Enter valid user name and password";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            if (Controller.HealthcareController.ValidLogin(UserName, Password))
            {
                MenuScreen menu = new MenuScreen();
                menu.MdiParent = this.MdiParent;
                menu.Show();
                this.Close();
            } else
            {
                lblInvalid.Text = "Username or password was invalid";
            }

        }
    }
}
