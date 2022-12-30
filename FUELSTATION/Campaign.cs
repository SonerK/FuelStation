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
    public partial class Campaign : Form
    {
        public Campaign()
        {
            InitializeComponent();
        }

        private void BT_Campain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HER YAKIT ALIMINIZA ALDIĞINIZ YAKIT ÜCRETİNİN %3 Ü STATYON COİN OLARAK HESABINIZA AKTARILIR.");
        }
    }
}
