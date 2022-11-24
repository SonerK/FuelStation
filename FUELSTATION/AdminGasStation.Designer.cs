namespace FUELSTATION
{
    partial class AdminGasStation
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
            this.TB_PostCode = new System.Windows.Forms.TextBox();
            this.TB_FuelPompN = new System.Windows.Forms.TextBox();
            this.TB_StationCode = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Code = new System.Windows.Forms.Button();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.CB_District = new System.Windows.Forms.ComboBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_PostCode
            // 
            this.TB_PostCode.Location = new System.Drawing.Point(277, 166);
            this.TB_PostCode.Name = "TB_PostCode";
            this.TB_PostCode.Size = new System.Drawing.Size(100, 22);
            this.TB_PostCode.TabIndex = 2;
            // 
            // TB_FuelPompN
            // 
            this.TB_FuelPompN.Location = new System.Drawing.Point(277, 227);
            this.TB_FuelPompN.Name = "TB_FuelPompN";
            this.TB_FuelPompN.Size = new System.Drawing.Size(100, 22);
            this.TB_FuelPompN.TabIndex = 3;
            // 
            // TB_StationCode
            // 
            this.TB_StationCode.Location = new System.Drawing.Point(277, 279);
            this.TB_StationCode.Name = "TB_StationCode";
            this.TB_StationCode.Size = new System.Drawing.Size(100, 22);
            this.TB_StationCode.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "BENZİN",
            "DİZEL",
            "LPG",
            "HİBRİT",
            "ELEKTRİK"});
            this.checkedListBox1.Location = new System.Drawing.Point(277, 337);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "İL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "İLÇE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "posta kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "AKARYAKIT POMPASI SAYISI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "İSTASYON KODU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "İSTASYON AKARYAKIT TÜRLERİ:";
            // 
            // BT_Code
            // 
            this.BT_Code.Location = new System.Drawing.Point(424, 279);
            this.BT_Code.Name = "BT_Code";
            this.BT_Code.Size = new System.Drawing.Size(128, 23);
            this.BT_Code.TabIndex = 12;
            this.BT_Code.Text = "kod oluştur";
            this.BT_Code.UseVisualStyleBackColor = true;
            this.BT_Code.Click += new System.EventHandler(this.BT_Code_Click);
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(264, 36);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(121, 24);
            this.CB_City.TabIndex = 13;
            this.CB_City.SelectedIndexChanged += new System.EventHandler(this.CB_City_SelectedIndexChanged);
            // 
            // CB_District
            // 
            this.CB_District.FormattingEnabled = true;
            this.CB_District.Location = new System.Drawing.Point(264, 93);
            this.CB_District.Name = "CB_District";
            this.CB_District.Size = new System.Drawing.Size(121, 24);
            this.CB_District.TabIndex = 14;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(450, 364);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 15;
            this.BT_Save.Text = "kaydet";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // AdminGasStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 449);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.CB_District);
            this.Controls.Add(this.CB_City);
            this.Controls.Add(this.BT_Code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.TB_StationCode);
            this.Controls.Add(this.TB_FuelPompN);
            this.Controls.Add(this.TB_PostCode);
            this.Name = "AdminGasStation";
            this.Text = "AdminGasStation";
            this.Load += new System.EventHandler(this.AdminGasStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_PostCode;
        private System.Windows.Forms.TextBox TB_FuelPompN;
        private System.Windows.Forms.TextBox TB_StationCode;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Code;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.ComboBox CB_District;
        private System.Windows.Forms.Button BT_Save;
    }
}