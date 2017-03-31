using HealthcareData;
using HealthcareData.DAL;
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

        public void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo();
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            if (Controller.HealthcareController.ValidLogin(UserName, Password))
            {
                ui.userID = Controller.HealthcareController.GetUserInfo(UserName, Password);
               this.Visible = false;
                MainContainer mc = new MainContainer(ui);
                mc.Show();
            } else
            {
                lblInvalid.Text = "Username or password was invalid";
            }

        }
    }
}
