using Dental_Clinic_Project.global;
using DentalClinic_BussinessLayer;
using Guna.UI2.WinForms;
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
    public partial class FrmAddUpdatePatient : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private enum enMode { addNew=0,update=1}
        private enMode Mode;
        ClsPatientBuss _patient;
        private int _patientID=-1;
        public FrmAddUpdatePatient()
        {
            Mode=enMode.addNew;
            _patient = new ClsPatientBuss();
            InitializeComponent();
        }
        public FrmAddUpdatePatient(int patientID)
        {
            Mode = enMode.update;
            _patientID = patientID;
            
            InitializeComponent();
            
        }
        private void _defualtData()
        {
            if (Mode == enMode.addNew)
            {
                lblName.Text = "Add Patient";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtAddress.Text = "";
                txtAllergies.Text = "";
                rdMale.Checked = true;
            }
            if (Mode == enMode.update)
            {
                lblName.Text = "Update Patient";
                _patient = ClsPatientBuss.find(_patientID);
                if (_patient == null)
                {
                    MessageBox.Show("no patient with ID" + _patientID, "patient not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                txtID.Enabled = false;
                txtFirstName.Text = _patient.firstName;
                txtLastName.Text = _patient.lastName;
                txtPhone.Text = _patient.phone.ToString();
                txtID.Text = _patient.patientID.ToString();
                txtEmail.Text = _patient.email;
                txtAllergies.Text = _patient.Allergies;
                txtAddress.Text = _patient.Address;
                dtpdateOfBirth.Value = _patient.dateOfBirth;
                if (_patient.gender == "male")
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }

            }
        } 
        private void icnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _patient.firstName = txtFirstName.Text.Trim();
            _patient.lastName = txtLastName.Text.Trim();
            _patient.email = txtEmail.Text.Trim();
            _patient.phone=txtPhone.Text.Trim();    
            _patient.Address=txtAddress.Text.Trim();
            _patient.Allergies = txtAllergies.Text.Trim();
            _patient.dateOfBirth = dtpdateOfBirth.Value;
            if (rdFemale.Checked == true)
            {
                _patient.gender = "female";
            }
            else
            {
                _patient.gender = "male";

            }
            if (_patient.save())
            {
           
                lblName.Text = "update Patient";
                Mode = enMode.update;
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = _patient.patientID.ToString();
            }
            
            else
            {
                MessageBox.Show("error saved Data", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtID.Enabled = false;
            DataBack?.Invoke(this, _patient.patientID);
        }

        private void validateImptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "this field is required");
            }
            else
            {
                errorProvider1.SetError(temp,null);

            }
        }

        private void FrmAddUpdatePatient_Load(object sender, EventArgs e)
        {
            _defualtData();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;
            if (!validation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "invalid email address format");
            }
            else
            {
                errorProvider1.SetError(txtEmail,null);

            }
        }

     
    }
}
