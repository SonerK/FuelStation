using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public PumperPersonel(string name, string surname, string uid_, string email_)
        {
            InitializeComponent();
            ad = name;
            soyad = surname;
            uid = uid_;
            email = email_;
        }
        string ad, soyad, uid, email;
    }
}
