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

namespace Dental_Clinic_Project.Appointments
{
    public partial class frmAddNewAppoin : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private int _AppointmentID;
        private ClsAppointmentBuss _AppointmentSelected;
        enum enMode { addNew=0,Update=1}
        enMode Mode;

        public frmAddNewAppoin()
        {
            Mode = enMode.addNew;
            InitializeComponent();
        }
        public frmAddNewAppoin(int id)
        {
            _AppointmentID = id;
            Mode = enMode.Update;
         
            InitializeComponent();
        }
        private void _fillPatientNameInCombobox()
        {
            DataTable patientName = ClsPatientBuss.GetAllPatient();
            cmbPatientName.DataSource = patientName;
                cmbPatientName.DisplayMember = "fullName";
                cmbPatientName.ValueMember = "PatientID";
        }
        private void _fillDentistNameInCombobox()
        {
            DataTable dentistName = ClsDentistBuss.GetAllDentists();
            cmbDentistName.DataSource = dentistName;
                cmbDentistName.DisplayMember = "fullName";
                cmbDentistName.ValueMember = "DentistID";
            
        }
        private void _defualtData()
        {
            if (Mode == enMode.addNew)
            {
                _AppointmentSelected = new ClsAppointmentBuss();
                txtID.Text = "N/A";
                cmbPatientName.Text = "";
                cmbDentistName.Text = "";
                dtpAppointmentDate.Value = DateTime.Now;
                cmbStattus.Text = "scheduled";
                txtNotes.Text = "";
                dtpcreatedAt.Visible = false;
                txtID.Enabled = false;
            }
            if(Mode==enMode.Update)
            {

                lblName.Text = "update Appointment";
                _AppointmentSelected = ClsAppointmentBuss.find(_AppointmentID);
                if (_AppointmentSelected != null)
                {
                    txtID.Text = _AppointmentSelected.AppointmentID.ToString();
                    cmbPatientName.Text =ClsPatientBuss.find(_AppointmentSelected.patientID).fullName;
                    cmbDentistName.Text =ClsDentistBuss.find(_AppointmentSelected.dentistID).fullName;
                    dtpAppointmentDate.Value =_AppointmentSelected.appointmentDate;
                    cmbStattus.Text =_AppointmentSelected.status;
                    txtNotes.Text =_AppointmentSelected.notes;
                    dtpStartTime.Value = DateTime.Today.Add(_AppointmentSelected.startTime);
                    dtpEndTime.Value = DateTime.Today.Add(_AppointmentSelected.endTime);

                    dtpcreatedAt.Value=_AppointmentSelected.createdAt;
                    txtID.Enabled = false;
                    dtpcreatedAt.Enabled = false;
                }
                else
                {
                    MessageBox.Show("no Appointment with ID" + _AppointmentID, "Appointment not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
        }
        private void frmAddNewAppoin_Load(object sender, EventArgs e)
        {
            _fillPatientNameInCombobox();
            _fillDentistNameInCombobox();
            _defualtData();
            dtpAppointmentDate.MinDate = DateTime.Now;
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
        private void ImptyDTP_Validating(object sender, CancelEventArgs e)
        {
            Guna2DateTimePicker temp = ((Guna2DateTimePicker)sender);
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
        private void icnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ClsAppointmentBuss.isAppointmentBooked(_AppointmentSelected.appointmentDate, _AppointmentSelected.startTime, _AppointmentSelected.endTime, _AppointmentSelected.dentistID))
            {
                MessageBox.Show("this time slot already booked", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _AppointmentSelected.patientID = (int)cmbPatientName.SelectedValue;
            _AppointmentSelected.dentistID = (int)cmbDentistName.SelectedValue;
            _AppointmentSelected.appointmentDate = dtpAppointmentDate.Value;
            _AppointmentSelected.status = cmbStattus.Text;
            _AppointmentSelected.startTime = dtpStartTime.Value.TimeOfDay;
            _AppointmentSelected.endTime = dtpEndTime.Value.TimeOfDay;
            _AppointmentSelected.notes = txtNotes.Text;
            
                if (_AppointmentSelected.save())
                {
                    lblName.Text = "update Appointment";
                    Mode = enMode.Update;
                    MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = _AppointmentSelected.AppointmentID.ToString();
                }

                else
                {
                    MessageBox.Show("error saved " +
                        "Data", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtID.Enabled = false;
                DataBack?.Invoke(this, _AppointmentSelected.AppointmentID);
        }
    }
}
