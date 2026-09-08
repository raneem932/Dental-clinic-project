using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Project.patients
{
    public partial class frmShowInfoPatient : Form
    {
        private int _patientID;
        public frmShowInfoPatient(int patientID)
        {
            _patientID=patientID;
            InitializeComponent();
        }

        private void ShowInfoPatient_Load(object sender, EventArgs e)
        {
            uctPatient1.loadData(_patientID);
        }

        private void icnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uctPatient1_Load(object sender, EventArgs e)
        {

        }
    }
}
