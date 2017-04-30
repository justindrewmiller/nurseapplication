namespace UWG_Healthcare.View
{
    partial class ModifyVisitInfo
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
            this.cboDiagnoses = new System.Windows.Forms.ComboBox();
            this.txtAppointment = new System.Windows.Forms.TextBox();
            this.lstTests = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.txtSymptoms = new System.Windows.Forms.RichTextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtPulse = new System.Windows.Forms.TextBox();
            this.lblPulse = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDiaBP = new System.Windows.Forms.Label();
            this.lblSysBP = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSys = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDiagnoses
            // 
            this.cboDiagnoses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiagnoses.FormattingEnabled = true;
            this.cboDiagnoses.Location = new System.Drawing.Point(160, 230);
            this.cboDiagnoses.Margin = new System.Windows.Forms.Padding(2);
            this.cboDiagnoses.Name = "cboDiagnoses";
            this.cboDiagnoses.Size = new System.Drawing.Size(388, 27);
            this.cboDiagnoses.TabIndex = 68;
            // 
            // txtAppointment
            // 
            this.txtAppointment.Enabled = false;
            this.txtAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointment.Location = new System.Drawing.Point(160, 54);
            this.txtAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppointment.Name = "txtAppointment";
            this.txtAppointment.Size = new System.Drawing.Size(388, 26);
            this.txtAppointment.TabIndex = 67;
            this.txtAppointment.Tag = "Appointment";
            // 
            // lstTests
            // 
            this.lstTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstTests.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTests.Location = new System.Drawing.Point(159, 263);
            this.lstTests.Margin = new System.Windows.Forms.Padding(2);
            this.lstTests.Name = "lstTests";
            this.lstTests.Size = new System.Drawing.Size(515, 112);
            this.lstTests.TabIndex = 66;
            this.lstTests.UseCompatibleStateImageBehavior = false;
            this.lstTests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Test Code";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Test Name";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Test Date";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Appt ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Result";
            this.columnHeader5.Width = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tests:";
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptoms.Location = new System.Drawing.Point(77, 156);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(77, 19);
            this.lblSymptoms.TabIndex = 63;
            this.lblSymptoms.Text = "Symptoms:";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Enabled = false;
            this.txtSymptoms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymptoms.Location = new System.Drawing.Point(160, 156);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(388, 65);
            this.txtSymptoms.TabIndex = 58;
            this.txtSymptoms.Tag = "Symptoms";
            this.txtSymptoms.Text = "";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(82, 230);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(71, 19);
            this.lblDiagnosis.TabIndex = 59;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // txtPulse
            // 
            this.txtPulse.Enabled = false;
            this.txtPulse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPulse.Location = new System.Drawing.Point(455, 118);
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(93, 26);
            this.txtPulse.TabIndex = 57;
            this.txtPulse.Tag = "Pulse";
            // 
            // lblPulse
            // 
            this.lblPulse.AutoSize = true;
            this.lblPulse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulse.Location = new System.Drawing.Point(394, 118);
            this.lblPulse.Name = "lblPulse";
            this.lblPulse.Size = new System.Drawing.Size(44, 19);
            this.lblPulse.TabIndex = 56;
            this.lblPulse.Text = "Pulse:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(65, 124);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(90, 19);
            this.lblTemp.TabIndex = 54;
            this.lblTemp.Text = "Temperature:";
            // 
            // lblDiaBP
            // 
            this.lblDiaBP.AutoSize = true;
            this.lblDiaBP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaBP.Location = new System.Drawing.Point(287, 88);
            this.lblDiaBP.Name = "lblDiaBP";
            this.lblDiaBP.Size = new System.Drawing.Size(158, 19);
            this.lblDiaBP.TabIndex = 52;
            this.lblDiaBP.Text = "Diastolic Blood Pressure:";
            // 
            // lblSysBP
            // 
            this.lblSysBP.AutoSize = true;
            this.lblSysBP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysBP.Location = new System.Drawing.Point(6, 88);
            this.lblSysBP.Name = "lblSysBP";
            this.lblSysBP.Size = new System.Drawing.Size(152, 19);
            this.lblSysBP.TabIndex = 50;
            this.lblSysBP.Text = "Systolic Blood Pressure:";
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(160, 122);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(93, 26);
            this.txtTemp.TabIndex = 55;
            this.txtTemp.Tag = "Temperature";
            this.txtTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp_KeyPress_1);
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(455, 86);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(93, 26);
            this.txtDia.TabIndex = 53;
            this.txtDia.Tag = "Diastolic Blood Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Appointment:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(159, 387);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 29);
            this.btnSubmit.TabIndex = 61;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSys
            // 
            this.txtSys.Enabled = false;
            this.txtSys.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSys.Location = new System.Drawing.Point(160, 88);
            this.txtSys.Name = "txtSys";
            this.txtSys.Size = new System.Drawing.Size(93, 26);
            this.txtSys.TabIndex = 51;
            this.txtSys.Tag = "Systolic Blood Pressure";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(240, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(15, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(162, 19);
            this.lblUserName.TabIndex = 48;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // ModifyVisitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 430);
            this.Controls.Add(this.cboDiagnoses);
            this.Controls.Add(this.txtAppointment);
            this.Controls.Add(this.lstTests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSymptoms);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.txtPulse);
            this.Controls.Add(this.lblPulse);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblDiaBP);
            this.Controls.Add(this.lblSysBP);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSys);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUserName);
            this.Name = "ModifyVisitInfo";
            this.Text = "Modify Visit Information";
            this.Load += new System.EventHandler(this.ModifyVisitInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDiagnoses;
        private System.Windows.Forms.TextBox txtAppointment;
        private System.Windows.Forms.ListView lstTests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.RichTextBox txtSymptoms;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtPulse;
        private System.Windows.Forms.Label lblPulse;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDiaBP;
        private System.Windows.Forms.Label lblSysBP;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSys;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
    }
}