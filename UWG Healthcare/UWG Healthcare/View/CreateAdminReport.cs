using HealthcareData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWG_Healthcare.View
{
    public partial class CreateAdminReport : Form
    {
        public CreateAdminReport(UserInfo info)
        {
            InitializeComponent();
            lblUserName.Text = info.userID;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtReportStart.Value.Date, dtReportEnd.Value.Date) > 0)
            {
                MessageBox.Show("Start date must not be before end date");
                return;
            }
            else if (dtReportStart.Value == null || dtReportEnd.Value == null)
            {
                MessageBox.Show("You must enter a start and end date");
                return;
            }
            else
            {
                this.GetReport();
            }

        }

        private void GetReport()
        {

            this.sp_mostPerformedTestsDuringDatesTableAdapter1.Fill(this.testDataSet.sp_mostPerformedTestsDuringDates, dtReportStart.Value.Date, dtReportEnd.Value.Date);
            this.reportViewer1.RefreshReport();
        }

        private void CreateAdminReport_Load(object sender, EventArgs e)
        {

        }
    }
}
