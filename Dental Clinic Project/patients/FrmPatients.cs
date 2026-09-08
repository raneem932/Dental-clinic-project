using Dental_Clinic_Project.patients;
using DentalClinic_BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dental_Clinic_Project
{
    public partial class FrmPatients : Form
    {
        private static DataTable _dtPatients = ClsPatientBuss.GetAllPatient();
        private DataTable _dvPatients = _dtPatients.DefaultView.ToTable(false, "PatientID", "fullName", "Gender", "Age", "DateOfBirth",
                    "phone", "Email", "Address", "Allergies", "createdAt", "remainingAmount");
        private void _refreshData()
        {
            _dtPatients = ClsPatientBuss.GetAllPatient();
            _dvPatients = _dtPatients.DefaultView.ToTable(false, "PatientID", "fullName", "Gender", "Age", "DateOfBirth",
                       "phone", "Email", "Address", "Allergies", "createdAt", "remainingAmount");
            dgvPatients.DataSource = _dvPatients;
            lblcount.Text = dgvPatients.Rows.Count.ToString();

        }
        public FrmPatients()
        {
            InitializeComponent();
        }

        private void FrmPatients_Load(object sender, EventArgs e)
        {
            txtFilter.Visible = false;
            _dtPatients = ClsPatientBuss.GetAllPatient();
            _dvPatients = _dtPatients.DefaultView.ToTable(false, "PatientID", "fullName", "Gender", "Age", "DateOfBirth",
                       "phone", "Email", "Address", "Allergies", "createdAt", "remainingAmount");
            dgvPatients.DataSource = _dvPatients;
            if (dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Columns[0].HeaderText = "ID";
                dgvPatients.Columns[0].Width = 50;

                dgvPatients.Columns[1].HeaderText = "full Name";
                dgvPatients.Columns[1].Width = 100;
                dgvPatients.Columns[2].HeaderText = "Gender";
                dgvPatients.Columns[2].Width = 70;
                dgvPatients.Columns[3].HeaderText = "Age";
                dgvPatients.Columns[3].Width = 50;
                dgvPatients.Columns[4].HeaderText = "Date Of Birth";
                dgvPatients.Columns[4].Width = 100;
                dgvPatients.Columns[5].HeaderText = "phone";
                dgvPatients.Columns[5].Width = 70;
                dgvPatients.Columns[6].HeaderText = "Email";
                dgvPatients.Columns[6].Width = 100;
                dgvPatients.Columns[7].HeaderText = "Address";
                dgvPatients.Columns[7].Width = 100;
                dgvPatients.Columns[8].HeaderText = "Allergies";
                dgvPatients.Columns[8].Width = 100;
                dgvPatients.Columns[9].HeaderText = "createdAt";
                dgvPatients.Columns[9].Width = 100;
                dgvPatients.Columns[10].HeaderText = "rmgAmount";
                dgvPatients.Columns[10].Width = 100;
                lblcount.Text = dgvPatients.Rows.Count.ToString();

            }
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cmbFilter.Text != "None");
            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (cmbFilter.Text == "ID" || cmbFilter.Text == "Age" || cmbFilter.Text == "remaining Amount")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
        }


        private void txtFilter_TextChanged(object sender, EventArgs e)
        { 
            string filterColumn = "";
            switch (cmbFilter.Text)
            {
                case "ID":
                    filterColumn = "PatientID";
                    break;
                case "Name":
                    filterColumn = "fullName";
                    break;
                case "Gender":
                    filterColumn = "Gender";
                    break;
                case "Age":
                    filterColumn = "Age";
                    break;
                case "Phone":
                    filterColumn = "phone";
                    break;
                case "Email":
                    filterColumn = "Email";
                    break;
                case "remaining Amount":
                    filterColumn = "remainingAmount";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }
            if (txtFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dvPatients.DefaultView.RowFilter = "";
                lblcount.Text = dgvPatients.Rows.Count.ToString();

                return;
            }

            if (filterColumn == "PatientID" || filterColumn == "Age" || filterColumn == "remainingAmount")
            {
              
                _dvPatients.DefaultView.RowFilter = $"[{filterColumn}]={txtFilter.Text.Trim()}";
                lblcount.Text = dgvPatients.Rows.Count.ToString();

            }
            else
            {
                _dvPatients.DefaultView.RowFilter = $"[{filterColumn}] LIKE '{txtFilter.Text.Trim()}%'";
                lblcount.Text = dgvPatients.Rows.Count.ToString();

            }

        }

        private void btnAddUpdate_Click_1(object sender, EventArgs e)
        {
            FrmAddUpdatePatient frm = new FrmAddUpdatePatient();
            frm.ShowDialog();
        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int patientID =(int) dgvPatients.CurrentRow.Cells[0].Value;
            if(MessageBox.Show("Are you sure to Delete patient :"+patientID+"?","Delete patient", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               if(ClsPatientBuss.DeletePatient(patientID))
                {
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted failed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            _refreshData();
    
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
      
        }

        private void updateToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            int patientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            FrmAddUpdatePatient frm = new FrmAddUpdatePatient(patientID);
            frm.ShowDialog();
            _refreshData();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int patientID = (int)dgvPatients.CurrentRow.Cells[0].Value;

            frmShowInfoPatient frm = new frmShowInfoPatient(patientID);
            frm.ShowDialog();
            _refreshData();
        }
    }
}

