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
namespace Dental_Clinic_Project.visit_treatments
{
    public partial class FrmAddUpdateVisit : Form
    {
        public delegate void DataBackEventHandler(object sender, int Visitid);
        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private int _visitid;
        private ClsVisitsBuss _visitSelected;
        enum enMode { AddNew=0,Update=1}
        enMode Mode = enMode.AddNew;
        public FrmAddUpdateVisit()
        {
            Mode = enMode.AddNew;
            _visitSelected = new ClsVisitsBuss();
            InitializeComponent();
        }

        public FrmAddUpdateVisit(int visitID)
        {
            Mode = enMode.Update;
            _visitid = visitID;
            InitializeComponent();
        }
        private void _fillTreatmentNameInCombobox()
        {
            DataTable treatment = ClsTreatmentsBuss.GetAllTreatments();
            ckbTreatments.DataSource = treatment;
            ckbTreatments.DisplayMember = "TreatmentName";
            cmbPatientName.ValueMember = "treatmentID";
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
            cmbPatientName.DataSource = patientName;
            cmbPatientName.DisplayMember = "fullName";
            cmbPatientName.ValueMember = "PatientID";
        } 
        private void FrmAddUpdateVisit_Load(object sender,EventArgs e)
        {
            _fillTreatmentNameInCombobox();
            _fillDentistNameInCombobox();
            _fillPatientNameInCombobox();
        }
        private void _defualtData()
        {
            if (Mode == enMode.AddNew)
            {
                cmbPatientName.Text = "";
                cmbDentistName.Text = "";
                ckbTreatments.Text = "";
                dtpVisitDate.Value = DateTime.Now;
                txtDiagnosis.Text = "";
                txtNotes.Text = "";

            }
            else
            {
                _visitSelected = ClsVisitsBuss.find(_visitid);
                if (_visitSelected == null)
                {
                    MessageBox.Show("no visit with ID" + _visitid, "visit not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                cmbPatientName.Text = ClsPatientBuss.find(_visitSelected.patientID).fullName;
                cmbDentistName.Text=ClsDentistBuss.find(_visitSelected.dentistID).fullName;
                dtpVisitDate.Value = _visitSelected.visitDate;
                txtAppointmentID.Text = _visitSelected.AppointmentID.ToString();
                txtNotes.Text = _visitSelected.notes;
                txtDiagnosis.Text = _visitSelected.diagnosis;
               
            }
        }
    }
}
