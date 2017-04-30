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
        public Patient currentPatient;
        private DoctorController doctorController;
        private PatientController patientController;
        private AppointmentController appointmentController;

        public CreateAppointment(UserInfo info, Patient currentPatient)
        {
            InitializeComponent();
            this.currentPatient = currentPatient;
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
            //Sets the Date time to be a minimum of Today.
            dtpDateTime.MinDate = DateTime.Today;
            txtPatientName.Text = this.currentPatient.FullName;

            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "MM/dd/yyyy hh:mm";

        }

        // Loads the Doctor information into comboboxes
        private void LoadComboBox()
        {
            try
            {
                List<Doctor> docList;
                docList = DoctorController.GetDoctors();
                cmbDoctorList.DataSource = docList;
                cmbDoctorList.DisplayMember = "FullName";
                cmbDoctorList.ValueMember = "DoctorID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private bool isValidData()
        {
            if (Validator.IsPresent(txtPatientName) &&
                Validator.IsPresent(cmbDoctorList) &&
                Validator.IsPresent(dtpDateTime) &&
                Validator.IsPresent(txtReason))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        // Stores the information from textboxes and combo boxes into variables.
        private void PutIncidentData(Appointment appointment)
        {
            appointment.PatientID = this.currentPatient.PatientID;
            appointment.DoctorID = (int)cmbDoctorList.SelectedValue;
            appointment.apptDateTime = dtpDateTime.Text;
            appointment.Reason = txtReason.Text;
            appointment.isCheckedIn = "False";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                if(txtReason.Text.Length < 10)
                {
                    MessageBox.Show("Reason should be longer than 10 characters.");
                    return;
                }
                else if (dtpDateTime.Value < DateTime.Now)
                {
                    MessageBox.Show("You can not create an appointment for the past!");
                    return; 
                }
                else
                {
                newAppointment = new Appointment();
                this.PutIncidentData(newAppointment);
                try
                {
                    newAppointment.ApptID = AppointmentController.CreateAppointment(newAppointment);
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
    }
}
