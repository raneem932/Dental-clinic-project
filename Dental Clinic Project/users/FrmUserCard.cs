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
    public partial class UserCard : Form
    {
        private int _userID;
        public UserCard(int userID)
        {
            _userID = userID;
            InitializeComponent();
        }

        private void crownLabel2_Click(object sender, EventArgs e)
        {

        }

        private void UserCard_Load(object sender, EventArgs e)
        {
            uctrUserCard1.loadData(_userID);
        }
    }
}
