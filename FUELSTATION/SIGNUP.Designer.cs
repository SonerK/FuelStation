namespace FUELSTATION
{
    partial class SIGNUP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_SurName = new System.Windows.Forms.TextBox();
            this.TB_E_Posta = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.TB_LıcensePlateNumber = new System.Windows.Forms.TextBox();
            this.CB_FuelType = new System.Windows.Forms.ComboBox();
            this.CB_CarBrand = new System.Windows.Forms.ComboBox();
            this.CB_CarModel = new System.Windows.Forms.ComboBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CB_District = new System.Windows.Forms.ComboBox();
            this.TB_ClientNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(101, 12);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 22);
            this.TB_Name.TabIndex = 0;
            // 
            // TB_SurName
            // 
            this.TB_SurName.Location = new System.Drawing.Point(101, 55);
            this.TB_SurName.Name = "TB_SurName";
            this.TB_SurName.Size = new System.Drawing.Size(100, 22);
            this.TB_SurName.TabIndex = 1;
            // 
            // TB_E_Posta
            // 
            this.TB_E_Posta.Location = new System.Drawing.Point(101, 110);
            this.TB_E_Posta.Name = "TB_E_Posta";
            this.TB_E_Posta.Size = new System.Drawing.Size(100, 22);
            this.TB_E_Posta.TabIndex = 2;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(103, 174);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '•';
            this.TB_Password.Size = new System.Drawing.Size(100, 22);
            this.TB_Password.TabIndex = 3;
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.Location = new System.Drawing.Point(103, 235);
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.TB_PhoneNumber.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 285);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(81, 328);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(121, 24);
            this.CB_City.TabIndex = 6;
            this.CB_City.SelectedIndexChanged += new System.EventHandler(this.CB_City_SelectedIndexChanged);
            // 
            // TB_LıcensePlateNumber
            // 
            this.TB_LıcensePlateNumber.Location = new System.Drawing.Point(417, 12);
            this.TB_LıcensePlateNumber.Name = "TB_LıcensePlateNumber";
            this.TB_LıcensePlateNumber.Size = new System.Drawing.Size(121, 22);
            this.TB_LıcensePlateNumber.TabIndex = 8;
            // 
            // CB_FuelType
            // 
            this.CB_FuelType.FormattingEnabled = true;
            this.CB_FuelType.Location = new System.Drawing.Point(417, 85);
            this.CB_FuelType.Name = "CB_FuelType";
            this.CB_FuelType.Size = new System.Drawing.Size(121, 24);
            this.CB_FuelType.TabIndex = 9;
            // 
            // CB_CarBrand
            // 
            this.CB_CarBrand.FormattingEnabled = true;
            this.CB_CarBrand.Location = new System.Drawing.Point(417, 141);
            this.CB_CarBrand.Name = "CB_CarBrand";
            this.CB_CarBrand.Size = new System.Drawing.Size(121, 24);
            this.CB_CarBrand.TabIndex = 10;
            this.CB_CarBrand.SelectedIndexChanged += new System.EventHandler(this.CB_CarBrand_SelectedIndexChanged);
            // 
            // CB_CarModel
            // 
            this.CB_CarModel.FormattingEnabled = true;
            this.CB_CarModel.Location = new System.Drawing.Point(417, 202);
            this.CB_CarModel.Name = "CB_CarModel";
            this.CB_CarModel.Size = new System.Drawing.Size(121, 24);
            this.CB_CarModel.TabIndex = 11;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(491, 389);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(113, 23);
            this.BT_Save.TabIndex = 13;
            this.BT_Save.Text = "KAYDET";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "ARAÇ MODELİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "ARAÇ MARKASI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "İLÇE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "İL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "DOĞUM TARİHİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "SOYAD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "YAKIT TÜRÜ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "PLAKA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "TELEFON NO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "ŞİFRE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "E-MAİL";
            // 
            // CB_District
            // 
            this.CB_District.FormattingEnabled = true;
            this.CB_District.Location = new System.Drawing.Point(81, 381);
            this.CB_District.Name = "CB_District";
            this.CB_District.Size = new System.Drawing.Size(121, 24);
            this.CB_District.TabIndex = 7;
            // 
            // TB_ClientNumber
            // 
            this.TB_ClientNumber.Location = new System.Drawing.Point(417, 259);
            this.TB_ClientNumber.Name = "TB_ClientNumber";
            this.TB_ClientNumber.Size = new System.Drawing.Size(121, 22);
            this.TB_ClientNumber.TabIndex = 29;
            // 
            // SIGNUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_ClientNumber);
            this.Controls.Add(this.CB_District);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.CB_CarModel);
            this.Controls.Add(this.CB_CarBrand);
            this.Controls.Add(this.CB_FuelType);
            this.Controls.Add(this.TB_LıcensePlateNumber);
            this.Controls.Add(this.CB_City);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TB_PhoneNumber);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_E_Posta);
            this.Controls.Add(this.TB_SurName);
            this.Controls.Add(this.TB_Name);
            this.Name = "SIGNUP";
            this.Text = "SIGNUP";
            this.Load += new System.EventHandler(this.SIGNUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_SurName;
        private System.Windows.Forms.TextBox TB_E_Posta;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_PhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.TextBox TB_LıcensePlateNumber;
        private System.Windows.Forms.ComboBox CB_FuelType;
        private System.Windows.Forms.ComboBox CB_CarBrand;
        private System.Windows.Forms.ComboBox CB_CarModel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CB_District;
        private System.Windows.Forms.TextBox TB_ClientNumber;
    }
}