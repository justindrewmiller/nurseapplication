using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWG_Healthcare
{
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
        }

        // Exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Contains form to Register New Patient
        private void registerNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterPatient rp = new RegisterPatient();
            rp.MdiParent = this;
            rp.Show();
        }

        // Contains form to Modify Patient
        private void modifyPatientProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyPatient mp = new ModifyPatient();
            mp.MdiParent = this;
            mp.Show();
        }

        // Contains form to Create New Appointment
        private void createAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAppointment ca = new CreateAppointment();
            ca.MdiParent = this;
            ca.Show();
        }

        // Contains form to Search for Patient or Appointment
        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPatient sp = new SearchPatient();
            sp.MdiParent = this;
            sp.Show();

        }
        
        // Can display name in container
        private void MainContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
