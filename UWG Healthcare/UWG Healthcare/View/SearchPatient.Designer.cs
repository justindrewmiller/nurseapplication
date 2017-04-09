namespace UWG_Healthcare
{
    partial class SearchPatient
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
            this.lblSearchFName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.lblSearchLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.lvPatients = new System.Windows.Forms.ListView();
            this.PatientFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // lblSearchFName
            // 
            this.lblSearchFName.AutoSize = true;
            this.lblSearchFName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFName.Location = new System.Drawing.Point(34, 66);
            this.lblSearchFName.Name = "lblSearchFName";
            this.lblSearchFName.Size = new System.Drawing.Size(75, 19);
            this.lblSearchFName.TabIndex = 1;
            this.lblSearchFName.Text = "First Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(57, 153);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(38, 19);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(115, 63);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(159, 26);
            this.txtFName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(115, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(273, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.Location = new System.Drawing.Point(115, 407);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(96, 32);
            this.btnGoTo.TabIndex = 7;
            this.btnGoTo.Text = "Select Patient";
            this.btnGoTo.UseVisualStyleBackColor = true;
            // 
            // lblSearchLName
            // 
            this.lblSearchLName.AutoSize = true;
            this.lblSearchLName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLName.Location = new System.Drawing.Point(34, 104);
            this.lblSearchLName.Name = "lblSearchLName";
            this.lblSearchLName.Size = new System.Drawing.Size(74, 19);
            this.lblSearchLName.TabIndex = 9;
            this.lblSearchLName.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(115, 101);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(159, 26);
            this.txtLName.TabIndex = 10;
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(115, 152);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(200, 20);
            this.dtDOB.TabIndex = 13;
            // 
            // lvPatients
            // 
            this.lvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientFName,
            this.PatientLName,
            this.patientDOB,
            this.PatientID});
            this.lvPatients.Location = new System.Drawing.Point(97, 248);
            this.lvPatients.Name = "lvPatients";
            this.lvPatients.Size = new System.Drawing.Size(294, 133);
            this.lvPatients.TabIndex = 14;
            this.lvPatients.UseCompatibleStateImageBehavior = false;
            this.lvPatients.View = System.Windows.Forms.View.Details;
            // 
            // PatientFName
            // 
            this.PatientFName.Text = "First Name";
            this.PatientFName.Width = 76;
            // 
            // PatientLName
            // 
            this.PatientLName.Text = "Last Name";
            this.PatientLName.Width = 77;
            // 
            // patientDOB
            // 
            this.patientDOB.Text = "DOB";
            this.patientDOB.Width = 76;
            // 
            // PatientID
            // 
            this.PatientID.Text = "PatientID";
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 501);
            this.Controls.Add(this.lvPatients);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblSearchLName);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSearchFName);
            this.Controls.Add(this.lblUserName);
            this.Name = "SearchPatient";
            this.Text = "Search Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSearchFName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Label lblSearchLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.ListView lvPatients;
        private System.Windows.Forms.ColumnHeader PatientFName;
        private System.Windows.Forms.ColumnHeader PatientLName;
        private System.Windows.Forms.ColumnHeader patientDOB;
        private System.Windows.Forms.ColumnHeader PatientID;
    }
}