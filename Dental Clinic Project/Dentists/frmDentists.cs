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


namespace Dental_Clinic_Project.Dentists
{
    public partial class frmDentists : Form
    {
        private static DataTable _dtAllDentists = ClsDentistBuss.GetAllDentists();
        private DataTable _dvDentists = _dtAllDentists.DefaultView.ToTable(false,"DentistID", "fullName", "phone", "Email", "HirDate", "status",
                 "specializationName");

        public frmDentists()
        {
            InitializeComponent();
        }
        private void _refreshData()
        {
            _dtAllDentists = ClsDentistBuss.GetAllDentists();
          _dvDentists = _dtAllDentists.DefaultView.ToTable(false,"DentistID","fullName", "phone", "Email", "HirDate", "status",
                "specializationName");

            dgvDent.DataSource = _dvDentists;
            lblcount.Text = dgvDent.Rows.Count.ToString();

        }
        private void frmDentists_Load(object sender, EventArgs e)
        {
            txtFilter.Visible = false;
            _dtAllDentists = ClsDentistBuss.GetAllDentists();
       

            dgvDent.DataSource = _dvDentists;
            
            if (dgvDent.Rows.Count > 0)
            {
                dgvDent.Columns[0].HeaderText = "DentistID";
                dgvDent.Columns[0].Width = 20;

                dgvDent.Columns[1].HeaderText = "full Name";
                dgvDent.Columns[1].Width =50;
                dgvDent.Columns[2].HeaderText = "phone";
                dgvDent.Columns[2].Width = 60;
                dgvDent.Columns[3].HeaderText = "Email";
                dgvDent.Columns[3].Width = 60;
                dgvDent.Columns[4].HeaderText = "Hire Date";
                dgvDent.Columns[4].Width =50;
                dgvDent.Columns[5].HeaderText = "Status";
                dgvDent.Columns[5].Width = 30;
                dgvDent.Columns[6].HeaderText = "specialization Name";
                dgvDent.Columns[6].Width =200;
                lblcount.Text = dgvDent.Rows.Count.ToString();

            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn2 = "";
            switch (cmbfilter.Text)
            {
                case "DentistID":
                    filterColumn2 = "DentistID";
                    break;
                case "full Name":
                    filterColumn2 = "fullName";
                    break;
                case "status":
                    filterColumn2 = "status";
                    break;
                case "specialization Name":
                    filterColumn2 = "specializationName";
                    break;
                default:
                    filterColumn2 = "None";
                    break;
            }
            if (txtFilter.Text.Trim() == "" || filterColumn2 == "None")
            {
                _dvDentists.DefaultView.RowFilter = "";
                lblcount.Text = dgvDent.Rows.Count.ToString();
                return;
           
            }

            if (filterColumn2 == "DentistID")
                //in this case we deal with integer not string.
                _dvDentists.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn2, txtFilter.Text.Trim());

            else
                _dvDentists.DefaultView.RowFilter = string.Format("[{0}]like '{1}%'", filterColumn2, txtFilter.Text.Trim());      
        }

        private void cmbfilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilter.Visible = (cmbfilter.Text != "None");
            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter .Focus();
            }
        }

     

        private void txtFilter_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cmbfilter.Text == "ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
        }
    }
}
