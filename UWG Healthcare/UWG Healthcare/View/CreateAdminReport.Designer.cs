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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new UWG_Healthcare.TestDataSet();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dtReportStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtReportEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_mostPerformedTestsDuringDatesTableAdapter1 = new UWG_Healthcare.TestDataSetTableAdapters.sp_mostPerformedTestsDuringDatesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "sp_mostPerformedTestsDuringDates";
            this.bindingSource1.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(13, 9);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(181, 23);
            this.lblUserName.TabIndex = 19;
            this.lblUserName.Text = "UserNamePlaceHolder";
            // 
            // dtReportStart
            // 
            this.dtReportStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportStart.Location = new System.Drawing.Point(114, 94);
            this.dtReportStart.Name = "dtReportStart";
            this.dtReportStart.Size = new System.Drawing.Size(117, 30);
            this.dtReportStart.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "End Date";
            // 
            // dtReportEnd
            // 
            this.dtReportEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportEnd.Location = new System.Drawing.Point(336, 95);
            this.dtReportEnd.Name = "dtReportEnd";
            this.dtReportEnd.Size = new System.Drawing.Size(117, 30);
            this.dtReportEnd.TabIndex = 23;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(474, 93);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(145, 36);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Run Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MostPerformedData";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UWG_Healthcare.View.MostPerformedTests.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 148);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1413, 531);
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
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(889, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = " Show the most performed tests during the specified period of time for the tests " +
    "that were performed at least twice.";
            // 
            // CreateAdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 691);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtReportEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtReportStart);
            this.Controls.Add(this.lblUserName);
            this.Name = "CreateAdminReport";
            this.Text = "Run Admin Report";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
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
    }
}