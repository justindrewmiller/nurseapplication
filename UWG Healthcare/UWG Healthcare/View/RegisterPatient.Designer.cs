namespace UWG_Healthcare
{
    partial class RegisterPatient
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
            this.lblfname = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblssn = new System.Windows.Forms.Label();
            this.lblstreet = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblzip = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.cmbStatesList = new System.Windows.Forms.ComboBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(10, 54);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(78, 19);
            this.lblfname.TabIndex = 0;
            this.lblfname.Text = "First Name:";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllname.Location = new System.Drawing.Point(256, 54);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(77, 19);
            this.lbllname.TabIndex = 1;
            this.lbllname.Text = "Last Name:";
            // 
            // lblssn
            // 
            this.lblssn.AutoSize = true;
            this.lblssn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblssn.Location = new System.Drawing.Point(48, 85);
            this.lblssn.Name = "lblssn";
            this.lblssn.Size = new System.Drawing.Size(36, 19);
            this.lblssn.TabIndex = 2;
            this.lblssn.Text = "SSN:";
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstreet.Location = new System.Drawing.Point(38, 115);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(48, 19);
            this.lblstreet.TabIndex = 3;
            this.lblstreet.Text = "Street:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(50, 146);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(36, 19);
            this.lblcity.TabIndex = 4;
            this.lblcity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(43, 182);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(43, 19);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State:";
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzip.Location = new System.Drawing.Point(311, 149);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(67, 19);
            this.lblzip.TabIndex = 6;
            this.lblzip.Text = "Zip Code:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(268, 182);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(63, 19);
            this.lblphone.TabIndex = 7;
            this.lblphone.Text = "Phone #:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(333, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(414, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(10, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 19);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(88, 52);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(158, 26);
            this.txtFName.TabIndex = 11;
            this.txtFName.Tag = "First Name";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(333, 51);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(158, 26);
            this.txtLName.TabIndex = 12;
            this.txtLName.Tag = "Last Name";
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSN.Location = new System.Drawing.Point(88, 83);
            this.txtSSN.MaxLength = 9;
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(158, 26);
            this.txtSSN.TabIndex = 13;
            this.txtSSN.Tag = "SSN";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(88, 115);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(402, 26);
            this.txtStreet.TabIndex = 15;
            this.txtStreet.Tag = "Street";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(88, 146);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(218, 26);
            this.txtCity.TabIndex = 16;
            this.txtCity.Tag = "City";
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(380, 146);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(112, 26);
            this.txtZip.TabIndex = 17;
            this.txtZip.Tag = "Zip Code";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(333, 182);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 26);
            this.txtPhone.TabIndex = 19;
            this.txtPhone.Tag = "Phone Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(256, 83);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(41, 19);
            this.lblDOB.TabIndex = 19;
            this.lblDOB.Text = "DOB:";
            // 
            // cmbStatesList
            // 
            this.cmbStatesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatesList.FormattingEnabled = true;
            this.cmbStatesList.Location = new System.Drawing.Point(88, 178);
            this.cmbStatesList.Name = "cmbStatesList";
            this.cmbStatesList.Size = new System.Drawing.Size(174, 21);
            this.cmbStatesList.TabIndex = 18;
            this.cmbStatesList.Tag = "State";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTime.Location = new System.Drawing.Point(303, 80);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(186, 26);
            this.dtpDateTime.TabIndex = 14;
            // 
            // RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 273);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.cmbStatesList);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblzip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblstreet);
            this.Controls.Add(this.lblssn);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Name = "RegisterPatient";
            this.Text = "Patient Registration";
            this.Load += new System.EventHandler(this.RegisterPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblssn;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ComboBox cmbStatesList;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
    }
}