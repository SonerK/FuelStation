using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUELSTATION
{
    public partial class LOGIN : Form
    {
        private string Md5(string text)
        {
            MD5 MD5Encrypting = new MD5CryptoServiceProvider();
            byte[] bytes = MD5Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text.ToCharArray()));

            StringBuilder builder = new StringBuilder();


            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }





            return builder.ToString();



        }
        public LOGIN()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");

        private void BT_LOGIN_Click(object sender, EventArgs e)
        {

            if (TB_E_Posta.Text == "" || TB_Password.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
            }
            else
            {
                try
                {

                    connect.Open();
                    SqlCommand giris = new SqlCommand("select * from USERS where Email='" + TB_E_Posta.Text.Trim() + "' and Password='" + Md5(TB_Password.Text) + "'", connect);
                    SqlDataReader oku = giris.ExecuteReader();


                    if (oku.Read())
                    {

                        if (oku["USID"].ToString() == "1")
                        {
                            AdminPanel AdminPanel = new AdminPanel();
                            AdminPanel.Show();
                            connect.Close();
                        }
                        else if (oku["USID"].ToString() == "2")
                        {
                            PumperPersonel PumperPersonel = new PumperPersonel();
                            PumperPersonel.Show();
                            connect.Close();
                        }
                        else if (oku["USID"].ToString() == "3")
                        {
                            Users Users = new Users();
                            Users.Show();
                            connect.Close();
                        }




                    }
                    else
                    {

                        MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
                        connect.Close();

                    }


                }
                catch (Exception hata)
                {
                    MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                }
            }
        }
    }
}
