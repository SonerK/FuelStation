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
    public partial class SIGNUP : Form
    {
  SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
        DataClasses1DataContext DC = new DataClasses1DataContext();   
        void CarBrand()
        {
            var CarBrandList = from CarBrand in DC.CarBrand select CarBrand;
            CB_CarBrand.DisplayMember = "BrandName";
            CB_CarBrand.ValueMember = "BrandID";
            CB_CarBrand.DataSource = CarBrandList;

        }

        void    City()
        {
            var CityList = from City in DC.City select City;
            CB_City.DisplayMember = "CityName";
            CB_City.ValueMember = "CityID";
            CB_City.DataSource = CityList;
        }

        void FuelType()
        {
            SqlCommand komut = new SqlCommand("select * from FuelType", connect);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            CB_FuelType.ValueMember = "FuelTypeID";
            CB_FuelType.DisplayMember = "FuelType";
            CB_FuelType.DataSource = dt;


        }
        void Questions()
        {
            SqlCommand komutQ = new SqlCommand("select * from QUESTIONS", connect);
            SqlDataAdapter adp = new SqlDataAdapter(komutQ);
            DataTable data = new DataTable();
            adp.Fill(data);
            CB_Questions.ValueMember = "QUESTIONID";
            CB_Questions.DisplayMember = "QUESTIONS";
            CB_Questions.DataSource = data;
        }
   
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

       
        public SIGNUP()
        {
            InitializeComponent();
        }
   private void SIGNUP_Load(object sender, EventArgs e)
        {
            City();
            CarBrand();
            FuelType();
            Questions();
          


        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string save_Users = "insert into USERS (UAP,Name,SurName,Password,Email,Phone,Birthday,USID,FuelTypeID,BrandID,ModelID,CityID,DistrictID,LPN,QUESTIONSID,ANSWERS) " +
                    "values (@UAP,@Name,@SurName,@Password,@Email,@Phone,@Birthday,@USID,@FuelTypeID,@BrandID,@ModelID,@CityID,@DistrictID,@LPN,@QUESTIONSID,@ANSWERS)";
                SqlCommand komut_Users = new SqlCommand(save_Users, connect);
               komut_Users.Parameters.AddWithValue("@Name",TB_Name.Text );
                komut_Users.Parameters.AddWithValue("@SurName",TB_SurName.Text );
                komut_Users.Parameters.AddWithValue("@Password", Md5(TB_Password.Text));
                komut_Users.Parameters.AddWithValue("@Email",TB_E_Posta.Text.Trim().ToLower());
                komut_Users.Parameters.AddWithValue("@Phone", TB_PhoneNumber.Text);
                komut_Users.Parameters.AddWithValue("@USID", 3);
                komut_Users.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value);
                komut_Users.Parameters.AddWithValue("@FuelTypeID", Convert.ToInt32(CB_FuelType.SelectedValue));
                komut_Users.Parameters.AddWithValue("@BrandID", Convert.ToInt32(CB_CarBrand.SelectedValue));
                komut_Users.Parameters.AddWithValue("@ModelID", Convert.ToInt32((CB_CarModel.SelectedIndex + 1)));
                komut_Users.Parameters.AddWithValue("@CityID", Convert.ToInt32(CB_City.SelectedValue));
                komut_Users.Parameters.AddWithValue("@DistrictID", Convert.ToInt32((CB_District.SelectedIndex + 1)));
                komut_Users.Parameters.AddWithValue("@QUESTIONSID", Convert.ToInt32(CB_Questions.SelectedValue));
                komut_Users.Parameters.AddWithValue("@ANSWERS", Md5(TB_Answers.Text));
               
            
                komut_Users.Parameters.AddWithValue("@UAP", 1);
                komut_Users.Parameters.AddWithValue("@LPN", TB_LıcensePlateNumber.Text);


                komut_Users.ExecuteNonQuery();

               
                string save_LıcensePlateNumber = "insert into UserCar(BrandID,ModelID,LPN,Email)" + "values (@BrandID,@ModelID,@LPN,@Email)";

                SqlCommand komut_UserCar = new SqlCommand(save_LıcensePlateNumber, connect);
                komut_UserCar.Parameters.AddWithValue("@Email", TB_E_Posta.Text.Trim().ToLower());
                komut_UserCar.Parameters.AddWithValue("@BrandID", Convert.ToInt32(CB_CarBrand.SelectedValue));
                komut_UserCar.Parameters.AddWithValue("@ModelID", Convert.ToInt32((CB_CarModel.SelectedIndex + 1)));
              
                komut_UserCar.Parameters.AddWithValue("@LPN", TB_LıcensePlateNumber.Text);

                komut_UserCar.ExecuteNonQuery();



                string save_StatyonCoin = "insert into COIN(Coin,Email)" + "values (@Coin,@Email)";

                SqlCommand komut_Coin = new SqlCommand(save_StatyonCoin, connect);
                komut_Coin.Parameters.AddWithValue("@Coin", 0);
                komut_Coin.Parameters.AddWithValue("@Email", TB_E_Posta.Text.Trim().ToLower());


                komut_Coin.ExecuteNonQuery();



                connect.Close();
                
                MessageBox.Show("KAYIT EKLENDİ");

                 SIGNUP SIGNUP = new SIGNUP();
                SIGNUP.Close();
                LOGIN LOGIN = new LOGIN();
                LOGIN.Show();

            }

            catch (Exception hata)
            {
                MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
            }

        }

     

    
       private void CB_City_SelectedIndexChanged(object sender, EventArgs e)
        {
           var DistrictList = from District in DC.District where District.CityID == Convert.ToInt32(CB_City.SelectedValue) select District;

           CB_District.DisplayMember = "DistrictName";
           CB_District.ValueMember = "CityID";
           CB_District.DataSource = DistrictList;
        }

        private void CB_CarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CarModelList = from CarModel in DC.CarModel where CarModel.BrandID == Convert.ToInt32(CB_CarBrand.SelectedValue) select CarModel;

            CB_CarModel.DisplayMember = "ModelName";
            CB_CarModel.ValueMember = "BrandID";
            CB_CarModel.DataSource = CarModelList;
        }

        private void CB_FuelType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

