using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Dental_Clinic_Project.Appointments;
using Dental_Clinic_Project.Dentists;
using Dental_Clinic_Project.users;
using Dental_Clinic_Project.visit_treatments;
using DentalClinic_BussinessLayer;
using Guna.UI2.WinForms;
namespace Dental_Clinic_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Stylebutton(Guna2Button button)
        {
          button.ImageAlign = HorizontalAlignment.Left;
            button.TextAlign = HorizontalAlignment.Left;
            button.ImageOffset = new Point(0, 0);
            button.TextOffset = new Point(35, 0);
            button.FillColor = Color.LightSteelBlue;
            button.ForeColor = Color.Black;
        }
        private void openChildForm(Form childForm)
        {
            formPanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
           
            formPanel.Controls.Add(childForm);
            formPanel.Tag = childForm;
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /* Stylebutton(btnDashboard);
             Stylebutton(btnDoctors);
             Stylebutton(btnPatiens);
             Stylebutton(btnAppointments);
             Stylebutton(btnInvoices);
             Stylebutton(btnVisits);
             Stylebutton(btnUsers);*/
            openChildForm(new FrmDashboard());

        }

  

        private void btnPatiens_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            openChildForm(new FrmPatients());
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDashboard());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            openChildForm(new frmlistDentists());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            openChildForm(new FrmUsersList());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            openChildForm(new frmListAppointments());
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            openChildForm(new frmVisitsTreatments());
        }
    }
}
