using DentalClinic_BussinessLayer;
using MahApps.Metro.Controls;
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
using System.Windows.Media;

namespace Dental_Clinic_Project.Appointments
{
    public partial class frmListAppointments : Form
    {
        private static DataTable _dtAllApointmnents = ClsAppointmentBuss.GetAllAppointments();
        private DataTable _dvAppointments = _dtAllApointmnents.DefaultView.ToTable(false, "appointmentID", "DentistName", "PatientName", "AppointmentDate", "startTime", "endTime", "status", "notes");
        private void _refreshData()
        {
            _dtAllApointmnents = ClsAppointmentBuss.GetAllAppointments();
            _dvAppointments = _dtAllApointmnents.DefaultView.ToTable(false, "appointmentID", "DentistName", "PatientName", "AppointmentDate", "startTime", "endTime", "status", "notes");
            dgvAppoin.DataSource = _dvAppointments;
            lblcount.Text = dgvAppoin.Rows.Count.ToString();
        }
        public frmListAppointments()
        {
            InitializeComponent();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbfilter.Text == "ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
                e.Handled = false;
        }
        private void frmListAppointments_Load(object sender, EventArgs e)
        {
            dateTimePacker.Visible = false;
            cmbfilter.Text = "None";
            _dtAllApointmnents = ClsAppointmentBuss.GetAllAppointments();
            dgvAppoin.DataSource = _dvAppointments;
            if (dgvAppoin.Rows.Count > 0)
            {
                dgvAppoin.Columns[0].HeaderText = "ID";
                dgvAppoin.Columns[0].Width = 20;

                dgvAppoin.Columns[1].HeaderText = "Dentist Name";
                dgvAppoin.Columns[1].Width = 70;
                dgvAppoin.Columns[2].HeaderText = "Patient Name";
                dgvAppoin.Columns[2].Width = 70;
                dgvAppoin.Columns[3].HeaderText = "Appointment Date";
                dgvAppoin.Columns[3].Width = 70;
                dgvAppoin.Columns[4].HeaderText = "start Time";
                dgvAppoin.Columns[4].Width = 50;
                dgvAppoin.Columns[5].HeaderText = "end Time";
                dgvAppoin.Columns[5].Width = 50;
                dgvAppoin.Columns[6].HeaderText = "status";
                dgvAppoin.Columns[6].Width = 50;
                dgvAppoin.Columns[7].HeaderText = "notes";
                dgvAppoin.Columns[7].Width = 200;
                lblcount.Text = dgvAppoin.Rows.Count.ToString();

            }

        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _refreshData();
            txtFilter.Visible = (cmbfilter.Text != "None" && cmbfilter.Text != "status" && cmbfilter.Text != "Appointment Date");
            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
            cmbIsActive.Visible = (cmbfilter.Text == "status");
            cmbdateFilter.Visible = (cmbfilter.Text == "Appointment Date");
        }
      
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            string filterColumn2 = "";
            switch (cmbfilter.Text)
            {
                case "ID":
                    filterColumn2 = "appointmentID";
                    break;
                case "Dentist Name":
                    filterColumn2 = "DentistName";
                    break;
                case "status":
                    filterColumn2 = "status";
                    break;
                case "Patient Name":
                    filterColumn2 = "PatientName";
                    break;
                case "Appointment Date":
                    filterColumn2 = "AppointmentDate";
                    break;
                default:
                    filterColumn2 = "None";
                    break;
            }
            if (txtFilter.Text.Trim() == "" || filterColumn2 == "None")
            {
                _dvAppointments.DefaultView.RowFilter = "";
                lblcount.Text = dgvAppoin.Rows.Count.ToString();
                return;

            }

            if (filterColumn2 == "appointmentID")
                //in this case we deal with integer not string.
                _dvAppointments.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn2, txtFilter.Text.Trim());
            
            else
                _dvAppointments.DefaultView.RowFilter = string.Format("[{0}]like '{1}%'", filterColumn2, txtFilter.Text.Trim());
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterColumn2 = "status";
            string filterValue = cmbIsActive.Text;
            switch (filterValue)
            {
                case "None":
                    break;
                case "scheduled":
                    filterValue = "scheduled";
                    break;
                case "completed":
                    filterValue = "completed";
                    break;
                case "cancelled":
                    filterValue = "cancelled";
                    break;
            }

            if (cmbIsActive.Text == "None" || cmbIsActive.Text.Trim() == "")
            {
                _dvAppointments.DefaultView.RowFilter = "";
            }
            else
            {
                _dvAppointments.DefaultView.RowFilter = string.Format("[{0}]like '{1}%'", filterColumn2, filterValue);

            }
        }

        private void cmbdateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePacker.Visible = cmbdateFilter.Text == "Specific Date";
            string filterColumn2 = "Appointment Date";
           
                    if (cmbdateFilter.Text == "None" || cmbdateFilter.Text== "")
                    {
                dgvAppoin.DataSource = _dvAppointments;
                    }
            else
            {
                string filterValue = cmbdateFilter.Text;
                switch (filterValue)
                {
                    case "None":
                        break;
                    case "Today":
                        dgvAppoin.DataSource = ClsAppointmentBuss.GetAllTodayAppointments();
                        break;
                    case "this month":
                        dgvAppoin.DataSource = ClsAppointmentBuss.GetAllAppointmentsthisMonth();
                        break;
                    case "this year":
                        dgvAppoin.DataSource = ClsAppointmentBuss.GetAllAppointmentsthisYear();

                        break;
                    case "Specific Date":
                      
                      //  dgvAppoin.DataSource = ClsAppointmentBuss.getAllAppointmentsInSpecificDate(dateTimePicker1.Value);
                        break;
                }
            }

            
        }

     
        private void dateTimePacker_ValueChanged(object sender, EventArgs e)
        {
            dgvAppoin.DataSource = ClsAppointmentBuss.getAllAppointmentsInSpecificDate(dateTimePacker.Value);

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            frmAddNewAppoin frm = new frmAddNewAppoin();
            frm.ShowDialog();
            _refreshData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id =(int )dgvAppoin.CurrentRow.Cells[0].Value;
            frmAddNewAppoin frm = new frmAddNewAppoin(id);
            frm.ShowDialog();
            _refreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvAppoin.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure to Delete Appointment :" + id + "?", "Delete Appointment", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsAppointmentBuss.deleteAppointment(id))
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
            int id = (int)dgvAppoin.CurrentRow.Cells[0].Value;
            FrmAppointmentCard frm = new FrmAppointmentCard(id);
            frm.ShowDialog();
        }
    }
}
