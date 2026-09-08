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

namespace Dental_Clinic_Project.patients
{
    public partial class ctrPatientCardWithFilter : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPatientSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PatientSelected(int PatientID)
        {
            Action<int> handler = OnPatientSelected;
            if (handler != null)
            {
                handler(patientID); // Raise the event with the parameter
            }
        }

        public int patientID
        {
            get
            {
                return uctPatient1.patientID;
            }
        }
        public ClsPatientBuss patientSelected
        {
            get
            {

                return uctPatient1.patient;
            }
        }

        public ctrPatientCardWithFilter()
        {
            InitializeComponent();
        }

        private void ctrPatientCardWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ClsPatientBuss.isPatientExist(int.Parse(txtFilter.Text)))
            {
                MessageBox.Show("this ID does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uctPatient1.loadData(int.Parse(txtFilter.Text));

            if (OnPatientSelected != null )
                // Raise the event with a parameter
                OnPatientSelected(uctPatient1.patientID);
        }
        private void DataBackEvent(object sender,int patientID)
        {
            txtFilter.Text = patientID.ToString();
            uctPatient1.loadData(patientID);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePatient FRM = new FrmAddUpdatePatient();
            FRM.DataBack += DataBackEvent;
            FRM.ShowDialog();
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
    }
}
