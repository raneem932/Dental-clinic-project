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
    public partial class frmVisitCard : Form
    {
        private int _VisitID;
        public frmVisitCard(int visitID)
        {
            _VisitID = visitID;
            InitializeComponent();
        }

        private void frmVisitCard_Load(object sender, EventArgs e)
        {
            ctrVisitCard1.loadData(_VisitID);
        }
    }
}
