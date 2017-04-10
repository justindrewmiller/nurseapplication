namespace UWG_Healthcare.View
{
    partial class CreateAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbDoctorList = new System.Windows.Forms.ComboBox();
            this.cmbPatientList = new System.Windows.Forms.ComboBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(10, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 19);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(148, 167);
            this.txtReason.MaxLength = 200;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(252, 109);
            this.txtReason.TabIndex = 13;
            this.txtReason.Tag = "Reason";
            this.txtReason.Text = "";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(10, 167);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(53, 19);
            this.lblReason.TabIndex = 15;
            this.lblReason.Text = "Reason";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(10, 129);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(98, 19);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "Date and Time";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(10, 93);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(51, 19);
            this.lblDoctor.TabIndex = 12;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(10, 61);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(92, 19);
            this.lblPatientName.TabIndex = 10;
            this.lblPatientName.Text = "Patient Name";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(328, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbDoctorList
            // 
            this.cmbDoctorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctorList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorList.FormattingEnabled = true;
            this.cmbDoctorList.Location = new System.Drawing.Point(148, 90);
            this.cmbDoctorList.Name = "cmbDoctorList";
            this.cmbDoctorList.Size = new System.Drawing.Size(254, 27);
            this.cmbDoctorList.TabIndex = 11;
            this.cmbDoctorList.Tag = "Doctor";
            // 
            // cmbPatientList
            // 
            this.cmbPatientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientList.FormattingEnabled = true;
            this.cmbPatientList.Location = new System.Drawing.Point(148, 54);
            this.cmbPatientList.Name = "cmbPatientList";
            this.cmbPatientList.Size = new System.Drawing.Size(254, 27);
            this.cmbPatientList.TabIndex = 10;
            this.cmbPatientList.Tag = "Patient Name";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTime.Location = new System.Drawing.Point(148, 129);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(252, 26);
            this.dtpDateTime.TabIndex = 12;
            this.dtpDateTime.Tag = "Date and Time";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(235, 298);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 349);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.cmbPatientList);
            this.Controls.Add(this.cmbDoctorList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblPatientName);
            this.Name = "CreateAppointment";
            this.Text = "Create Appointment";
            this.Load += new System.EventHandler(this.CreateAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbDoctorList;
        private System.Windows.Forms.ComboBox cmbPatientList;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Button btnSubmit;
    }
}