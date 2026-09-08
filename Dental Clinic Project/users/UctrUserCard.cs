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

namespace Dental_Clinic_Project.users
{
    public partial class UctrUserCard : UserControl
    {
        private int _userID;
        private ClsUserBuss _userSelected;
        public int userID
        {
            
            get
            {
                return _userID;
            }
        }
      public  ClsUserBuss userSelected
        {
            get
            {
                return _userSelected;
            }
        }
       public void loadData(int id)
        {
            _userID = id;
            _userSelected = ClsUserBuss.find(id);
            if (_userSelected != null)
            {
                lblID.Text = _userSelected.userID.ToString();
                LblUsername.Text = _userSelected.userName;
                lblCreatedAt.Text = _userSelected.createdAT.ToShortDateString();
                lbldentistID.Text = _userSelected.DentistID.ToString();
                lblRole.Text = ClsRoleBuss.find(_userSelected.roleID).RoleName;
                lblIsActive.Text = _userSelected.isActive.ToString();
                
            }
            else
            {
                MessageBox.Show("User Not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public UctrUserCard()
        {
            InitializeComponent();
        }

        private void UctrUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
