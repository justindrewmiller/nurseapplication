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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSymptoms = new System.Windows.Forms.RichTextBox();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.txtAppointment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(238, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSys
            // 
            this.txtSys.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSys.Location = new System.Drawing.Point(168, 90);
            this.txtSys.Name = "txtSys";
            this.txtSys.Size = new System.Drawing.Size(93, 26);
            this.txtSys.TabIndex = 11;
            this.txtSys.Tag = "Systolic Blood Pressure";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(157, 277);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 29);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointment:";
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(430, 90);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(93, 26);
            this.txtDia.TabIndex = 12;
            this.txtDia.Tag = "Diastolic Blood Pressure";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(164, 124);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(93, 26);
            this.txtTemp.TabIndex = 13;
            this.txtTemp.Tag = "Temperature";
            // 
            // lblSysBP
            // 
            this.lblSysBP.AutoSize = true;
            this.lblSysBP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysBP.Location = new System.Drawing.Point(13, 90);
            this.lblSysBP.Name = "lblSysBP";
            this.lblSysBP.Size = new System.Drawing.Size(152, 19);
            this.lblSysBP.TabIndex = 10;
            this.lblSysBP.Text = "Systolic Blood Pressure:";
            // 
            // lblDiaBP
            // 
            this.lblDiaBP.AutoSize = true;
            this.lblDiaBP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaBP.Location = new System.Drawing.Point(267, 93);
            this.lblDiaBP.Name = "lblDiaBP";
            this.lblDiaBP.Size = new System.Drawing.Size(158, 19);
            this.lblDiaBP.TabIndex = 11;
            this.lblDiaBP.Text = "Diastolic Blood Pressure:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(68, 127);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(90, 19);
            this.lblTemp.TabIndex = 12;
            this.lblTemp.Text = "Temperature:";
            // 
            // lblPulse
            // 
            this.lblPulse.AutoSize = true;
            this.lblPulse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulse.Location = new System.Drawing.Point(384, 124);
            this.lblPulse.Name = "lblPulse";
            this.lblPulse.Size = new System.Drawing.Size(44, 19);
            this.lblPulse.TabIndex = 13;
            this.lblPulse.Text = "Pulse:";
            // 
            // txtPulse
            // 
            this.txtPulse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPulse.Location = new System.Drawing.Point(430, 121);
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(93, 26);
            this.txtPulse.TabIndex = 14;
            this.txtPulse.Tag = "Pulse";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(157, 228);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(293, 43);
            this.txtDiagnosis.TabIndex = 16;
            this.txtDiagnosis.Tag = "Diagnosis";
            this.txtDiagnosis.Text = "";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(80, 228);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(71, 19);
            this.lblDiagnosis.TabIndex = 16;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(459, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 28);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Diagnosis";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymptoms.Location = new System.Drawing.Point(157, 154);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(367, 65);
            this.txtSymptoms.TabIndex = 15;
            this.txtSymptoms.Tag = "Symptoms";
            this.txtSymptoms.Text = "";
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptoms.Location = new System.Drawing.Point(80, 154);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(77, 19);
            this.lblSymptoms.TabIndex = 19;
            this.lblSymptoms.Text = "Symptoms:";
            // 
            // txtAppointment
            // 
            this.txtAppointment.Location = new System.Drawing.Point(157, 57);
            this.txtAppointment.Name = "txtAppointment";
            this.txtAppointment.Size = new System.Drawing.Size(241, 20);
            this.txtAppointment.TabIndex = 10;
            this.txtAppointment.Tag = "Appointment";
            // 
            // VisitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 327);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox txtSymptoms;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.TextBox txtAppointment;
    }
}