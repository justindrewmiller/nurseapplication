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
    public partial class CurrentAppointment : Form
    {

        public UserInfo userID;
        public int apptID;
        private Appointment currentApt;

        public CurrentAppointment(UserInfo info, int apptID)
        {
            InitializeComponent();
            userID = info;
            this.apptID = apptID;
            lblUserID.Text = userID.userID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            try
            {
                this.currentApt = AppointmentController.GetAppointment(this.apptID);
                this.LoadComboBoxes();
                txtPatientName.Text = PatientController.GetPatient(this.currentApt.PatientID).FName + " " + PatientController.GetPatient(this.currentApt.PatientID).LName;
                dateTimePicker.Value = Convert.ToDateTime(this.currentApt.apptDateTime);
                txtReason.Text = this.currentApt.Reason;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm";

        }

        private void LoadComboBoxes()
        {
            try
            {
                List<Doctor> docList;
                docList = DoctorController.GetDoctors();
                cboDoctor.DataSource = docList;
                cboDoctor.DisplayMember = "FullName";
                cboDoctor.ValueMember = "DoctorID";
                cboDoctor.SelectedValue = this.currentApt.DoctorID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                if (txtReason.Text.Length < 10)
                {
                    MessageBox.Show("Reason should be longer than 10 characters.");
                    return;
                }
                this.currentApt.apptDateTime = dateTimePicker.Value.ToString();
                this.currentApt.Reason = txtReason.ToString();
                this.currentApt.DoctorID = (int)cboDoctor.SelectedValue;
                try
                {
                    if (AppointmentController.UpdateAppointment(this.currentApt))
                    {
                        MessageBox.Show("Appointment updated!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                    MessageBox.Show("The appointment was successfully updated.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
        }

        private bool isValidData()
        {
            if (Validator.IsPresent(txtPatientName) &&
                Validator.IsPresent(cboDoctor) &&
                Validator.IsPresent(dateTimePicker) &&
                Validator.IsPresent(txtReason))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
