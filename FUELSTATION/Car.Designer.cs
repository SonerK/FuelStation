namespace FUELSTATION
{
    partial class Car
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Car = new System.Windows.Forms.ComboBox();
            this.P_CarInfo = new System.Windows.Forms.Panel();
            this.TB_LicensePlateNumberCarUpdate = new System.Windows.Forms.TextBox();
            this.CB_FuelTypeCarUpdate = new System.Windows.Forms.ComboBox();
            this.CB_CarModelCarUpdate = new System.Windows.Forms.ComboBox();
            this.CB_CarBrandCarUpdate = new System.Windows.Forms.ComboBox();
            this.BT_SaveCarUpdate = new System.Windows.Forms.Button();
            this.RB_CarUpdate = new System.Windows.Forms.RadioButton();
            this.RB_NewCar = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_LicensePlateNumberNewCar = new System.Windows.Forms.TextBox();
            this.BT_SaveNewCar = new System.Windows.Forms.Button();
            this.CB_CarModelNewCar = new System.Windows.Forms.ComboBox();
            this.CB_CarBrandNewCar = new System.Windows.Forms.ComboBox();
            this.CB_FuelTypeNewCar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_LN = new System.Windows.Forms.Button();
            this.P_CarInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ARAÇ MODELİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "PLAKA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "YAKIT TÜRÜ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ARAÇ MARKASI:";
            // 
            // CB_Car
            // 
            this.CB_Car.FormattingEnabled = true;
            this.CB_Car.Location = new System.Drawing.Point(180, 81);
            this.CB_Car.Name = "CB_Car";
            this.CB_Car.Size = new System.Drawing.Size(121, 24);
            this.CB_Car.TabIndex = 54;
            // 
            // P_CarInfo
            // 
            this.P_CarInfo.Controls.Add(this.label3);
            this.P_CarInfo.Controls.Add(this.label4);
            this.P_CarInfo.Controls.Add(this.label2);
            this.P_CarInfo.Controls.Add(this.label1);
            this.P_CarInfo.Controls.Add(this.TB_LicensePlateNumberCarUpdate);
            this.P_CarInfo.Controls.Add(this.CB_FuelTypeCarUpdate);
            this.P_CarInfo.Controls.Add(this.CB_CarModelCarUpdate);
            this.P_CarInfo.Controls.Add(this.CB_CarBrandCarUpdate);
            this.P_CarInfo.Location = new System.Drawing.Point(54, 141);
            this.P_CarInfo.Name = "P_CarInfo";
            this.P_CarInfo.Size = new System.Drawing.Size(292, 133);
            this.P_CarInfo.TabIndex = 53;
            // 
            // TB_LicensePlateNumberCarUpdate
            // 
            this.TB_LicensePlateNumberCarUpdate.Location = new System.Drawing.Point(126, 4);
            this.TB_LicensePlateNumberCarUpdate.Name = "TB_LicensePlateNumberCarUpdate";
            this.TB_LicensePlateNumberCarUpdate.Size = new System.Drawing.Size(121, 22);
            this.TB_LicensePlateNumberCarUpdate.TabIndex = 20;
            // 
            // CB_FuelTypeCarUpdate
            // 
            this.CB_FuelTypeCarUpdate.FormattingEnabled = true;
            this.CB_FuelTypeCarUpdate.Location = new System.Drawing.Point(126, 32);
            this.CB_FuelTypeCarUpdate.Name = "CB_FuelTypeCarUpdate";
            this.CB_FuelTypeCarUpdate.Size = new System.Drawing.Size(121, 24);
            this.CB_FuelTypeCarUpdate.TabIndex = 17;
            // 
            // CB_CarModelCarUpdate
            // 
            this.CB_CarModelCarUpdate.FormattingEnabled = true;
            this.CB_CarModelCarUpdate.Location = new System.Drawing.Point(126, 95);
            this.CB_CarModelCarUpdate.Name = "CB_CarModelCarUpdate";
            this.CB_CarModelCarUpdate.Size = new System.Drawing.Size(121, 24);
            this.CB_CarModelCarUpdate.TabIndex = 19;
            // 
            // CB_CarBrandCarUpdate
            // 
            this.CB_CarBrandCarUpdate.FormattingEnabled = true;
            this.CB_CarBrandCarUpdate.Location = new System.Drawing.Point(126, 62);
            this.CB_CarBrandCarUpdate.Name = "CB_CarBrandCarUpdate";
            this.CB_CarBrandCarUpdate.Size = new System.Drawing.Size(121, 24);
            this.CB_CarBrandCarUpdate.TabIndex = 18;
            this.CB_CarBrandCarUpdate.SelectedIndexChanged += new System.EventHandler(this.CB_CarBrandCarUpdate_SelectedIndexChanged);
            // 
            // BT_SaveCarUpdate
            // 
            this.BT_SaveCarUpdate.Location = new System.Drawing.Point(297, 303);
            this.BT_SaveCarUpdate.Name = "BT_SaveCarUpdate";
            this.BT_SaveCarUpdate.Size = new System.Drawing.Size(75, 23);
            this.BT_SaveCarUpdate.TabIndex = 21;
            this.BT_SaveCarUpdate.Text = "Kaydet";
            this.BT_SaveCarUpdate.UseVisualStyleBackColor = true;
            // 
            // RB_CarUpdate
            // 
            this.RB_CarUpdate.AutoSize = true;
            this.RB_CarUpdate.Location = new System.Drawing.Point(441, 16);
            this.RB_CarUpdate.Name = "RB_CarUpdate";
            this.RB_CarUpdate.Size = new System.Drawing.Size(262, 20);
            this.RB_CarUpdate.TabIndex = 2;
            this.RB_CarUpdate.TabStop = true;
            this.RB_CarUpdate.Text = "MEVCUT ARAÇ BİLGİSİNİ GÜNCELLE:";
            this.RB_CarUpdate.UseVisualStyleBackColor = true;
            this.RB_CarUpdate.CheckedChanged += new System.EventHandler(this.RB_CarUpdate_CheckedChanged);
            // 
            // RB_NewCar
            // 
            this.RB_NewCar.AutoSize = true;
            this.RB_NewCar.Location = new System.Drawing.Point(35, 16);
            this.RB_NewCar.Name = "RB_NewCar";
            this.RB_NewCar.Size = new System.Drawing.Size(138, 20);
            this.RB_NewCar.TabIndex = 1;
            this.RB_NewCar.TabStop = true;
            this.RB_NewCar.Text = "YENİ ARAÇ EKLE:";
            this.RB_NewCar.UseVisualStyleBackColor = true;
            this.RB_NewCar.CheckedChanged += new System.EventHandler(this.RB_NewCar_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "PLAKA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "YAKIT TÜRÜ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "ARAÇ MARKASI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ARAÇ MODELİ:";
            // 
            // TB_LicensePlateNumberNewCar
            // 
            this.TB_LicensePlateNumberNewCar.Location = new System.Drawing.Point(165, 60);
            this.TB_LicensePlateNumberNewCar.Name = "TB_LicensePlateNumberNewCar";
            this.TB_LicensePlateNumberNewCar.Size = new System.Drawing.Size(121, 22);
            this.TB_LicensePlateNumberNewCar.TabIndex = 15;
            // 
            // BT_SaveNewCar
            // 
            this.BT_SaveNewCar.Location = new System.Drawing.Point(303, 303);
            this.BT_SaveNewCar.Name = "BT_SaveNewCar";
            this.BT_SaveNewCar.Size = new System.Drawing.Size(75, 23);
            this.BT_SaveNewCar.TabIndex = 19;
            this.BT_SaveNewCar.Text = "Kaydet";
            this.BT_SaveNewCar.UseVisualStyleBackColor = true;
            this.BT_SaveNewCar.Click += new System.EventHandler(this.BT_SaveNewCar_Click);
            // 
            // CB_CarModelNewCar
            // 
            this.CB_CarModelNewCar.FormattingEnabled = true;
            this.CB_CarModelNewCar.Location = new System.Drawing.Point(165, 204);
            this.CB_CarModelNewCar.Name = "CB_CarModelNewCar";
            this.CB_CarModelNewCar.Size = new System.Drawing.Size(121, 24);
            this.CB_CarModelNewCar.TabIndex = 18;
            // 
            // CB_CarBrandNewCar
            // 
            this.CB_CarBrandNewCar.FormattingEnabled = true;
            this.CB_CarBrandNewCar.Location = new System.Drawing.Point(165, 157);
            this.CB_CarBrandNewCar.Name = "CB_CarBrandNewCar";
            this.CB_CarBrandNewCar.Size = new System.Drawing.Size(121, 24);
            this.CB_CarBrandNewCar.TabIndex = 17;
            this.CB_CarBrandNewCar.SelectedIndexChanged += new System.EventHandler(this.CB_CarBrandNewCar_SelectedIndexChanged);
            // 
            // CB_FuelTypeNewCar
            // 
            this.CB_FuelTypeNewCar.FormattingEnabled = true;
            this.CB_FuelTypeNewCar.Location = new System.Drawing.Point(165, 107);
            this.CB_FuelTypeNewCar.Name = "CB_FuelTypeNewCar";
            this.CB_FuelTypeNewCar.Size = new System.Drawing.Size(121, 24);
            this.CB_FuelTypeNewCar.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BT_SaveNewCar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CB_CarModelNewCar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CB_CarBrandNewCar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CB_FuelTypeNewCar);
            this.groupBox1.Controls.Add(this.TB_LicensePlateNumberNewCar);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 332);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_LN);
            this.groupBox2.Controls.Add(this.CB_Car);
            this.groupBox2.Controls.Add(this.P_CarInfo);
            this.groupBox2.Controls.Add(this.BT_SaveCarUpdate);
            this.groupBox2.Location = new System.Drawing.Point(441, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 332);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // BT_LN
            // 
            this.BT_LN.Location = new System.Drawing.Point(92, 38);
            this.BT_LN.Name = "BT_LN";
            this.BT_LN.Size = new System.Drawing.Size(254, 23);
            this.BT_LN.TabIndex = 55;
            this.BT_LN.Text = "ARAÇLARIMI SORGULA";
            this.BT_LN.UseVisualStyleBackColor = true;
            this.BT_LN.Click += new System.EventHandler(this.BT_LN_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(846, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RB_NewCar);
            this.Controls.Add(this.RB_CarUpdate);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.P_CarInfo.ResumeLayout(false);
            this.P_CarInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_CarUpdate;
        private System.Windows.Forms.RadioButton RB_NewCar;
        private System.Windows.Forms.TextBox TB_LicensePlateNumberCarUpdate;
        private System.Windows.Forms.ComboBox CB_CarModelCarUpdate;
        private System.Windows.Forms.ComboBox CB_CarBrandCarUpdate;
        private System.Windows.Forms.ComboBox CB_CarModelNewCar;
        private System.Windows.Forms.ComboBox CB_CarBrandNewCar;
        private System.Windows.Forms.ComboBox CB_FuelTypeNewCar;
        private System.Windows.Forms.TextBox TB_LicensePlateNumberNewCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_FuelTypeCarUpdate;
        private System.Windows.Forms.Button BT_SaveCarUpdate;
        private System.Windows.Forms.Button BT_SaveNewCar;
        private System.Windows.Forms.Panel P_CarInfo;
        private System.Windows.Forms.ComboBox CB_Car;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_LN;
    }
}