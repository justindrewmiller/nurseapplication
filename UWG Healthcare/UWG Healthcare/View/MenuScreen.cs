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
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            CreateAppointment newApt = new CreateAppointment();
            newApt.MdiParent = this.MdiParent;
            newApt.Show();
            this.Close();
        }
    }
}
