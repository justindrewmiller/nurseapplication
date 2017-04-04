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
    public partial class CreateAppointment : Form
    {
        public UserInfo userID;
        public CreateAppointment(UserInfo info)
        {
            InitializeComponent();
        }
    }
}
