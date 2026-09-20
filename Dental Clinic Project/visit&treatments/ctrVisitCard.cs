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
    public partial class ctrVisitCard : UserControl
    {
        private int _visitID;
        private ClsVisitsBuss _visitSelected;
        public int visitID
        {
            get
            {
                return _visitID;
            }
        }
        public ClsVisitsBuss visitSelected
            {
            get
            {
                return _visitSelected;
            }

            }
        public ctrVisitCard()
        {
            InitializeComponent();
        }
        public  void loadData(int visitID) {
            _visitID = visitID;
            DataSet ds = ClsVisitsBuss.getVisitDetails(visitID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                lblvisitID.Text = row["visitID"].ToString();
                lblPatientName.Text = row["patientName"].ToString();
                lblDentistName.Text = row["DentistName"].ToString();
               lblAppointmentID.Text = row["AppointmentID"].ToString();
                lblvisitDate.Text = row["visitdate"].ToString();
                lblDiagnosis.Text = row["diagnosis"].ToString();
                lblnotes.Text = row["notes"].ToString();
            }
            // dgvtreatments.DataSource = ds.Tables[1];
            dataTableSet();
            
        }
        private void dataTableSet()
        {
            DataSet ds = ClsVisitsBuss.getVisitDetails(_visitID);
            dgvtreatments.DataSource = ds.Tables[1];
            if (dgvtreatments.Rows.Count > 0)
            {
                dgvtreatments.Columns[0].HeaderText = "Treatment ID";
                dgvtreatments.Columns[0].Width = 40;

                dgvtreatments.Columns[1].HeaderText = "Treatments Name";
                dgvtreatments.Columns[1].Width = 120;
                dgvtreatments.Columns[2].HeaderText = "Cost";
                dgvtreatments.Columns[2].Width = 70;
            }
        }
        private void ctrVisitCard_Load(object sender, EventArgs e)
        {

        }
    }
}
