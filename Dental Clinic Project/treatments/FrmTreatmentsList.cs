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

namespace Dental_Clinic_Project.treatments
{
    public partial class FrmTreatmentsList : Form
    {
        public FrmTreatmentsList()
        {
            InitializeComponent();
        }
        private void _refrechData()
        {
            DataTable dt = ClsTreatmentsBuss.GetAllTreatments();
            dgvlisttreatments.DataSource = dt;
        }
        private void FrmTreatmentsList_Load(object sender, EventArgs e)
        {
            DataTable dt = ClsTreatmentsBuss.GetAllTreatments();
            dgvlisttreatments.DataSource = dt;
            if (dgvlisttreatments.Rows.Count > 0)
            {
                dgvlisttreatments.Columns[0].HeaderText = "Treatment ID";
                dgvlisttreatments.Columns[0].Width = 40;

                dgvlisttreatments.Columns[1].HeaderText = "Treatments Name";
                dgvlisttreatments.Columns[1].Width = 120;
                dgvlisttreatments.Columns[2].HeaderText = "Cost";
                dgvlisttreatments.Columns[2].Width = 70;
            }
        }

        private void btnAddtretm_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(btnAddtretm, "Add new treatment");
        }

        private void btnAddtretm_Click(object sender, EventArgs e)
        {
            frmAddupdTreatments frm = new frmAddupdTreatments();
            frm.ShowDialog();
            _refrechData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddupdTreatments frm =new frmAddupdTreatments((int)dgvlisttreatments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _refrechData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvlisttreatments.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure to Delete treatment :" + ID + "?", "Delete treatment", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsTreatmentsBuss.DeleteTreatment(ID))
                {
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Deleted failed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            _refrechData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTretmantCard frm = new FrmTretmantCard((int)dgvlisttreatments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
