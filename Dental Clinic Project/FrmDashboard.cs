using DentalClinic_BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Project
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void hopeGroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblnumber.Text = ClsAppointmentBuss.NumberOfTodaysAppointment().ToString();
            lblTotalPatients.Text = ClsPatientBuss.totalPatients().ToString();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
