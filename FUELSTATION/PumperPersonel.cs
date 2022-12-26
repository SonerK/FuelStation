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
        decimal  CoinAndCoin,ClientCoin,UCoin;
        decimal StatyonCoin;

        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
        public PumperPersonel()
        {
            InitializeComponent();

        }
        void Fuel_Benzin()
        {

            connect.Open();
            SqlCommand Coin = new SqlCommand("select FuelSell from FuelType where FuelTypeID=@Benzin", connect);
            Coin.Parameters.AddWithValue("@Benzin", 1);
            SqlDataReader read = Coin.ExecuteReader();
            read.Read();
            RB_Benzin.Text = read["FuelSell"].ToString();
            connect.Close();

        }
        void Fuel_Mazot()
        {

            connect.Open();
            SqlCommand Coin = new SqlCommand("select FuelSell from FuelType where FuelTypeID=@Mazot", connect);
            Coin.Parameters.AddWithValue("@Mazot", 2);
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
            Coin.Parameters.AddWithValue("@Elektrik", 4);
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
            
            TB_CashCoin.Enabled=false;
            TB_Fuel.Enabled=false;
            TB_Cash.Enabled=false;

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



        public void BT_LPNSearch_Click(object sender, EventArgs e)
        {

            try
            {

                connect.Open();
               
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
                        Coin.Parameters.AddWithValue("@p2", E_posta);
                        SqlDataReader read = Coin.ExecuteReader();
                        read.Read();
                        L_Coin.Text = read["Coin"].ToString();
                        connect.Close();

                    }



                }
                else if (oku.HasRows == false)
                {

                    MessageBox.Show("lütfen plakayı kontrol edeiniz");
                }

                //GB_Pumper.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "hata var la"); }
        }
      
        private void GB_Pumper_Enter(object sender, EventArgs e)
        {

        }

        private void TB_deneme_Click(object sender, EventArgs e)
        {



            //connect.Open();
            //    SqlCommand sql = new SqlCommand("update COIN set Coin='" + CoinAndCoin + " 'where Email='" + E_posta + "'",connect);
            //    if (sql.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("KAYIT BAŞARILI FALAN ");
            //    }
            //    else
            //        {
            //    MessageBox.Show("kayıt başarısıszx");
            //}

            
        } 
        decimal Coin, FuelCash, Cash;
        decimal B, M, G, E;

        decimal CoinUpdate_2;
        private void BT_SaveCoin_Click(object sender, EventArgs e)
        {
            TB_Coin.Enabled = false;
            if (TB_Coin.Text == "")
            { MessageBox.Show("Lütfen kullancağınız coin miktarını giriniz."); }
            else
            {
                Coin = Convert.ToDecimal(TB_Coin.Text);




                if (Convert.ToDecimal(L_Coin.Text) < Coin)
                {
                    MessageBox.Show("Kullanmak istediğiniz bakiye mevcut  bakiyenizden fazla olamaz");
                }
                else if (Coin <= 0)
                {
                    MessageBox.Show("Kullanmak istediğiniz bakiye 0'dan küçük olamaz.");
                }
                else if (Coin <= 1)
                {
                    MessageBox.Show("Minimum bakiye kullanımı 5 Coin'den az olamaz.");
                }

                else
                {
                    GB_Coin.Visible = false;
                    GB_UCoin.Visible = true;
                    L_UCoin.Text = Coin.ToString();
                    CoinUpdate_2 = Convert.ToDecimal(L_Coin.Text) - Convert.ToDecimal(TB_Coin.Text);
                    L_Kalan.Text= CoinUpdate_2.ToString();
                }
            }
        }


        private void BT_Calculate_Click(object sender, EventArgs e)
        {
           
            if (RB_Var.Checked == true)
            {
                if (TB_Coin.Text == "" || TB_FuelCash.Text == "")
                {
                    MessageBox.Show("LÜTFEN KULLANACAĞINIZ COİN MİKTARINI VE ALACAĞINIZ YAKIT MİKTARINI GİRİNİZ");
                }
                else
                {
                    FuelCash = Convert.ToDecimal(TB_FuelCash.Text);
                    Cash = FuelCash - Coin;
                    TB_Cash.Text = Cash.ToString();


                    StatyonCoin = Math.Round(StatyonCoin, 2);
                    StatyonCoin = (Convert.ToDecimal(TB_Cash.Text) * 3) / 100;
                    TB_CashCoin.Text = StatyonCoin.ToString();


                    if (RB_Benzin.Checked == true) 
                    {
                        
                        B = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Benzin.Text);
                        B = Math.Round(B, 2);
                        TB_Fuel.Text = B.ToString();
                         L_Fuell.Text = "ALINAN YAKIT MİKTARI (L) :";
                    }
                    else if (RB_Mazot.Checked == true)
                    {
                        
                        M = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Mazot.Text);
                        M = Math.Round(M, 2);
                        TB_Fuel.Text = M.ToString();
                        L_Fuell.Text = "ALINAN YAKIT MİKTARI (L) :";
                    }
                    else if (RB_Gaz.Checked == true)
                    {
                     
                        G = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Gaz.Text);
                        G = Math.Round(G, 2);
                        TB_Fuel.Text = G.ToString();
                        L_Fuell.Text = "ALINAN YAKIT MİKTARI (L) :";
                    }
                    else if (RB_Elektrik.Checked == true)
                    {
                       
                        E = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Elektrik.Text);
                        E = Math.Round(E, 2);
                        TB_Fuel.Text = E.ToString();
                        L_Fuell.Text = "ALINAN ELEKTRİK (DC) MİKTARI(kWh)";
                    }
                }
            }
            else if (RB_Yok.Checked == true)
            {

                if (TB_FuelCash.Text == "")
                {
                    MessageBox.Show("LÜTFEN ALACAĞINIZ YAKIT MİKTARINI GİRİNİZ");
                }
                else
                {
                    TB_Cash.Text = TB_FuelCash.Text;
                    if (RB_Benzin.Checked == true)
                    {
                       
                      
                        B = Math.Round(B, 2);
                        B = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Benzin.Text);
                        TB_Fuel.Text = B.ToString();
                      
                    }
                    else if (RB_Mazot.Checked == true)
                    {
                       
                        
                         M = Math.Round(M, 2);
                         M = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Mazot.Text);
                        TB_Fuel.Text = M.ToString();
                       
                    }
                    else if (RB_Gaz.Checked == true)
                    {
                       
                       
                        G = Math.Round(G, 2);
                        G = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Gaz.Text);
                        TB_Fuel.Text = G.ToString();
                       
                    }
                    else if (RB_Elektrik.Checked == true)
                    {
                      
                       
                        E = Math.Round(E, 2);
                        E = Convert.ToDecimal(TB_FuelCash.Text) / Convert.ToDecimal(RB_Elektrik.Text);
                        TB_Fuel.Text = E.ToString();
                       
                    }


                }
            }
            else
            {
                MessageBox.Show("Lütfen Coin Kullanımını Seçiniz");
            }
        }


         decimal CoinAndCoin1;
        private void BT_Save_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True";
            

           
            if (TB_Cash.Text == "")
            {
                MessageBox.Show("Lütfen Alınan Yakıt Ücretini 'ÜCRETİ HESAPLA' butonuna basarak hesaplayınız.");
            }
            else
            {
                 UCoin = Convert.ToDecimal(L_Coin.Text);
                CoinAndCoin = UCoin + Convert.ToDecimal(StatyonCoin);
               
                    connect.Open();

                    SqlCommand giris = new SqlCommand("select Email from UserCar where LPN=@p1", connect);
                    giris.Parameters.AddWithValue("@p1", TB_LıcensePlateNummber.Text);
                    SqlDataReader oku = giris.ExecuteReader();

                    oku.Read();
                    if (oku.HasRows == true)
                    {

                        GB_Pumper.Visible = true;
                       string E_posta = oku["Email"].ToString();

                    connect.Close();


                    try
                    {
                        connect.Open();

                            
                            
                            SqlCommand Coin = new SqlCommand("select * from COIN where Email=@p2", connect);
                            Coin.Parameters.AddWithValue("@p2", E_posta);
                            SqlDataReader readd = Coin.ExecuteReader();
                            readd.Read();
                            ClientCoin = Convert.ToDecimal(readd["Coin"]);
                          //  L_UCoin.Text = ClientCoin.ToString();
                        readd.Close();

                       


                        CoinAndCoin1 = Convert.ToDecimal(TB_CashCoin.Text) + Convert.ToDecimal(L_Kalan.Text);
                        
                         
                        // SqlCommand CoinUpdate = new SqlCommand("update COIN set Coin='" + CoinAndCoin + "'where Email='" + E_posta + "'",connect);
                        SqlCommand CoinUpdate = new SqlCommand("update COIN set Coin=@Coin where Email=@Email", connect);

                        CoinUpdate.Parameters.Add("@Coin", SqlDbType.Decimal).Value = CoinAndCoin1;
                        CoinUpdate.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = E_posta;
                       

                        int rowsAffected = CoinUpdate.ExecuteNonQuery();
                        SqlDataReader read = CoinUpdate.ExecuteReader();

                        if (rowsAffected > 0)
                        {
                            
                           
                            
                            connect.Close();
                            MessageBox.Show("yakıt alımı başarılı");
                            
                        }

                        else
                        {
                            MessageBox.Show("yakıt alımı başarıısz");
                        }

                        
                          





                    }
                        catch (Exception ex) { MessageBox.Show(ex.Message + "hata var hay sikicem"); }
                       
                    
                }



                       



                    

                
                      




                      


                        
                        //read = komut_Update.ExecuteReader();
                        //MessageBox.Show("YAKIT ALIMI BAŞARILI");


                    }
                  
                }
              
                // Deneme.Text = StatyonCoin.ToString();

            }
        }
    

    
    


