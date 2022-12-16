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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FUELSTATION
{
    public partial class PasswordUpdate : Form
    {
        public PasswordUpdate(string email_)
        {
            InitializeComponent();
            email = email_;
        }
        string email;
        string connectionString = "Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True";
        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
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
        private void PasswordUpdate_Load(object sender, EventArgs e)
        {
            TB_PassUpdate2.Enabled = false;

        }

        private void BT_Save1_Click(object sender, EventArgs e)
        {
            if (TB_PassUpdate1.Text=="") 
            {
                MessageBox.Show("Lütfen Yeni Şifrenizi Giriniz");
            }
            else
            { 
                TB_PassUpdate2.Enabled = true;
                
            }
        }

        private void BT_Save2_Click(object sender, EventArgs e)
        {
            if (TB_PassUpdate1.Text != TB_PassUpdate2.Text)
            {
                MessageBox.Show("Girdiğiniz Şifreler Eşleşmedi.Lütfen Tekrar Deneyiniz.");
            }
            else
            {
                connect.Open();
                try {

                    SqlCommand giris = new SqlCommand("select * from  USERS where Email='" + email + "'", connect);

                    SqlDataReader oku = giris.ExecuteReader();
                    if (oku.Read())

                    {
                        if (oku["Password"].ToString() == Md5(TB_PassUpdate2.Text))
                        {
                            MessageBox.Show("Yeni Şifre Eski Şifrenizle Aynı Olamaz");
                            connect.Close();
                        }
                       




                    else
                        {
                            

                            string DBUpdate = "update USERS set Password='" + Md5(this.TB_PassUpdate2.Text) + "' where Email ='" + email + "'; ";
                            SqlConnection connect = new SqlConnection(connectionString);
                            connect.Open();

                            SqlCommand komut_Update = new SqlCommand(DBUpdate, connect);

                            SqlDataReader read;



                            read = komut_Update.ExecuteReader();
                            MessageBox.Show("KAYDEDİLDİ");



                        }

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
