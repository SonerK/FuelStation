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
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FUELSTATION
{
    public partial class AdminNewAccount : Form
    {
        public AdminNewAccount()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=TULPAR;Initial Catalog=GASSTATION;Integrated Security=True");
        DataClasses1DataContext DC = new DataClasses1DataContext();
        /* SqlDataAdapter adpt;
         DataTable dt;*/
        void PersonDepartment()
        {
            var PersonDepartmentList = from Department in DC.Department select Department;
            CB_Department.DisplayMember = "DepName";
            CB_Department.ValueMember = "DepID";
            CB_Department.DataSource = PersonDepartmentList;

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

        /*  public void displaydata()
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
        */
        private void BT_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    if (RB_Admin.Checked)
                    {


                        connect.Open();
                        string Save_Admin = "Insert into USERS(Name,SurName,Password,Email,Phone,BirthDay,USID)" +
                           "values(@Name,@SurName,@Password,@Email,@Phone,@BirthDay,@USID)";
                        SqlCommand komut_Admin = new SqlCommand(Save_Admin, connect);

                        komut_Admin.Parameters.AddWithValue("@Name", TB_Name.Text);
                        komut_Admin.Parameters.AddWithValue("@SurName", TB_SurName.Text);
                        komut_Admin.Parameters.AddWithValue("@Password", Md5(TB_Password.Text));
                        komut_Admin.Parameters.AddWithValue("@Email", TB_E_Mail.Text);
                        komut_Admin.Parameters.AddWithValue("@Phone", TB_PhoneNumber.Text);
                        komut_Admin.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value);
                        komut_Admin.Parameters.AddWithValue("@USID", 1);

                        komut_Admin.ExecuteNonQuery();


                        connect.Close();

                        MessageBox.Show("KAYIT EKLENDİ");
                    }
                    else if (RB_Person.Checked)
                    {
                        connect.Open();
                        string Save_Person = "Insert into USERS(Name,SurName,Password,Email,Phone,BirthDay,DepID,StationCode,PersonNumber,USID)" +
                           "values(@Name,@SurName,@Password,@Email,@Phone,@BirthDay,@DepID,@StationCode,@PersonNumber,@USID)";
                        SqlCommand komut_Person = new SqlCommand(Save_Person, connect);

                        komut_Person.Parameters.AddWithValue("@Name", TB_Name.Text);
                        komut_Person.Parameters.AddWithValue("@SurName", TB_SurName.Text);
                        komut_Person.Parameters.AddWithValue("@Password", Md5(TB_Password.Text));
                        komut_Person.Parameters.AddWithValue("@Email", TB_E_Mail.Text);
                        komut_Person.Parameters.AddWithValue("@Phone", TB_PhoneNumber.Text);
                        komut_Person.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value);
                        komut_Person.Parameters.AddWithValue("@DepID", CB_Department.SelectedValue);
                        komut_Person.Parameters.AddWithValue("@StationCode", TB_StationCode.Text);
                        komut_Person.Parameters.AddWithValue("@PersonNumber", TB_PersonNumber.Text);
                        komut_Person.Parameters.AddWithValue("@USID", 2);

                        komut_Person.ExecuteNonQuery();


                        connect.Close();

                        MessageBox.Show("KAYIT EKLENDİ");
                    }
            }

            catch (Exception hata)
            {
                MessageBox.Show("HATA MEYDANA GELDİ   " + hata.Message);
            }

        }

        private void AdminNewAccount_Load(object sender, EventArgs e)
        {

            P_Person.Visible = false;


        }

        private void RB_Admin_CheckedChanged(object sender, EventArgs e)
        {
            P_Person.Visible = false;

        }

        private void RB_Person_CheckedChanged(object sender, EventArgs e)
        {
            P_Person.Visible = true;
            PersonDepartment();
        }
    }
}

        
      

        

   

       
    

