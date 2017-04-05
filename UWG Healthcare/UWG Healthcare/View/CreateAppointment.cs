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
        public Appointment newAppointment;
        public UserInfo userID;
        private DoctorController doctorController;
        private PatientController patientController;
        private AppointmentController appointmentController;

        public CreateAppointment(UserInfo info)
        {
            InitializeComponent();
            doctorController = new DoctorController();
            patientController = new PatientController();
            appointmentController = new AppointmentController();
            userID = info;
            lblUserName.Text = userID.userID;
        }

        private void CreateAppointment_Load(object sender, EventArgs e)
        {
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

        // Stores the information from textboxes and combo boxes into variables.
        private void PutIncidentData(Appointment appointment)
        {
            appointment.PatientID = (int)cmbPatientList.SelectedValue;
            appointment.DoctorID = (int)cmbDoctorList.SelectedValue;
            appointment.apptDateTime = dtpDateTime.Text;
            appointment.Reason = txtReason.Text;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            newAppointment = new Appointment();
            this.PutIncidentData(newAppointment);
            try
            {
                newAppointment.ApptID = appointmentController.CreateAppointment(newAppointment);
                MessageBox.Show("The appointment was successfully created.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
