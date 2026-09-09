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
    public partial class FrmAppointmentCard : Form
    {
        private int _appointmentID;
        public FrmAppointmentCard(int id)
        {
            _appointmentID = id;
            InitializeComponent();
        }

        private void ctrAppointmentCard1_Load(object sender, EventArgs e)
        {
ctrAppointmentCard1.LoadData(_appointmentID);
        }
    }
}
