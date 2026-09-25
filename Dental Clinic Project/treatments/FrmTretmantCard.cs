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
    public partial class FrmTretmantCard : Form
    {
        private int _treatmentid;
        private ClsTreatmentsBuss _treatment;
        public FrmTretmantCard(int id)
        {
            _treatmentid = id;
            InitializeComponent();
        }
        private void _loadData()
        {
            _treatment = ClsTreatmentsBuss.find(_treatmentid);
            if (_treatment != null)
            {
                treatID.Text = _treatment.TreatmentID.ToString();
                lbltreatName2.Text = _treatment.TreatmentName;
                lblprice.Text = _treatment.price.ToString();
                lbldescription.Text = _treatment.TreatmentDescription;
            }
            else
            {
                MessageBox.Show("treatment Not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
                    }

        private void FrmTretmantCard_Load(object sender, EventArgs e)
        {
            _loadData();
        }
    }
}
