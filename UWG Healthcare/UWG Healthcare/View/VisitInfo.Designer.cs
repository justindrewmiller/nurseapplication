namespace UWG_Healthcare.View
{
    partial class VisitInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSys = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblSysBP = new System.Windows.Forms.Label();
            this.lblDiaBP = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblPulse = new System.Windows.Forms.Label();
            this.txtPulse = new System.Windows.Forms.TextBox();
            this.txtDiagnosis = new System.Windows.Forms.RichTextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtSymptoms = new System.Windows.Forms.RichTextBox();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.txtAppointment = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstTests = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(16, 11);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(188, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(316, 470);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSys
            // 
            this.txtSys.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSys.Location = new System.Drawing.Point(209, 111);
            this.txtSys.Margin = new System.Windows.Forms.Padding(4);
            this.txtSys.Name = "txtSys";
            this.txtSys.Size = new System.Drawing.Size(123, 30);
            this.txtSys.TabIndex = 11;
            this.txtSys.Tag = "Systolic Blood Pressure";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(208, 470);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 36);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointment:";
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(602, 108);
            this.txtDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(123, 30);
            this.txtDia.TabIndex = 12;
            this.txtDia.Tag = "Diastolic Blood Pressure";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(209, 152);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(123, 30);
            this.txtTemp.TabIndex = 13;
            this.txtTemp.Tag = "Temperature";
            // 
            // lblSysBP
            // 
            this.lblSysBP.AutoSize = true;
            this.lblSysBP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysBP.Location = new System.Drawing.Point(4, 111);
            this.lblSysBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSysBP.Name = "lblSysBP";
            this.lblSysBP.Size = new System.Drawing.Size(188, 23);
            this.lblSysBP.TabIndex = 10;
            this.lblSysBP.Text = "Systolic Blood Pressure:";
            // 
            // lblDiaBP
            // 
            this.lblDiaBP.AutoSize = true;
            this.lblDiaBP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaBP.Location = new System.Drawing.Point(379, 111);
            this.lblDiaBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaBP.Name = "lblDiaBP";
            this.lblDiaBP.Size = new System.Drawing.Size(196, 23);
            this.lblDiaBP.TabIndex = 11;
            this.lblDiaBP.Text = "Diastolic Blood Pressure:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(82, 155);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(110, 23);
            this.lblTemp.TabIndex = 12;
            this.lblTemp.Text = "Temperature:";
            // 
            // lblPulse
            // 
            this.lblPulse.AutoSize = true;
            this.lblPulse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulse.Location = new System.Drawing.Point(521, 148);
            this.lblPulse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPulse.Name = "lblPulse";
            this.lblPulse.Size = new System.Drawing.Size(54, 23);
            this.lblPulse.TabIndex = 13;
            this.lblPulse.Text = "Pulse:";
            // 
            // txtPulse
            // 
            this.txtPulse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPulse.Location = new System.Drawing.Point(602, 148);
            this.txtPulse.Margin = new System.Windows.Forms.Padding(4);
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(123, 30);
            this.txtPulse.TabIndex = 14;
            this.txtPulse.Tag = "Pulse";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(209, 285);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(516, 34);
            this.txtDiagnosis.TabIndex = 16;
            this.txtDiagnosis.Tag = "Diagnosis";
            this.txtDiagnosis.Text = "";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(105, 285);
            this.lblDiagnosis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(87, 23);
            this.lblDiagnosis.TabIndex = 16;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymptoms.Location = new System.Drawing.Point(209, 194);
            this.txtSymptoms.Margin = new System.Windows.Forms.Padding(4);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(516, 79);
            this.txtSymptoms.TabIndex = 15;
            this.txtSymptoms.Tag = "Symptoms";
            this.txtSymptoms.Text = "";
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptoms.Location = new System.Drawing.Point(98, 194);
            this.lblSymptoms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(94, 23);
            this.lblSymptoms.TabIndex = 19;
            this.lblSymptoms.Text = "Symptoms:";
            // 
            // txtAppointment
            // 
            this.txtAppointment.Enabled = false;
            this.txtAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointment.Location = new System.Drawing.Point(209, 70);
            this.txtAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppointment.Name = "txtAppointment";
            this.txtAppointment.Size = new System.Drawing.Size(516, 30);
            this.txtAppointment.TabIndex = 10;
            this.txtAppointment.Tag = "Appointment";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(731, 285);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 34);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Diagnosis";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tests:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(731, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Order Tests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.lstTests.Location = new System.Drawing.Point(208, 326);
            this.lstTests.Name = "lstTests";
            this.lstTests.Size = new System.Drawing.Size(517, 137);
            this.lstTests.TabIndex = 45;
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
            // VisitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 540);
            this.Controls.Add(this.lstTests);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAppointment);
            this.Controls.Add(this.lblSymptoms);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.txtDiagnosis);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisitInfo";
            this.Text = "Visit Information";
            this.Load += new System.EventHandler(this.VisitInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSys;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblSysBP;
        private System.Windows.Forms.Label lblDiaBP;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblPulse;
        private System.Windows.Forms.TextBox txtPulse;
        private System.Windows.Forms.RichTextBox txtDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.RichTextBox txtSymptoms;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.TextBox txtAppointment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstTests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}