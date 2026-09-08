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

namespace Dental_Clinic_Project.patients
{
    public partial class UctPatient : UserControl
    {

        private int _patientID = -1;
        private ClsPatientBuss _patient;

        public int patientID
        {
            get
            {
              return  _patientID;
            }
        }
        public ClsPatientBuss patient
        {
            get
            {
                return _patient;
            }
        }

        public void loadData(int patientID)
        {
            _patient = ClsPatientBuss.find(patientID);
            if (_patient == null)
            {
                MessageBox.Show("no patient with this ID ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _patientID = _patient.patientID;
            lblfirst.Text = _patient.firstName;
            lbllast.Text = _patient.lastName;
            lblPhone.Text = _patient.phone;
            lblemail.Text = _patient.email;
            lblGender.Text = _patient.gender;
            lblAddress.Text = _patient.Address;
            lblAllirgies.Text = _patient.Allergies;
lblDateOFBirth.Text=_patient.dateOfBirth.ToShortDateString();   
            lblCreatedAT.Text=_patient.CreatedAt.ToString();
            lblFullName.Text = _patient.fullName;
            lblD.Text = _patientID.ToString();
        }
        public UctPatient()
        {
            InitializeComponent();
        }

        private void hopeGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UctPatient_Load(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
