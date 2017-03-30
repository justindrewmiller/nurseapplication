namespace UWG_Healthcare.View
{
    partial class Menu
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnOrderTests = new System.Windows.Forms.Button();
            this.btnRecordResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Location = new System.Drawing.Point(61, 73);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(202, 23);
            this.btnCreateAppointment.TabIndex = 0;
            this.btnCreateAppointment.Text = "Create Appointment";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(61, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Patients";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(61, 197);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(202, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register New Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(241, 415);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // btnOrderTests
            // 
            this.btnOrderTests.Location = new System.Drawing.Point(61, 254);
            this.btnOrderTests.Name = "btnOrderTests";
            this.btnOrderTests.Size = new System.Drawing.Size(202, 23);
            this.btnOrderTests.TabIndex = 6;
            this.btnOrderTests.Text = "Order Tests";
            this.btnOrderTests.UseVisualStyleBackColor = true;
            // 
            // btnRecordResults
            // 
            this.btnRecordResults.Location = new System.Drawing.Point(61, 314);
            this.btnRecordResults.Name = "btnRecordResults";
            this.btnRecordResults.Size = new System.Drawing.Size(202, 23);
            this.btnRecordResults.TabIndex = 7;
            this.btnRecordResults.Text = "Record Test Results";
            this.btnRecordResults.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.btnRecordResults);
            this.Controls.Add(this.btnOrderTests);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreateAppointment);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnOrderTests;
        private System.Windows.Forms.Button btnRecordResults;
    }
}