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
    public partial class FrmDentistCard : Form
    {
        private int _dentistid = -1;
        public FrmDentistCard(int dentistID)
        {
            _dentistid = dentistID;
            InitializeComponent();
        }

       

        private void FrmDentistCard_Load(object sender, EventArgs e)
        {
            ctrDentistCard1.loadData(_dentistid);
        }

        private void icnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
