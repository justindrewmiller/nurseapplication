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

namespace UWG_Healthcare.View
{
    public partial class CreateAppointment : Form
    {
        public UserInfo userID;
        private DoctorController doctorController;
        private PatientController patientController;
        //Doctor doctor;
        public CreateAppointment(UserInfo info)
        {
            InitializeComponent();
            doctorController = new DoctorController();
            patientController = new Controller.PatientController();
            userID = info;
            lblUserName.Text = userID.userID;
            this.LoadComboBox();
            cmbDoctorList.SelectedIndex = -1;
            cmbPatientList.SelectedIndex = -1;
        }

        // Loads the Doctor information into comboboxes
        private void LoadComboBox()
        {
            try
            {
                List<Doctor> docList;
                docList = doctorController.GetDoctors();
                cmbDoctorList.DataSource = docList;
                cmbDoctorList.DisplayMember = "FullName";
                cmbDoctorList.ValueMember = "DoctorID";

                List<Patient> patientList;
                patientList = patientController.GetPatients();
                cmbPatientList.DataSource = patientList;
                cmbPatientList.DisplayMember = "FullName";
                cmbPatientList.ValueMember = "PatientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
