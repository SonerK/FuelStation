using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUELSTATION
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void BT_UsersUpdate_Click(object sender, EventArgs e)
        {
            AdminUpdateDelete adminUpdateDelete = new AdminUpdateDelete();
            adminUpdateDelete.Show();


        }

        private void BT_NewDeleteUsers_Click(object sender, EventArgs e)
        {
            AdminNewAccount adminNewAccount = new AdminNewAccount();
            adminNewAccount.Show();
        }

        private void BT_NewStation_Click(object sender, EventArgs e)
        {
            AdminGasStation adminGasStation = new AdminGasStation();
            adminGasStation.Show();
        }
    }
}
