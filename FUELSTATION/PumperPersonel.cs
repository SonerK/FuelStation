using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
    public partial class PumperPersonel : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
        public PumperPersonel()
        {
            InitializeComponent();
          
        }
        void Fuel_Benzin()
        {
         
          connect.Open();
                        SqlCommand Coin = new SqlCommand("select FuelSell from FuelType where FuelTypeID=@Benzin", connect);
                        Coin.Parameters.AddWithValue("@Benzin",1);
                        SqlDataReader read = Coin.ExecuteReader();
                        read.Read();
                        RB_Benzin.Text =read["FuelSell"].ToString();
                        connect.Close();
         
        }
        void Fuel_Mazot()
        {

            connect.Open();
            SqlCommand Coin = new SqlCommand("select FuelSell from FuelType where FuelTypeID=@Mazot", connect);
            Coin.Parameters.AddWithValue("@Mazot",2);
            SqlDataReader read = Coin.ExecuteReader();
            read.Read();
            RB_Mazot.Text = read["FuelSell"].ToString();
            connect.Close();

        }
        void Fuel_Gaz()
        {

            connect.Open();
            SqlCommand Coin = new SqlCommand("select FuelSell from FuelType where FuelTypeID=@Gaz", connect);
            Coin.Parameters.AddWithValue("@Gaz", 3);
            SqlDataReader read = Coin.ExecuteReader();
            read.Read();
            RB_Gaz.Text = read["FuelSell"].ToString();
            connect.Close();

        }
        void Fuel_Elektrik()
        {

            connect.Open();
            SqlCommand Coin = new SqlCommand("select FuelSell from FuelType where FuelTypeID=@Elektrik", connect);
            Coin.Parameters.AddWithValue("@Elektrik",4);
            SqlDataReader read = Coin.ExecuteReader();
            read.Read();
            RB_Elektrik.Text = read["FuelSell"].ToString();
            connect.Close();

        }





        private void PumperPersonel_Load(object sender, EventArgs e)
        {
           
            GB_Pumper.Visible = false;
            GB_Coin.Visible = false;
            GB_UCoin.Visible = false;

            Fuel_Benzin();
            Fuel_Mazot();
            Fuel_Gaz();
            Fuel_Elektrik();




        }

        private void RB_Var_CheckedChanged(object sender, EventArgs e)
        {
            GB_Coin.Visible = true;
        }

      
        private void RB_Yok_CheckedChanged(object sender, EventArgs e)
        {
            GB_Coin.Visible = false;
          
            GB_UCoin.Visible = false;
        }

        
       
        private void BT_LPNSearch_Click(object sender, EventArgs e)
        {

            try
            {

                connect.Open();
                //SqlCommand giris = new SqlCommand("select Email from UserCar where LPN=", connect);
               
                SqlCommand giris = new SqlCommand("select Email from UserCar where LPN=@p1", connect);
                giris.Parameters.AddWithValue("@p1", TB_LıcensePlateNummber.Text);
                SqlDataReader oku = giris.ExecuteReader();

                oku.Read();
                    if (oku.HasRows == true)
                    {
                   
                    GB_Pumper.Visible = true;
                    string E_posta = oku["Email"].ToString();
                    connect.Close();
                    if (RB_Var.Checked == false)
                    {
                        connect.Open();
                        SqlCommand Coin = new SqlCommand("select Coin from COIN where Email=@p2", connect);
                        Coin.Parameters.AddWithValue("@p2",E_posta);
                        SqlDataReader read = Coin.ExecuteReader();
                        read.Read();
                        L_Coin.Text =read["Coin"].ToString();
                        connect.Close();

                    }
                    
                  

                }
                    else if (oku.HasRows == false)
                    {

                        MessageBox.Show("lütfen plakayı kontrol edeiniz");
                    }
               
                //GB_Pumper.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "hata var la");}
        }
        Double Coin,FuelCash,Cash,B,M,G,E;

        

        public void BT_SaveCoin_Click(object sender, EventArgs e)
        {
            Coin = Convert.ToDouble(TB_Coin.Text);
           



            if (Convert.ToDouble(L_Coin.Text) < Coin)
            {
                MessageBox.Show("Kullanmak istediğiniz bakiye mevcut  bakiyenizden fazla olamaz");
            }
            else if (Coin <= 0)
            {
                MessageBox.Show("Kullanmak istediğiniz bakiye 0'dan küçük olamaz.");
            }
            else if (Coin <= 5)
            {
                MessageBox.Show("Minimum bakiye kullanımı 5 Coin'den az olamaz.");
            }

            else
            {
                GB_Coin.Visible= false;
                GB_UCoin.Visible= true;
                L_UCoin.Text = Coin.ToString();
           
            }
        }
       
        
        private void BT_Calculate_Click(object sender, EventArgs e)
        {
            if (RB_Var.Checked==true)
            {
                if (TB_Coin.Text == "" || TB_FuelCash.Text == "")
                {
                    MessageBox.Show("LÜTFEN KULLANACAĞINIZ COİN MİKTARINI VE ALACAĞINIZ YAKIT MİKTARINI GİRİNİZ");
                }
                else
                {
                    FuelCash = Convert.ToDouble(TB_FuelCash.Text);
                    Cash = FuelCash - Coin;
                    TB_Cash.Text = Cash.ToString();
                    if (RB_Benzin.Checked==true) {
                        B = Convert.ToDouble(TB_FuelCash.Text) / Convert.ToDouble(RB_Benzin.Text);
                        TB_Fuel.Text = B.ToString();
                    }
                    else if(RB_Mazot.Checked==true)
                    {
                        M = Convert.ToDouble(TB_FuelCash.Text) / Convert.ToDouble(RB_Mazot.Text);
                        TB_Fuel.Text = M.ToString();
                    }
                    else if(RB_Gaz.Checked==true)
                    {
                        G = Convert.ToDouble(TB_FuelCash.Text) / Convert.ToDouble(RB_Gaz.Text);
                        TB_Fuel.Text = G.ToString();
                    }
                    else if(RB_Elektrik.Checked==true)
                    {
                        E = Convert.ToDouble(TB_FuelCash.Text) / Convert.ToDouble(RB_Elektrik.Text);
                        TB_Fuel.Text = E.ToString();
                    }
                }
            }
            else if(RB_Yok.Checked==true)
            {

                if (TB_FuelCash.Text == "")
                {
                    MessageBox.Show("LÜTFEN KULLANACAĞINIZ COİN MİKTARINI VE ALACAĞINIZ YAKIT MİKTARINI GİRİNİZ");
                }
                else
                {
                    TB_Cash.Text = TB_FuelCash.Text;
                   
                }
            }
        }
    }
    }


