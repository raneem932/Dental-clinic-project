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
using System.Windows.Documents;
using System.Windows.Forms;

namespace Dental_Clinic_Project.visit_treatments
{
    
    public partial class frmVisitsTreatments : Form
    {
        private static DataTable _dtVisitTreatment = ClsVisitTreatmentsBuss.GetAllVisitsWithTreatments();
        private DataTable _dvVisitTreatments = _dtVisitTreatment.DefaultView.ToTable(false, "VisitID", "patientName", "DentistName", "visitDate", "Treatments", "Cost");
        
        public frmVisitsTreatments()
        {
            InitializeComponent();
        }
        private void _refreshData()
        {


        _dtVisitTreatment = ClsVisitTreatmentsBuss.GetAllVisitsWithTreatments();
         _dvVisitTreatments = _dtVisitTreatment.DefaultView.ToTable(false, "VisitID", "patientName", "DentistName", "visitDate", "Treatments", "Cost");
            dgvVisitstreatments.DataSource = _dvVisitTreatments;
            lblcount.Text = dgvVisitstreatments.Rows.Count.ToString();
            if (dgvVisitstreatments.Rows.Count > 0)
            {
                dgvVisitstreatments.Columns[0].HeaderText = "ID";
                dgvVisitstreatments.Columns[0].Width = 20;
                dgvVisitstreatments.Columns[1].HeaderText = "Patient Name";
                dgvVisitstreatments.Columns[1].Width = 70;
                dgvVisitstreatments.Columns[2].HeaderText = "Dentist Name";
                dgvVisitstreatments.Columns[2].Width = 70;
                dgvVisitstreatments.Columns[3].HeaderText = "Visit Date";
                dgvVisitstreatments.Columns[3].Width = 70;
                dgvVisitstreatments.Columns[4].HeaderText = "treatments";
                dgvVisitstreatments.Columns[4].Width = 200;
                dgvVisitstreatments.Columns[5].HeaderText = "cost";
                dgvVisitstreatments.Columns[5].Width = 50;
                lblcount.Text = dgvVisitstreatments.Rows.Count.ToString();

            }
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
        private void frmVisitsTreatments_Load(object sender, EventArgs e)
        {
            _refreshData();
            cmbfilter.Text = "None";
            dateTimePacker.Visible = false;
            cmbdateFilter.Visible = false;
            txtFilter.Visible = false;
            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(btnAddvisit, "add new visit with treatments");
        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cmbfilter.Text != "Visit Date"&& cmbfilter.Text != "None");
            cmbdateFilter.Visible = (cmbfilter.Text == "Visit Date" && cmbfilter.Text != "None");
            
        }

        private void cmbdateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePacker.Visible = (cmbdateFilter.Text == "Specific Date");
            string filterColumn2 = "";

            if (cmbdateFilter.Text == "None" || cmbdateFilter.Text == "")
            {
                dgvVisitstreatments.DataSource = _dvVisitTreatments;
            }
            else
            {
                switch (cmbdateFilter.Text)
                {
                    case "None":
                        break;
                    case "Today":
                        dgvVisitstreatments.DataSource = ClsVisitTreatmentsBuss.GetallVisitstreatmentsToday();
                        break;
                    case "this month":
                        dgvVisitstreatments.DataSource = ClsVisitTreatmentsBuss.GetallVisitstreatmentsthisMonth();
                        break;
                    case "this year":
                        dgvVisitstreatments.DataSource = ClsVisitTreatmentsBuss.GetallVisitstreatmentsthisYear();

                        break;
                 
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn2 = "";
            switch (cmbfilter.Text)
            {
                case "ID":
                    filterColumn2 = "VisitID";
                    break;
                case "Patient Name":
                    filterColumn2 = "patientName";
                    break;
                case "Dentist Name":
                    filterColumn2 = "DentistName";
                    break;
                default:
                    filterColumn2 = "None";
                    break;
            }
            if (txtFilter.Text.Trim() == "" || filterColumn2 == "None")
            {
                _dvVisitTreatments.DefaultView.RowFilter = "";
                lblcount.Text = dgvVisitstreatments.Rows.Count.ToString();
                return;

            }
            if (filterColumn2 == "VisitID")
                //in this case we deal with integer not string.
                _dvVisitTreatments.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn2, txtFilter.Text.Trim());

            else
                _dvVisitTreatments.DefaultView.RowFilter = string.Format("[{0}]like '{1}%'", filterColumn2, txtFilter.Text.Trim());
        }

        private void dateTimePacker_ValueChanged(object sender, EventArgs e)
        {
            dgvVisitstreatments.DataSource = ClsVisitTreatmentsBuss.GetallVisitstreatmentsInSpecificDate(dateTimePacker.Value);

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            FrmAddUpdateVisit frm = new FrmAddUpdateVisit();
            frm.ShowDialog();
            _refreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int visitID = (int)dgvVisitstreatments.CurrentRow.Cells[0].Value;
            if(MessageBox.Show("Are you sure to Delete Visit :" + visitID + "?", "Delete visit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

            }
        }
    }
}
