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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FUELSTATION
{
    public partial class AdminUpdateDelete : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
     
        SqlDataAdapter adpt;
        DataTable dt;

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



        public void displaydata()
        {
            try
            {
                connect.Open();
                adpt = new SqlDataAdapter("select * from USERS", connect);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public AdminUpdateDelete()
        {
            InitializeComponent();
        }

        private void AdminUpdateDelete_Load(object sender, EventArgs e)
        {
            P_Person.Visible = false;
            BT_Delete.Enabled = false;
            BT_Update.Enabled = false;
            displaydata();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          
            TB_UID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TB_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TB_Surname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TB_Password.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TB_E_Posta.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TB_TelephoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[9].Value;
            TB_StationCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TB_PersonNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TB_Department.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            TB_USID.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            //(CB_UAP.) = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            BT_Delete.Enabled = true;
            BT_Update.Enabled = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString()==1.ToString())
            {
                CB_UAP.SelectedIndex= 0;
               
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString() == 2.ToString())
            {
                CB_UAP.SelectedIndex = 1;
            }
            
            if (TB_USID.Text == "2")
            {

                P_Person.Visible = true;
            }
            else
            {
                P_Person.Visible = false;
            }
        }


        private void BT_Update_Click(object sender, EventArgs e)
        {
           
                string connectionString = "Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True";

            if (TB_USID.Text == "2") {
                try {
                    
                    
                    string DBUpdate = "update USERS set Name='" + this.TB_Name.Text + "',SurName='" + this.TB_Surname.Text + "',Password='" + Md5(this.TB_Password.Text) + "',Email ='" + this.TB_E_Posta.Text + "',Phone ='" + this.TB_TelephoneNumber.Text + "',BirthDay ='" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',DepID ='" + this.TB_Department.Text + "',StationCode ='" + this.TB_StationCode.Text + "',PersonNumber ='" + this.TB_PersonNumber.Text + "',USID ='" + Convert.ToInt32(this.TB_USID.Text) +"',UAP='"+ ((CB_UAP.SelectedIndex) +1)+ "' where UID ='" + Convert.ToInt32(this.TB_UID.Text) + "'; ";
                    SqlConnection connect = new SqlConnection(connectionString);
                   
                    SqlCommand komut_Update = new SqlCommand(DBUpdate, connect);

                    SqlDataReader read;


                    connect.Open();
                    read = komut_Update.ExecuteReader();
                    MessageBox.Show("KAYDEDİLDİ");
                    displaydata();

                }
                catch (Exception hata)
                {
                    MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                }
            }
            else
            {
                try
                {
                  

                    string DBUpdate = "update USERS set Name='" + this.TB_Name.Text + "',SurName='" + this.TB_Surname.Text + "',Password='" + Md5(this.TB_Password.Text) + "',Email ='" + this.TB_E_Posta.Text + "',Phone ='" + this.TB_TelephoneNumber.Text + "',BirthDay ='" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',USID ='" + Convert.ToInt32(this.TB_USID.Text)+"',UAP='" + ((CB_UAP.SelectedIndex) + 1) + "' where UID ='" + Convert.ToInt32(this.TB_UID.Text) + "'; ";
                    SqlConnection connect = new SqlConnection(connectionString);
                    
                    SqlCommand komut_Update = new SqlCommand(DBUpdate, connect);

                    SqlDataReader read;


                    connect.Open();
                    read = komut_Update.ExecuteReader();
                    MessageBox.Show("KAYDEDİLDİ");
                    displaydata();

                }
                catch (Exception hata)
                {
                    MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
                }
            }
        
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                string connectionString = "Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True";
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                string DBDelete = "update USERS set UAP=@UAP where UID=@UID";

                SqlCommand komut_Delete = new SqlCommand(DBDelete, connect);
                komut_Delete.Parameters.AddWithValue("@UID",TB_UID.Text);
                komut_Delete.Parameters.AddWithValue("@UAP", 2);
                
                komut_Delete.ExecuteNonQuery();
            }
          
            catch (Exception hata)
            {
                MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
            }
            TB_Department.Text = "";
            TB_E_Posta.Text = "";
            TB_Name.Text = "";
            TB_Password.Text = "";
            TB_PersonNumber.Text = "";
            TB_StationCode.Text = "";
            TB_Surname.Text = "";
            TB_TelephoneNumber.Text = "";
            TB_UID.Text = "";
            TB_USID.Text = "";

            connect.Close();
            MessageBox.Show("KAYIT BAŞARIYLA SİLİNDİ");
            displaydata();


        }

       
    }
}
