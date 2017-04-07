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
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
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
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(89, 78);
            this.lblSearchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(56, 23);
            this.lblSearchName.TabIndex = 1;
            this.lblSearchName.Text = "Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(96, 125);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(45, 23);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(153, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(153, 125);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(211, 30);
            this.txtDOB.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(203, 172);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(359, 354);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGoTo
            // 
            this.btnGoTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.Location = new System.Drawing.Point(214, 354);
            this.btnGoTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(128, 40);
            this.btnGoTo.TabIndex = 7;
            this.btnGoTo.Text = "Select Patient";
            this.btnGoTo.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(20, 218);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(439, 128);
            this.txtResults.TabIndex = 8;
            this.txtResults.Text = "";
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 413);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchPatient";
            this.Text = "Search Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.RichTextBox txtResults;
    }
}