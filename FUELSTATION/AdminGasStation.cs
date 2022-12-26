using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUELSTATION
{
    public partial class AdminGasStation : Form
    {

        public AdminGasStation()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
        DataClasses1DataContext DC = new DataClasses1DataContext();

        private void AdminGasStation_Load(object sender, EventArgs e)
        {
            City();
           TB_StationCode.Enabled = true;
        }
        void City()
        {
            var CityList = from City in DC.City select City;
            CB_City.DisplayMember = "CityName";
            CB_City.ValueMember = "CityID";
            CB_City.DataSource = CityList;
        }


        private void CB_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            var DistrictList = from District in DC.District where District.CityID == Convert.ToInt32(CB_City.SelectedValue) select District;

             CB_District.DisplayMember = "DistrictName";
             CB_District.ValueMember = "CityID";
            
             CB_District.DataSource = DistrictList;
        }

        private void BT_Code_Click(object sender, EventArgs e)
        {
          
                TB_StationCode.Text = TB_PostCode.Text + TB_FuelPompN.Text + CB_City.SelectedValue + (CB_District.SelectedIndex + 1);
            
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (TB_PostCode.Text == "" || TB_FuelPompN.Text == "")
            {
                MessageBox.Show("Lütfen posta kodu ve pompa sayısı alanını boş bırakmayınız.");
            }
            else if (TB_StationCode.Text == "")
            {
                MessageBox.Show("lütfen kod oluşturma butonuna basınız");
            }
        }
    }
}

