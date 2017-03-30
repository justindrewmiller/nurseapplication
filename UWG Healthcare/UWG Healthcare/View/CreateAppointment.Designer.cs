namespace UWG_Healthcare
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
            this.components = new System.ComponentModel.Container();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblNewPatient = new System.Windows.Forms.Label();
            this.lblPatientSSN = new System.Windows.Forms.Label();
            this.lblDr = new System.Windows.Forms.Label();
            this.lblTimeScheduled = new System.Windows.Forms.Label();
            this.lblReasons = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.cboDoctor = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtReasons = new System.Windows.Forms.RichTextBox();
            this.drList = new UWG_Healthcare.DrList();
            this.drListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserNamePlaceHolder";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblNewPatient
            // 
            this.lblNewPatient.AutoSize = true;
            this.lblNewPatient.Location = new System.Drawing.Point(12, 52);
            this.lblNewPatient.Name = "lblNewPatient";
            this.lblNewPatient.Size = new System.Drawing.Size(68, 13);
            this.lblNewPatient.TabIndex = 1;
            this.lblNewPatient.Text = "New Patient:";
            // 
            // lblPatientSSN
            // 
            this.lblPatientSSN.AutoSize = true;
            this.lblPatientSSN.Location = new System.Drawing.Point(12, 87);
            this.lblPatientSSN.Name = "lblPatientSSN";
            this.lblPatientSSN.Size = new System.Drawing.Size(68, 13);
            this.lblPatientSSN.TabIndex = 2;
            this.lblPatientSSN.Text = "Patient SSN:";
            // 
            // lblDr
            // 
            this.lblDr.AutoSize = true;
            this.lblDr.Location = new System.Drawing.Point(12, 125);
            this.lblDr.Name = "lblDr";
            this.lblDr.Size = new System.Drawing.Size(42, 13);
            this.lblDr.TabIndex = 3;
            this.lblDr.Text = "Doctor:";
            // 
            // lblTimeScheduled
            // 
            this.lblTimeScheduled.AutoSize = true;
            this.lblTimeScheduled.Location = new System.Drawing.Point(12, 165);
            this.lblTimeScheduled.Name = "lblTimeScheduled";
            this.lblTimeScheduled.Size = new System.Drawing.Size(87, 13);
            this.lblTimeScheduled.TabIndex = 4;
            this.lblTimeScheduled.Text = "Time Scheduled:";
            // 
            // lblReasons
            // 
            this.lblReasons.AutoSize = true;
            this.lblReasons.Location = new System.Drawing.Point(12, 204);
            this.lblReasons.Name = "lblReasons";
            this.lblReasons.Size = new System.Drawing.Size(89, 13);
            this.lblReasons.TabIndex = 5;
            this.lblReasons.Text = "Reasons for Visit:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(52, 341);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Location = new System.Drawing.Point(156, 52);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(44, 17);
            this.chkYes.TabIndex = 8;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(221, 52);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(40, 17);
            this.chkNo.TabIndex = 9;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(139, 84);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(150, 20);
            this.txtSSN.TabIndex = 10;
            // 
            // cboDoctor
            // 
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(139, 125);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(182, 21);
            this.cboDoctor.TabIndex = 11;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(139, 165);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 20);
            this.txtTime.TabIndex = 12;
            // 
            // txtReasons
            // 
            this.txtReasons.Location = new System.Drawing.Point(139, 204);
            this.txtReasons.Name = "txtReasons";
            this.txtReasons.Size = new System.Drawing.Size(150, 96);
            this.txtReasons.TabIndex = 13;
            this.txtReasons.Text = "";
            // 
            // drList
            // 
            this.drList.DataSetName = "DrList";
            this.drList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drListBindingSource
            // 
            this.drListBindingSource.DataSource = this.drList;
            this.drListBindingSource.Position = 0;
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 376);
            this.Controls.Add(this.txtReasons);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.cboDoctor);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkYes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblReasons);
            this.Controls.Add(this.lblTimeScheduled);
            this.Controls.Add(this.lblDr);
            this.Controls.Add(this.lblPatientSSN);
            this.Controls.Add(this.lblNewPatient);
            this.Controls.Add(this.lblUserName);
            this.Name = "CreateAppointment";
            this.Text = "Create Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.drList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblNewPatient;
        private System.Windows.Forms.Label lblPatientSSN;
        private System.Windows.Forms.Label lblDr;
        private System.Windows.Forms.Label lblTimeScheduled;
        private System.Windows.Forms.Label lblReasons;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.ComboBox cboDoctor;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.RichTextBox txtReasons;
        private DrList drList;
        private System.Windows.Forms.BindingSource drListBindingSource;
    }
}