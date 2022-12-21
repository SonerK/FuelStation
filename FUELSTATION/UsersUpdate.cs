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
    public partial class UsersUpdate : Form
    {
        string ad, soyad, uid, email;
        public UsersUpdate(string name, string surname, string uid_, string email_)
        {

            InitializeComponent();
            ad = name;
            soyad = surname;
            uid = uid_;
            email = email_;

        }
      
        private void UsersUpdate_Load(object sender, EventArgs e)
        {
            City();
        }
        string connectionString = "Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True";
        
        SqlConnection conn = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
       
        DataClasses1DataContext DC = new DataClasses1DataContext();
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
        private void BT_Save_Click(object sender, EventArgs e)
        {
           

            if (TB_E_Posta.Text == "" || TB_Password.Text == "" || TB_Name.Text == "" || TB_Surname.Text == "" || TB_TelephoneNumber.Text == "" || TB_E_Posta2.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
            }
          
            else
            {
                 conn.Open();
            SqlCommand giris = new SqlCommand("select * from USERS where Email='" + TB_E_Posta.Text.Trim()+"'", conn);
            SqlDataReader oku = giris.ExecuteReader();

                if (oku.Read())
                {
                    if (oku["USID"].ToString() == "3")
                    {

                        try
                        {


                            string DBUpdate = "update USERS set Name='" + this.TB_Name.Text + "',SurName='" + this.TB_Surname.Text + "',Password='" 
                                + Md5(this.TB_Password.Text) + "',Email ='" + this.TB_E_Posta2.Text + "',Phone ='" 
                                + this.TB_TelephoneNumber.Text + "',BirthDay ='" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd") 
                                + "',CityID='"+ Convert.ToInt32(this.CB_City.SelectedValue)+ "',DistrictID='" 
                                +Convert.ToInt32((this.CB_District.SelectedIndex + 1))+ "' where Email ='" + this.TB_E_Posta.Text + "'; ";
                            SqlConnection connect = new SqlConnection(connectionString);

                            SqlCommand komut_Update = new SqlCommand(DBUpdate, connect);

                            SqlDataReader read;


                            connect.Open();
                            read = komut_Update.ExecuteReader();
                            MessageBox.Show("KAYDEDİLDİ");
                            connect.Close();

                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Eski Emailinizi Kontrol Ediniz");
                        conn.Close();
                    }
                }

              
            }
        }

      

     
    }
    }

