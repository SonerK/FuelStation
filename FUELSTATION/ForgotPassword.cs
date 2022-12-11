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

namespace FUELSTATION
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
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
        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            Questions();
           GB_Questions.Visible = false;
        }

        private void BT_GO_Click(object sender, EventArgs e)
        {
            TB_E_Posta.Enabled = false;
            try
            {

                connect.Open();
                SqlCommand giris = new SqlCommand("select * from USERS where Email='" + TB_E_Posta.Text.Trim() + "'", connect);
                SqlDataReader oku = giris.ExecuteReader();


                if (oku.Read())
                {
                    // Convert.ToInt32(oku["USID"]) == 3
                    //oku["Email"].ToString() == TB_E_Posta.Text
                    if (Convert.ToInt32(oku["USID"]) == 3)
                    {
                       GB_Questions.Visible = true;

                    }
                }



                else
                {
                    MessageBox.Show("LÜTFEN E MAİL ADRESİNİZİ KONTROL EDİNİZ.");
                    TB_E_Posta.Enabled = true;
                    connect.Close();
                }
               

            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
            }
            connect.Close();
        }
        

        private void BT_Control_Click(object sender, EventArgs e)
        {
            TB_E_Posta.Enabled = true;

            try
            {
                connect.Open();
                SqlCommand questions = new SqlCommand("Select USID,Email,ANSWERS from USERS where Email='" + TB_E_Posta.Text.Trim() + "' and ANSWERS='" + Md5(TB_Answers.Text) + "'", connect);
                SqlDataReader read = questions.ExecuteReader();
                if (read.Read())
                {
                    if (Convert.ToInt32(read["USID"]) == 3)
                    {
                        PasswordUpdate passwordUpdate = new PasswordUpdate(read["Email"].ToString());
                        passwordUpdate.Show();
                        this.Close();
                        connect.Close();

                    }

                  
                    else
                    {
                        MessageBox.Show("LÜTFEN CEVABINIZI KONTROL EDİNİZ");
                        TB_E_Posta.Enabled = false;
                    }
                }
            }
            catch (Exception hata)
            { MessageBox.Show(hata.Message + "looooooooooooo"); }
            
        }

        private void GB_Questions_Enter(object sender, EventArgs e)
        {

        }
    }
    }




