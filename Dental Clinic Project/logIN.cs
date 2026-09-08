using Dental_Clinic_Project.global;
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

namespace Dental_Clinic_Project
{
    public partial class logIN : Form
    {
        public logIN()
        {
            InitializeComponent();
        }

        private void icnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide ,put the mouse over the red icon(s) to see what is required", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsUserBuss currentUser = ClsUserBuss.find(txtUserName.Text.Trim(), txtpassword.Text.Trim());
            if (currentUser != null)
            {
                if (chbRemeberMe.Checked)
                {
                    ClsGlobal.SaveUserNameAndPasswordToRegistry(txtUserName.Text.Trim(), txtpassword.Text.Trim());
                }
                else
                {
                    ClsGlobal.SaveUserNameAndPasswordToRegistry("", "");

                }
                if (!currentUser.isActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("your accound is not Active,contact Admin", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ClsGlobal.currentUset = currentUser;
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invald userName/Password", "wrong credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void logIN_Load(object sender, EventArgs e)
        {
            string userName = "";
            string password = "";
            if(ClsGlobal.GetUserNameAndPasswordFromRegistry(ref userName,ref password))
            {
                txtUserName.Text = userName;
                txtpassword.Text = password;
                chbRemeberMe.Checked = true;
            }
            else
            {
                chbRemeberMe.Checked = false;
            }
        }

        private void validateImptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "this field is required");
            }
            else
            {
                errorProvider1.SetError(temp, null);

            }
        }
    }
}
