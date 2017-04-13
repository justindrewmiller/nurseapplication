namespace UWG_Healthcare
{
    partial class ModifyPatient
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblzip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblstreet = new System.Windows.Forms.Label();
            this.lblssn = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.lblDOB = new System.Windows.Forms.Label();
            this.cmbStatesList = new System.Windows.Forms.ComboBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(136, 303);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(139, 20);
            this.txtPhone.TabIndex = 19;
            this.txtPhone.Tag = "Phone Number";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(136, 233);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(139, 20);
            this.txtZip.TabIndex = 17;
            this.txtZip.Tag = "Zip Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(136, 198);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(210, 20);
            this.txtCity.TabIndex = 16;
            this.txtCity.Tag = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(137, 164);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(209, 20);
            this.txtStreet.TabIndex = 15;
            this.txtStreet.Tag = "Street";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(137, 132);
            this.txtSSN.MaxLength = 9;
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(139, 20);
            this.txtSSN.TabIndex = 14;
            this.txtSSN.Tag = "SSN";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(137, 98);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(139, 20);
            this.txtLName.TabIndex = 13;
            this.txtLName.Tag = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(137, 63);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(139, 20);
            this.txtFName.TabIndex = 12;
            this.txtFName.Tag = "First Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 13);
            this.lblUserName.TabIndex = 29;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(54, 360);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(50, 306);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(51, 13);
            this.lblphone.TabIndex = 26;
            this.lblphone.Text = "Phone #:";
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Location = new System.Drawing.Point(48, 233);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(53, 13);
            this.lblzip.TabIndex = 25;
            this.lblzip.Text = "Zip Code:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(50, 269);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 24;
            this.lblState.Text = "State:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(50, 195);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(27, 13);
            this.lblcity.TabIndex = 23;
            this.lblcity.Text = "City:";
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Location = new System.Drawing.Point(50, 164);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(38, 13);
            this.lblstreet.TabIndex = 22;
            this.lblstreet.Text = "Street:";
            // 
            // lblssn
            // 
            this.lblssn.AutoSize = true;
            this.lblssn.Location = new System.Drawing.Point(50, 132);
            this.lblssn.Name = "lblssn";
            this.lblssn.Size = new System.Drawing.Size(32, 13);
            this.lblssn.TabIndex = 21;
            this.lblssn.Text = "SSN:";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(50, 101);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(61, 13);
            this.lbllname.TabIndex = 20;
            this.lbllname.Text = "Last Name:";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(50, 66);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(60, 13);
            this.lblfname.TabIndex = 19;
            this.lblfname.Text = "First Name:";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(137, 34);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(62, 20);
            this.txtPersonID.TabIndex = 10;
            this.txtPersonID.Tag = "Person ID";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(50, 37);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(57, 13);
            this.lblPersonID.TabIndex = 38;
            this.lblPersonID.Text = "Person ID:";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(229, 32);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(92, 23);
            this.getButton.TabIndex = 11;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(51, 337);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(33, 13);
            this.lblDOB.TabIndex = 41;
            this.lblDOB.Text = "DOB:";
            // 
            // cmbStatesList
            // 
            this.cmbStatesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatesList.FormattingEnabled = true;
            this.cmbStatesList.Location = new System.Drawing.Point(136, 266);
            this.cmbStatesList.Name = "cmbStatesList";
            this.cmbStatesList.Size = new System.Drawing.Size(174, 21);
            this.cmbStatesList.TabIndex = 18;
            this.cmbStatesList.Tag = "State";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTime.Location = new System.Drawing.Point(136, 330);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTime.TabIndex = 20;
            // 
            // ModifyPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 407);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.cmbStatesList);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.lblPersonID);
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
            this.Name = "ModifyPatient";
            this.Text = "Modify Patient";
            this.Load += new System.EventHandler(this.ModifyPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.Label lblssn;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ComboBox cmbStatesList;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
    }
}