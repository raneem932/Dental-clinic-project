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

namespace Dental_Clinic_Project.users
{
    public partial class FrmAddUpdateUser : Form
    {
        public enum enMode { addNew,update}
        enMode mode = enMode.addNew;
        private int _userID;
        private ClsUserBuss _userSelected;
        public FrmAddUpdateUser()
        {
            _userSelected = new ClsUserBuss();
            InitializeComponent();
            mode=enMode.addNew;
           
        }
        public FrmAddUpdateUser(int userid)
        {
            InitializeComponent();
            mode = enMode.update;
            _userID = userid;

        }
        private void _loadData()
        {
            if (mode == enMode.addNew)
            {
                txtName.Text = "";
                txtPassword.Text = "";
                txtDentistID.Text = "";
                cmbRole.Text = "ADMIN";
                cmbIsActive.Text = "true";
            }
            else
            {
                _userSelected=ClsUserBuss.find(_userID);
                if (_userSelected == null)
                {
                    MessageBox.Show("no user with ID" + _userID, "user not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                txtID.Text = _userSelected.userID.ToString();
                txtName.Text = _userSelected.userName;
                txtDentistID.Text = _userSelected.DentistID.ToString();
                
                cmbRole.Text = ClsRoleBuss.find(_userSelected.roleID).RoleName;
                cmbIsActive.Text = _userSelected.isActive.ToString();
                txtPassword.Text = "*******";
                txtID.Enabled = false;
            }

        }
      
        private void FrmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _loadData();
        }
        private void Imptytxt_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox temp = ((Guna2TextBox)sender);
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
            _userSelected.userName = txtName.Text;
            _userSelected.roleID = ClsRoleBuss.find(cmbRole.Text).roleID;
            if (txtDentistID.Text == "")
            {
                _userSelected.DentistID = null;
            }
            else
            {
                _userSelected.DentistID = int.Parse(txtDentistID.Text);
            }
            _userSelected.isActive =bool.Parse(  cmbIsActive.Text);
            _userSelected.Password = txtPassword.Text;
            if (_userSelected.save())
            {
                lblName.Text = "update User";
                mode = enMode.update;
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = _userSelected.userID.ToString();
            }
            else
            {
                MessageBox.Show("error saved " +
                    "Data", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtID.Enabled = false;
        }
    }
}
