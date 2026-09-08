using DentalClinic_BussinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace Dental_Clinic_Project.users
{
    public partial class FrmUsersList : Form
    {
        private static DataTable _dtAllusers =ClsUserBuss.GetAllUsers();
        private DataTable _dvUsers = _dtAllusers.DefaultView.ToTable(false, "userID", "username", "DoctorName", "Role", "IsActive", "createdat");
        private void _refreshData()
        {
            _dtAllusers = ClsUserBuss.GetAllUsers();
            _dvUsers = _dtAllusers.DefaultView.ToTable(false, "userID", "username", "DoctorName", "Role", "IsActive", "createdat");

            dgvUsers.DataSource =_dvUsers;
            lblcount.Text = dgvUsers.Rows.Count.ToString();

        }
        public FrmUsersList()
        {
            InitializeComponent();
        }

        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            cmbfilter.Text = "None";
            txtFilter.Visible = false;
            _dtAllusers = ClsUserBuss.GetAllUsers();


            dgvUsers.DataSource = _dvUsers;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "ID";
                dgvUsers.Columns[0].Width = 20;

                dgvUsers.Columns[1].HeaderText = "user Name";
                dgvUsers.Columns[1].Width = 50;
                dgvUsers.Columns[2].HeaderText = "Dentist Name";
                dgvUsers.Columns[2].Width = 60;
                dgvUsers.Columns[3].HeaderText = "Role";
                dgvUsers.Columns[3].Width = 60;
                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 50;
                dgvUsers.Columns[5].HeaderText = "Created AT";
                dgvUsers.Columns[5].Width = 80;
                lblcount.Text = dgvUsers.Rows.Count.ToString();

            }
        }

private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn2 = "";
            switch (cmbfilter.Text)
            {
                case "ID":
                    filterColumn2 = "userID";
                    break;
                case "User Name":
                    filterColumn2 = "username";
                    break;
                case "Role":
                    filterColumn2 = "Role";
                    break;
                case "IsActive":
                    filterColumn2 = "IsActive";
                    break;
               
                default:
                    filterColumn2 = "None";
                    break;
            }
            if (txtFilter.Text.Trim() == "" || filterColumn2 == "None")
            {
                _dvUsers.DefaultView.RowFilter = "";
                lblcount.Text = dgvUsers.Rows.Count.ToString();
                return;

            }

            if (filterColumn2 == "userID")
                //in this case we deal with integer not string.
                _dvUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn2, txtFilter.Text.Trim());
           

            else
                _dvUsers.DefaultView.RowFilter = string.Format("[{0}]like '{1}%'", filterColumn2, txtFilter.Text.Trim());
           
        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cmbfilter.Text != "None"&& cmbfilter.Text != "IsActive" && cmbfilter.Text!= "Role");
            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
            cmbIsActive.Visible = (cmbfilter.Text == "IsActive");
            if (cmbIsActive.Visible)
            {
                cmbIsActive.Text = "None";
            }
            cmbRole.Visible = (cmbfilter.Text == "Role");
          
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbfilter.Text == "ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterColumn2 = "IsActive";
            string filterValue = cmbIsActive.Text;
            switch (filterValue)
            {
                case "None":
                    break;
                case "true":
                    filterValue = "1";
                    break;
                case "false":
                    filterValue = "0";
                    break;
            }
         
            if (cmbIsActive.Text == "None")
            {
                _dvUsers.DefaultView.RowFilter = "";
            }
            else
            {
                _dvUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn2, filterValue);

            }
            
        }
        

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnFilter = "Role";
            string filterValue = cmbRole.Text;
            switch (filterValue)
            {
                case " ADMIN":
                    filterValue = "ADMIN";
                    break;
                case "DOCTOR":
                    filterValue = "DOCTOR";
                    break;
                case "RECEPTIONIST":
                    filterValue = "RECEPTIONIST";
                    break;
            }
            _dvUsers.DefaultView.RowFilter = string.Format("[{0}]like '{1}%'", columnFilter, filterValue);
      
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser frm = new FrmAddUpdateUser();
            frm.ShowDialog();
            _refreshData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUsers.CurrentRow.Cells[0].Value;
            FrmAddUpdateUser frm = new FrmAddUpdateUser(id);
            frm.ShowDialog();
            _refreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure to Delete user??? :" + UserID + "?", "Delete user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsUserBuss.deleteUser(UserID))
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

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            UserCard frm = new UserCard(UserID);
            frm.ShowDialog();
        }
    }
}
