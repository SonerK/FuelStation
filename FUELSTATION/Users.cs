using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUELSTATION
{
    public partial class Users : Form
    {
        public Users(string name,string surname,string uid_,string email_)
        {
            InitializeComponent();
            ad = name;
            soyad= surname;
            uid= uid_;
            email= email_;
            
        }
        string ad, soyad, uid, email;

        private void button3_Click(object sender, EventArgs e)
        {
            UsersUpdate update= new UsersUpdate();
            update.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car car = new Car(ad, soyad, uid, email);
            car.Show();
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
