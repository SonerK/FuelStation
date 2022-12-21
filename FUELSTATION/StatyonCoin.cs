using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FUELSTATION
{
    public partial class StatyonCoin : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
        string ad, soyad, email;

        private void StatyonCoin_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand Coin = new SqlCommand("select Coin from COIN where Email=@p2", connect);
            Coin.Parameters.AddWithValue("@p2", email);
            SqlDataReader read = Coin.ExecuteReader();
            read.Read();
            L_Coin.Text = read["Coin"].ToString();
            connect.Close();
        }

        public StatyonCoin(string name, string surname, string email_)
        {
            InitializeComponent();
            ad = name;
            soyad = surname;
            email = email_;
        }
    }
}
