using HealthcareData;
using HealthcareData.DAL;
using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            // To view encrypted password make encryptedTB.Visible = true.
            encryptedTB.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfo ui;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            encryptedTB.Text = GetSHA1HashData(Password);
            try
            {
                if (Controller.HealthcareController.ValidLogin(UserName, Password))
                {
                    ui = Controller.HealthcareController.GetUser(UserName, Password);
                    this.Visible = false;
                    MainContainer mc = new MainContainer(ui);
                    mc.Show();
                } else
                {
                    lblInvalid.Text = "Username or password was invalid";
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    this.BeginInvoke(new MethodInvoker(Close));
                }
        }

        private static string GetSHA1HashData(string data)
        {
            //create new instance of md5
            SHA1 sha1 = SHA1.Create();

            //convert the input text to array of bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            return returnValue.ToString();
        }
    }
}
