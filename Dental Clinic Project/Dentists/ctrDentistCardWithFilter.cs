using Dental_Clinic_Project.patients;
using DentalClinic_BussinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Project.Dentists
{
    public partial class ctrDentistCardWithFilter : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnDentistSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void DentistSelected(int DentistID)
        {
            Action<int> handler = OnDentistSelected;
            if (handler != null)
            {
                handler(DentistID); // Raise the event with the parameter
            }
        }
        public ctrDentistCardWithFilter()
        {
            InitializeComponent();
        }
        public int DentistID
        {
            get
            {
                return ctrDentistCard1.dentistID;
            }
        }
        public ClsDentistBuss dentistSelected
        {
            get
            {
                return ctrDentistCard1.Dentistinfo;
            }
        }
        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "this field is required");
            }
            else
            {
                errorProvider1.SetError(temp, null);

            }
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }

        }
        private void ctrDentistCardWithFilter_Load(object sender, EventArgs e)
        {
            txtFilter.Focus();
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ClsDentistBuss.isDentistExist(int.Parse(txtFilter.Text)))
            {
                MessageBox.Show("this ID does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrDentistCard1.loadData(int.Parse(txtFilter.Text));

            if (OnDentistSelected != null)
                // Raise the event with a parameter
                OnDentistSelected(ctrDentistCard1.dentistID);
        }
        private void DataBackEvent(object sender, int dentistID)
        {
            txtFilter.Text = dentistID.ToString();
            ctrDentistCard1.loadData(dentistID);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            frmAddUpdateDentist frm = new frmAddUpdateDentist();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
    }
}
