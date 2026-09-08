using Dental_Clinic_Project.global;
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

namespace Dental_Clinic_Project.Dentists
{
    public partial class ctrDentistCard : UserControl
    {
        private int _dentistID ;
        private ClsDentistBuss _dentist;
        public int dentistID
        {
            get
            {
                return _dentistID;
            }
        }
        public ClsDentistBuss Dentistinfo
        {
            get
            {
                return _dentist;
            }
        }
        public void loadData(int dentistID)
        {
         
            _dentist = ClsDentistBuss.find(dentistID);
            if (_dentist != null)
            {
                lblD.Text = _dentist.dintistID.ToString();
                lblFirst.Text = _dentist.FirstName;
                lblLast.Text = _dentist.LastName;
                lblEmail.Text = _dentist.email;
                lblStatus.Text = _dentist.status;
                lblSpec.Text = clsSpecializationsBuss.find(_dentist.specializationID).specializationName;
                lblHire.Text =format.dateToString( _dentist.hireDate);
                lblPhone.Text = _dentist.phone;
                lblFullName.Text=_dentist.fullName;
                if (_dentist.status == "inActive")
                {
                    lblStatus.ForeColor = Color.Red;
                    lblFullName.Font=new Font(lblFullName.Font, FontStyle.Strikeout);
                }
            }
            else
            {
                MessageBox.Show("no dentist with this ID ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public ctrDentistCard()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ctrDentistCard_Load(object sender, EventArgs e)
        {
           
        }

        private void lblSpec_Click(object sender, EventArgs e)
        {

        }
    }
}
