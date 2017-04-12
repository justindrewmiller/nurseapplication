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
using HealthcareData.Model;

namespace UWG_Healthcare.View
{
    public partial class GenerateReport : Form
    {
        public GenerateReport(UserInfo info)
        {
            InitializeComponent();
            lblUserName.Text = info.userID;
        }

    }
}
