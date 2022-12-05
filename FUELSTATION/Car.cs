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
    public partial class Car : Form
    {
       // string connectionString = "Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True";
        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
        DataClasses1DataContext DC = new DataClasses1DataContext();
        public Car(string name, string surname, string uid_, string email_)
        {
            InitializeComponent();
            ad = name;
            soyad = surname;
            uid = uid_;
            email = email_;

        }
        string ad, soyad, uid, email;

        void CarBrandNewCar()
        {
            var CarBrandList = from CarBrand in DC.CarBrand select CarBrand;
            CB_CarBrandNewCar.DisplayMember = "BrandName";
            CB_CarBrandNewCar.ValueMember = "BrandID";
            CB_CarBrandNewCar.DataSource = CarBrandList;

        }
        void CarBrandCarUpdate()
        {
            var CarBrandList = from CarBrand in DC.CarBrand select CarBrand;
            CB_CarBrandCarUpdate.DisplayMember = "BrandName";
            CB_CarBrandCarUpdate.ValueMember = "BrandID";
            CB_CarBrandCarUpdate.DataSource = CarBrandList;

        }
        void FuelTypeNewCar()
        {
            SqlCommand komut = new SqlCommand("select * from FuelType", connect);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            CB_FuelTypeNewCar.ValueMember = "FuelTypeID";
            CB_FuelTypeNewCar.DisplayMember = "FuelType";
            CB_FuelTypeNewCar.DataSource = dt;


        }
        void FuelTypeCarUpdate()
        {
            SqlCommand komut = new SqlCommand("select * from FuelType", connect);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            CB_FuelTypeCarUpdate.ValueMember = "FuelTypeID";
            CB_FuelTypeCarUpdate.DisplayMember = "FuelType";
            CB_FuelTypeCarUpdate.DataSource = dt;


        }
        
        private void Car_Load(object sender, EventArgs e)
        {

            
          
            P_CarInfo.Visible = false;
            RB_CarUpdate.Checked = false;
            RB_NewCar.Checked = false;
        }
        private void RB_CarUpdate_CheckedChanged(object sender, EventArgs e)
        {


            CarBrandCarUpdate();
            FuelTypeCarUpdate();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }   
        private void RB_NewCar_CheckedChanged(object sender, EventArgs e)
        {
            CarBrandNewCar();
            FuelTypeNewCar();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void CB_CarBrandNewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CarModelList = from CarModel in DC.CarModel where CarModel.BrandID == Convert.ToInt32(CB_CarBrandNewCar.SelectedValue) select CarModel;

            CB_CarModelNewCar.DisplayMember = "ModelName";
            CB_CarModelNewCar.ValueMember = "BrandID";
            CB_CarModelNewCar.DataSource = CarModelList;
        }

        private void BT_LN_Click(object sender, EventArgs e)
        {
            
            try
            {
                connect.Open();
                string LPN = " select * from UserCar where Email='"+ email + "'; ";
                
                
                SqlCommand komut_LPN = new SqlCommand(LPN, connect);
                //komut_LPN.Parameters.AddWithValue("@LPN", CB_Car.Text.ToString());
                // komut_LPN.ExecuteNonQuery();

                CB_Car.DisplayMember = "LPN";
                    CB_Car.ValueMember = "Email";
                   // CB_CarBrandNewCar.DataSource = CarBrandList;
                


                connect.Close();





            }
           
            
            catch (Exception hata)
            {


                MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                connect.Close();
            }
        }

        private void CB_CarBrandCarUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CarModelList = from CarModel in DC.CarModel where CarModel.BrandID == Convert.ToInt32(CB_CarBrandCarUpdate.SelectedValue) select CarModel;

            CB_CarModelCarUpdate.DisplayMember = "ModelName";
            CB_CarModelCarUpdate.ValueMember = "BrandID";
            CB_CarModelCarUpdate.DataSource = CarModelList;
        }

        private void BT_SaveNewCar_Click(object sender, EventArgs e)
        {
            //if(TB_EpostaNewCar.Text == ""||TB_LicensePlateNumberNewCar.Text=="")
            //{ 
            //    MessageBox.Show("LÜTFEN E POSTA VE PLAKA KISMINI BOŞ BIRAKMAYINIZ.");
            //}
            //else
            //{
                connect.Open();
                        try
                        {


                            //  string DBUpdate = "update USERS set Name='"+ad+"' where Email ='"+email+"'";
                            string add = "insert into UserCar (Email,LPN,BrandID,ModelID,Uid) values (@Email,@LPN,@BrandID,@ModelID,@Uid)";
                            //müşteri y;ani 3. kullanıcı oluşturulduğunda otomatik bir sayı üretilecek bu sayı if döngüsüne alınıp aynı sayı üretilmediği kontrol edilecek 
                            //ekstradan veri tabanında plaka tablosunun içine araç girişi de olacak adı belki değiştirirsin böylelikle 1 kullanıcı 1 den fazla araç kaydı olmuş olacak.
                       
                            SqlCommand komut_Update = new SqlCommand(add, connect);
                            komut_Update.Parameters.AddWithValue("@Email",email);
                            komut_Update.Parameters.AddWithValue("@LPN", TB_LicensePlateNumberNewCar.Text);
                            komut_Update.Parameters.AddWithValue("@BrandID", CB_CarBrandNewCar.SelectedValue);
                            komut_Update.Parameters.AddWithValue("@ModelID", CB_CarModelNewCar.SelectedIndex+1);
                            komut_Update.Parameters.AddWithValue("@Uid", uid);
                            komut_Update.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("KAYDEDİLDİ");

                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                            connect.Close();
                        }
        }
      
        private void BT_UpdateCar_Click(object sender, EventArgs e)
        {
           
          /*  else
            {
                connect.Open();
                SqlCommand giris = new SqlCommand("select * from USERS where Email='" + TB_EpostaUpdateCar.Text.Trim() + "'", connect);
                SqlDataReader oku = giris.ExecuteReader();

                if (oku.Read())
                {
                    try
                    {
                        if (Convert.ToInt32(oku["USID"]) == 3)
                        {
                            try
                            {
                                //P_CarInfo.Visible = true;
                                if (oku["Email"].ToString() == "Email")
                                {
                                    var CarList = from LPN in DC.UserCar select LPN;
                                    CB_Car.DisplayMember = "LPN";
                                    CB_Car.ValueMember = "UId";
                                    CB_Car.DataSource = CarList;
                                }
                            }
                             catch (Exception hata)
                    {
                        MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                        connect.Close();
                    }
                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                        connect.Close();
                    }
                }


                else
                {
                    MessageBox.Show("Hatalı e posta");
                    connect.Close();
                }
          

            }
          */


        }
    }
}
