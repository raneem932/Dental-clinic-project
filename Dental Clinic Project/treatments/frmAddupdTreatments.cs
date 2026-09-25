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

namespace Dental_Clinic_Project.treatments
{
    public partial class frmAddupdTreatments : Form
    {
        private int _TreatmentID = -1;
        private ClsTreatmentsBuss _treatment;
        enum enMode { addnew = 0, update = 1 }
        enMode mode = enMode.addnew;
        public frmAddupdTreatments()
        {
            mode = enMode.addnew;
            _treatment = new ClsTreatmentsBuss();
            InitializeComponent();
        }
        public frmAddupdTreatments(int id)
        {
            mode = enMode.update;
            _TreatmentID = id;
          
            InitializeComponent();
        }
        private void _loadData()
        {
            switch (mode)
            {
                case enMode.addnew:
                    txtName.Text = "???";
                    txtprice.Text = "???";
                    txtID.Text = "N/A";
                    txtDescription.Text = "";
                    break;
                case enMode.update:
                    lblName.Text = "Update";
                    _treatment = ClsTreatmentsBuss.find(_TreatmentID);
                    if (_treatment != null)
                    {
                        txtName.Text = _treatment.TreatmentName;
                        txtprice.Text=_treatment.price.ToString();
                        txtID.Text=_treatment.TreatmentID.ToString();
                        txtDescription.Text = _treatment.TreatmentDescription;
                    }
                    else
                    {
                        MessageBox.Show("this id not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }
        }
        private void frmAddupdTreatments_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            _loadData();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void ImptyText_Validating(object sender, CancelEventArgs e)
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
        private void btnTreatments_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _treatment.TreatmentName = txtName.Text;
            _treatment.price= decimal.Parse( txtprice.Text);
            _treatment.TreatmentDescription = txtDescription.Text;
            if (_treatment.save())
            {
                MessageBox.Show("Added successfully", "Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = _treatment.TreatmentID.ToString();
                lblName.Text="Update";
                btnTreatments.Visible = false;
                txtID.Enabled = false;
            }
            else
            {
                MessageBox.Show("Added failed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
