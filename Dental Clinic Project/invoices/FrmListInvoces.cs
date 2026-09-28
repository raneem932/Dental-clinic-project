using DentalClinic_BussinessLayer;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Project.invoices
{
    
    public partial class FrmListInvoces : Form
    {
        private static DataTable _dtinvoices = ClsInvoicesBuss.GetAllInvoices();
        private DataTable _dvinvoices = _dtinvoices.DefaultView.ToTable(false, "invoiceID", "PatientName", "DentistName", "visitDate", "invoiceDate", "totalAmount",
            "paidAmount", "remainingAmount");
        
        public FrmListInvoces()
        {
            InitializeComponent();
        }
        private void _refreshData()
        {
            _dtinvoices = ClsInvoicesBuss.GetAllInvoices();
            _dvinvoices= _dtinvoices.DefaultView.ToTable(false, "invoiceID", "PatientName", "DentistName", "visitDate", "invoiceDate", "totalAmount",
            "paidAmount", "remainingAmount");
            dgvinvoiceslist.DataSource = _dvinvoices;
            if (dgvinvoiceslist.Rows.Count > 0)
            {
                dgvinvoiceslist.Columns[0].HeaderText = "invoice ID";
                dgvinvoiceslist.Columns[0].Width = 50;
                dgvinvoiceslist.Columns[1].HeaderText = "Patient Name";
                dgvinvoiceslist.Columns[1].Width = 70;
                dgvinvoiceslist.Columns[2].HeaderText = "Dentist Name";
                dgvinvoiceslist.Columns[2].Width = 70;
                dgvinvoiceslist.Columns[3].HeaderText = "Visit Date";
                dgvinvoiceslist.Columns[3].Width = 70;
                dgvinvoiceslist.Columns[4].HeaderText = "invoice Date";
                dgvinvoiceslist.Columns[4].Width = 70;
                dgvinvoiceslist.Columns[5].HeaderText = "totalAmount";
                dgvinvoiceslist.Columns[5].Width = 70;
                dgvinvoiceslist.Columns[6].HeaderText = "paid Amount";
                dgvinvoiceslist.Columns[6].Width = 70;
                dgvinvoiceslist.Columns[7].HeaderText = "remainning Amount";
                dgvinvoiceslist.Columns[7].Width = 90;
                lblcount.Text = dgvinvoiceslist.Rows.Count.ToString();
            }
        }
        private void FrmListInvoces_Load(object sender, EventArgs e)
        {
            _refreshData();
            cmbfilter.Text = "None";
            dtpInvoice.Visible = false;
        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _refreshData();
            txtFilter.Visible = (cmbfilter.Text != "None" && cmbfilter.Text != "invoice Date");
            cmbdateFilter.Visible = (cmbfilter.Text == "invoice Date");
            if (txtFilter.Visible)
            {
                txtFilter.Focus();
                txtFilter.Text = "";
            }
        }

        private void cmbdateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpInvoice.Visible = (cmbdateFilter.Text == "Specific Date");
            

            if (cmbdateFilter.Text =="None" || cmbdateFilter.Text =="")
            {
                dgvinvoiceslist.DataSource = _dvinvoices;
            }
            else
            {
                string filterValue = cmbdateFilter.Text;
                switch (filterValue)
                {
                    case "None":
                        _refreshData();
                        break;
                    case "Today":
                        dgvinvoiceslist.DataSource = ClsInvoicesBuss.getAllInvoicestoday();
                        break;
                    case "this month":
                        dgvinvoiceslist.DataSource = ClsInvoicesBuss.getAllInvoicesthismonth();
                        break;
                    case "this year":
                        dgvinvoiceslist.DataSource = ClsInvoicesBuss.getAllInvoicesthisyear();

                        break;
                    case "Specific Date":

                        break;
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn2 = "";
            switch (cmbfilter.Text)
            {
                case "invoice ID":
                    filterColumn2 = "invoiceID";
                    break;
                case "Patient Name":
                    filterColumn2 = "PatientName";
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
                _dvinvoices.DefaultView.RowFilter = "";
                _refreshData();
                lblcount.Text = dgvinvoiceslist.Rows.Count.ToString();
                return;

            }

            if (filterColumn2 == "invoiceID")
            {
                //in this case we deal with integer not string.
                _dvinvoices.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn2, txtFilter.Text.Trim());
            }

            else
            {
                _dvinvoices.DefaultView.RowFilter = string.Format("[{0}]like '{1}%'", filterColumn2, txtFilter.Text.Trim());
            }
        }

        private void dtpInvoice_ValueChanged(object sender, EventArgs e)
        {

            dgvinvoiceslist.DataSource = ClsInvoicesBuss.getAllInvoicesAtspecificdate(dtpInvoice.Value);

        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbfilter.Text == "invoice ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
                e.Handled = false;
        }
    }
}
