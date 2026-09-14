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
using System.Diagnostics.Contracts;
using ControlzEx.Standard;
using Guna.UI2.WinForms;
using Dental_Clinic_Project.global;

namespace Dental_Clinic_Project.Dentists
{
    public partial class frmAddUpdateDentist : Form
    {

        public delegate void DataBackEventHandler(object sender, int DentisiID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private int _DentistID = -1;
        private ClsDentistBuss _dentist;
        private enum enMode {AddNew=0,Update=1}
        enMode mode = enMode.AddNew;
        public frmAddUpdateDentist()
        {
            mode = enMode.AddNew;
            _dentist = new ClsDentistBuss();
            InitializeComponent();
        }
        public frmAddUpdateDentist(int dentistID)
        {
            _DentistID = dentistID;
            mode = enMode.Update;
            InitializeComponent();

        }
        private void _fillspecializationInCombobox()
        {
            DataTable spicializationDT = clsSpecializationsBuss.GetAllSpecia();
            foreach (DataRow row in spicializationDT.Rows)
            {
                cmbSpec.Items.Add(row["specializationName"]);
            }
        }

        private void _defualtData()
        {
            _fillspecializationInCombobox();
            if (mode == enMode.AddNew)
            {
                
                txtID.Text = "N/A";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                cmbStattus.SelectedIndex=0;
                cmbSpec.SelectedIndex=1;
                txtPhone.Text = "";
            }
            else
            {
                lblName.Text = "Update Dentist";
                _loadData();
                txtID.Enabled = false;
            }
        }
        private void _loadData()
        {
            _dentist = ClsDentistBuss.find(_DentistID);
            if(_dentist!=null)
            {
                txtID.Text =_dentist.dintistID.ToString();
                txtFirstName.Text =_dentist.FirstName;
                txtLastName.Text =_dentist.LastName;
                txtEmail.Text =_dentist.email;
                cmbStattus.Text =_dentist.status;
                cmbSpec.Text =clsSpecializationsBuss.find(_dentist.specializationID).specializationName;
                txtPhone.Text =_dentist.phone;
            }
            else
            {
                MessageBox.Show("no Dentist with ID" + _DentistID, "dentist not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        private void frmAddUpdateDentist_Load(object sender, EventArgs e)
        {
            _defualtData();

        }

        private void Imptytxt_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "this field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
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
                errorProvider1.SetError(txtEmail, null);

            }
        }

        private void icnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _dentist.FirstName = txtFirstName.Text.Trim();
            _dentist.LastName = txtLastName.Text.Trim();
            _dentist.email = txtEmail.Text.Trim();
            _dentist.phone=txtPhone.Text.Trim();
            _dentist.status = cmbStattus.Text;
            _dentist.specializationID = clsSpecializationsBuss.find(cmbSpec.Text).specializationID;
            _dentist.hireDate = dtphireDate.Value;
            if (_dentist.save())
            {
                lblName.Text = "update Dentist";
                mode = enMode.Update;
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text =_dentist.dintistID.ToString();
            }

            else
            {
                MessageBox.Show("error saved " +
                    "Data", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtID.Enabled = false;
            DataBack?.Invoke(this,_dentist.dintistID);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
