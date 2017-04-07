namespace UWG_Healthcare.View
{
    partial class MenuScreen
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
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnOrderTests = new System.Windows.Forms.Button();
            this.btnRecordResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAppointment.Location = new System.Drawing.Point(46, 62);
            this.btnCreateAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(269, 39);
            this.btnCreateAppointment.TabIndex = 0;
            this.btnCreateAppointment.Text = "Create Appointment";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(46, 109);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(269, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Patients";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(46, 153);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(269, 36);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register New Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(17, 16);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(181, 23);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // btnOrderTests
            // 
            this.btnOrderTests.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderTests.Location = new System.Drawing.Point(46, 197);
            this.btnOrderTests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderTests.Name = "btnOrderTests";
            this.btnOrderTests.Size = new System.Drawing.Size(269, 40);
            this.btnOrderTests.TabIndex = 6;
            this.btnOrderTests.Text = "Order Tests";
            this.btnOrderTests.UseVisualStyleBackColor = true;
            this.btnOrderTests.Click += new System.EventHandler(this.btnOrderTests_Click);
            // 
            // btnRecordResults
            // 
            this.btnRecordResults.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordResults.Location = new System.Drawing.Point(46, 245);
            this.btnRecordResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecordResults.Name = "btnRecordResults";
            this.btnRecordResults.Size = new System.Drawing.Size(269, 33);
            this.btnRecordResults.TabIndex = 7;
            this.btnRecordResults.Text = "Record Test Results";
            this.btnRecordResults.UseVisualStyleBackColor = true;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 308);
            this.Controls.Add(this.btnRecordResults);
            this.Controls.Add(this.btnOrderTests);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreateAppointment);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnOrderTests;
        private System.Windows.Forms.Button btnRecordResults;
    }
}