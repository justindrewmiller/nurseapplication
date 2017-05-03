namespace UWG_Healthcare.View
{
    partial class CreateAdminReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_mostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new UWG_Healthcare.TestDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblUserName = new System.Windows.Forms.Label();
            this.dtReportStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtReportEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_mostPerformedTestsDuringDatesTableAdapter1 = new UWG_Healthcare.TestDataSetTableAdapters.sp_mostPerformedTestsDuringDatesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPerformedTestsDuringDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_mostPerformedTestsDuringDatesBindingSource
            // 
            this.sp_mostPerformedTestsDuringDatesBindingSource.DataMember = "sp_mostPerformedTestsDuringDates";
            this.sp_mostPerformedTestsDuringDatesBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "sp_mostPerformedTestsDuringDates";
            this.bindingSource1.DataSource = this.testDataSet;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(10, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 19);
            this.lblUserName.TabIndex = 19;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // dtReportStart
            // 
            this.dtReportStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportStart.Location = new System.Drawing.Point(86, 76);
            this.dtReportStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtReportStart.Name = "dtReportStart";
            this.dtReportStart.Size = new System.Drawing.Size(89, 26);
            this.dtReportStart.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "End Date";
            // 
            // dtReportEnd
            // 
            this.dtReportEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportEnd.Location = new System.Drawing.Point(252, 77);
            this.dtReportEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtReportEnd.Name = "dtReportEnd";
            this.dtReportEnd.Size = new System.Drawing.Size(89, 26);
            this.dtReportEnd.TabIndex = 23;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(356, 76);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 29);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Run Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TestDataSetAdmin";
            reportDataSource1.Value = this.sp_mostPerformedTestsDuringDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UWG_Healthcare.View.AdminTestReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 120);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1060, 432);
            this.reportViewer1.TabIndex = 25;
            // 
            // sp_mostPerformedTestsDuringDatesTableAdapter1
            // 
            this.sp_mostPerformedTestsDuringDatesTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(714, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = " Show the most performed tests during the specified period of time for the tests " +
    "that were performed at least twice.";
            // 
            // CreateAdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtReportEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtReportStart);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateAdminReport";
            this.Text = "Run Admin Report";
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPerformedTestsDuringDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DateTimePicker dtReportStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtReportEnd;
        private System.Windows.Forms.Button btnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private TestDataSet testDataSet;
        private TestDataSetTableAdapters.sp_mostPerformedTestsDuringDatesTableAdapter sp_mostPerformedTestsDuringDatesTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sp_mostPerformedTestsDuringDatesBindingSource;
    }
}