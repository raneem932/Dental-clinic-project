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
namespace Dental_Clinic_Project.visit_treatments
{
    public partial class FrmAddUpdateVisit : Form
    {
        public delegate void DataBackEventHandler(object sender, int Visitid);
        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private int _visitid;
        private ClsVisitsBuss _visitSelected;
        private ClsVisitTreatmentsBuss _visitTreatmentsSelected;
     
        public FrmAddUpdateVisit()
        {
           
            _visitSelected = new ClsVisitsBuss();
            _visitTreatmentsSelected = new ClsVisitTreatmentsBuss();
            InitializeComponent();
        }
        private void _fillTreatmentNameInCombobox()
        {
            DataTable treatment = ClsTreatmentsBuss.GetAllTreatments();
            ckbTreatments.DataSource = treatment;
            ckbTreatments.DisplayMember = "TreatmentName";
            ckbTreatments.ValueMember = "treatmentID";
        }
        private void _fillDentistNameInCombobox()
        {
            DataTable dentistName = ClsDentistBuss.GetAllDentists();
            cmbDentistName.DataSource = dentistName;
            cmbDentistName.DisplayMember = "fullName";
            cmbDentistName.ValueMember = "DentistID";

        }
        private void _fillPatientNameInCombobox()
        {
            DataTable patientName = ClsPatientBuss.GetAllPatient();
            cmbpatients.DataSource = patientName;
            cmbpatients.DisplayMember = "fullName";
            cmbpatients.ValueMember = "PatientID";
        } 
        private void FrmAddUpdateVisit_Load(object sender,EventArgs e)
        {
            txtVisitID.Enabled = false;
          
            _fillTreatmentNameInCombobox();
            _fillDentistNameInCombobox();
            _fillPatientNameInCombobox();
        }
        private void _defualtData()
        {
                cmbpatients.Text = "";
                cmbDentistName.Text = "";
                ckbTreatments.Text = "";
                txtDiagnosis.Text = "";
                txtNotes.Text = "";
                //DataSet ds = ClsVisitsBuss.getVisitDetails(_visitid);
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    DataRow row =ds.Tables[0].Rows[0];
                //    cmbPatientName.Text = row["patientName"].ToString();
                //    cmbDentistName.Text = row["DentistName"].ToString();
                //    txtAppointmentID.Text = row["AppointmentID"].ToString();
                //    dtpVisitDate.Value = (DateTime)row["visitdate"];
                //    txtDiagnosis.Text = row["diagnosis"].ToString();
                //    txtNotes.Text = row["notes"].ToString();
                //    dgvTreatments.DataSource = ds.Tables[1];
                //}

            
        }
        private void Imptycombo_Validating(object sender, CancelEventArgs e)
        {
            Guna2ComboBox temp = ((Guna2ComboBox)sender);
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
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private List<int> GetSelectedTreatments()
        {
            List<int> treatmentIDs = new List<int>();
            foreach(DataRowView item in ckbTreatments.CheckedItems)
            {
                int treatmentID =( int)item["treatmentID"];
                treatmentIDs.Add(treatmentID);
            }
            return treatmentIDs;
        }
        private void icnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtAppointmentID.Text!="")  
            {
                int appointmentID = Convert.ToInt32(txtAppointmentID.Text);
                if (!ClsAppointmentBuss.isAppointmentExist(appointmentID))
                {
                    MessageBox.Show("Appoitment ID not found", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClsAppointmentBuss appointment = ClsAppointmentBuss.find(appointmentID);
               
                if( appointment.status == "completed")
                {
                    MessageBox.Show(" Appointment is completed", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            List<int> treatmeIDs = GetSelectedTreatments();
            if (treatmeIDs.Count == 0)
            {
                MessageBox.Show("please select at least one treatment", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAppointmentID.Text == "")
            {
                _visitSelected.AppointmentID = null;
            }
            else
            {
                _visitSelected.AppointmentID =Convert.ToInt32(txtAppointmentID.Text);
            }
            _visitSelected.patientID =(int)cmbpatients.SelectedValue;
            _visitSelected.dentistID = (int)cmbDentistName.SelectedValue;
            _visitSelected.notes = txtNotes.Text;
            _visitSelected.diagnosis = txtDiagnosis.Text;
            _visitSelected.treatmntIDs = treatmeIDs;
            if (_visitSelected.save())
            {
                MessageBox.Show("visit added successfully");
                txtVisitID.Text = _visitSelected.visitID.ToString();
                icnSave.Enabled= false;
                txtVisitID.Text = _visitSelected.visitID.ToString();

            }
            else
            {
                MessageBox.Show("failed to add visit");

            }

        }

        private void txtAppointmentID_TextChanged(object sender, EventArgs e)
        {

            if (txtAppointmentID.Text != "")
            {
                int appointmentID = Convert.ToInt32(txtAppointmentID.Text);

                if (!ClsAppointmentBuss.isAppointmentExist(appointmentID))
                {
                    MessageBox.Show("Appoitment ID not found", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClsAppointmentBuss appointment = ClsAppointmentBuss.find(appointmentID);
                cmbpatients.Text = ClsPatientBuss.find(appointment.patientID).fullName;
                cmbDentistName.Text = ClsDentistBuss.find(appointment.dentistID).fullName;
                dtpAppointmentDate.Value = appointment.appointmentDate;
            }
        }
    }
}
