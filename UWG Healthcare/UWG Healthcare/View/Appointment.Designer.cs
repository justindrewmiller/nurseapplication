namespace UWG_Healthcare.View
{
    partial class Appointment
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
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(27, 59);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(123, 56);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(203, 20);
            this.txtPatientName.TabIndex = 1;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(21, 109);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(87, 13);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Attending Doctor";
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(123, 106);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.ReadOnly = true;
            this.txtDoctor.Size = new System.Drawing.Size(203, 20);
            this.txtDoctor.TabIndex = 3;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(21, 164);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(77, 13);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Date and Time";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(48, 217);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Reason";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 214);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(203, 109);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(251, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 424);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
    }
}