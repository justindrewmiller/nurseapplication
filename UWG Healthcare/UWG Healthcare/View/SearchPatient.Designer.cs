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
            this.cboPatients = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(16, 11);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(181, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // lblSearchFName
            // 
            this.lblSearchFName.AutoSize = true;
            this.lblSearchFName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFName.Location = new System.Drawing.Point(16, 78);
            this.lblSearchFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchFName.Name = "lblSearchFName";
            this.lblSearchFName.Size = new System.Drawing.Size(92, 23);
            this.lblSearchFName.TabIndex = 1;
            this.lblSearchFName.Text = "First Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(17, 151);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(45, 23);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(126, 75);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(211, 30);
            this.txtFName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(126, 189);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(262, 293);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.Location = new System.Drawing.Point(126, 293);
            this.btnGoTo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(128, 39);
            this.btnGoTo.TabIndex = 8;
            this.btnGoTo.Text = "Select Patient";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // lblSearchLName
            // 
            this.lblSearchLName.AutoSize = true;
            this.lblSearchLName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLName.Location = new System.Drawing.Point(17, 113);
            this.lblSearchLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchLName.Name = "lblSearchLName";
            this.lblSearchLName.Size = new System.Drawing.Size(91, 23);
            this.lblSearchLName.TabIndex = 9;
            this.lblSearchLName.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(126, 113);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(211, 30);
            this.txtLName.TabIndex = 4;
            // 
            // dtDOB
            // 
            this.dtDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB.Location = new System.Drawing.Point(126, 151);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(211, 30);
            this.dtDOB.TabIndex = 5;
            this.dtDOB.Value = new System.DateTime(2017, 4, 9, 2, 20, 37, 0);
            // 
            // cboPatients
            // 
            this.cboPatients.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatients.FormattingEnabled = true;
            this.cboPatients.Location = new System.Drawing.Point(126, 254);
            this.cboPatients.Margin = new System.Windows.Forms.Padding(4);
            this.cboPatients.Name = "cboPatients";
            this.cboPatients.Size = new System.Drawing.Size(328, 31);
            this.cboPatients.TabIndex = 7;
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.cboPatients);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cboPatients;
    }
}