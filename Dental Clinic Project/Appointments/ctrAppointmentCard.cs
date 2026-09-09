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

namespace Dental_Clinic_Project.Appointments
{
    public partial class ctrAppointmentCard : UserControl
    {
        private int _AppointmentID;
        private ClsAppointmentBuss _appointmentSelected;
        public ctrAppointmentCard()
        {
            InitializeComponent();
        }
        public int appointmentID
        {
            get
            {
                return _AppointmentID;
            }
        }
        public ClsAppointmentBuss appointmentSelected
        {
            get
            {
                return _appointmentSelected;
            }
        }
        private void foreverGroupBox1_Click(object sender, EventArgs e)
        {

        }
        public void LoadData(int appointmentID)
        {
            _AppointmentID = appointmentID;
            _appointmentSelected = ClsAppointmentBuss.find(appointmentID);
            if (_appointmentSelected == null)
            {
                MessageBox.Show("no appointment with this ID ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lblappointmentID.Text = _appointmentSelected.AppointmentID.ToString();
                LblpatientName.Text = ClsPatientBuss.find(_appointmentSelected.patientID).fullName;
                lblDentistName.Text = ClsDentistBuss.find(_appointmentSelected.dentistID).fullName;
                lblAppointmentDate.Text = _appointmentSelected.appointmentDate.ToShortDateString();
                lblcreatedAT.Text = _appointmentSelected.createdAt.ToShortDateString();
                lblStartTime.Text = _appointmentSelected.startTime.ToString();
                lblEndTime.Text=_appointmentSelected.endTime.ToString();
                lblStatus.Text = _appointmentSelected.status;
                lblnotes.Text = _appointmentSelected.notes;
            }
        }
        private void ctrAppointmentCard_Load(object sender, EventArgs e)
        {

        }
    }
}
