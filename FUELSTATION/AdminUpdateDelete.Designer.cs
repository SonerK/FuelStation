namespace FUELSTATION
{
    partial class AdminUpdateDelete
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
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_TelephoneNumber = new System.Windows.Forms.TextBox();
            this.TB_E_Posta = new System.Windows.Forms.TextBox();
            this.TB_StationCode = new System.Windows.Forms.TextBox();
            this.TB_PersonNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_UID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_USID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Department = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.P_Person = new System.Windows.Forms.Panel();
            this.CB_UAP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.P_Person.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(685, 12);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(103, 23);
            this.BT_Update.TabIndex = 0;
            this.BT_Update.Text = "Güncelle";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(685, 74);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(103, 23);
            this.BT_Delete.TabIndex = 1;
            this.BT_Delete.Text = "Sil";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(119, 9);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 22);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_Surname
            // 
            this.TB_Surname.Location = new System.Drawing.Point(119, 37);
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(100, 22);
            this.TB_Surname.TabIndex = 3;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(119, 68);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '•';
            this.TB_Password.Size = new System.Drawing.Size(100, 22);
            this.TB_Password.TabIndex = 4;
            // 
            // TB_TelephoneNumber
            // 
            this.TB_TelephoneNumber.Location = new System.Drawing.Point(119, 127);
            this.TB_TelephoneNumber.Name = "TB_TelephoneNumber";
            this.TB_TelephoneNumber.Size = new System.Drawing.Size(100, 22);
            this.TB_TelephoneNumber.TabIndex = 6;
            // 
            // TB_E_Posta
            // 
            this.TB_E_Posta.Location = new System.Drawing.Point(119, 99);
            this.TB_E_Posta.Name = "TB_E_Posta";
            this.TB_E_Posta.Size = new System.Drawing.Size(100, 22);
            this.TB_E_Posta.TabIndex = 7;
            // 
            // TB_StationCode
            // 
            this.TB_StationCode.Location = new System.Drawing.Point(131, 31);
            this.TB_StationCode.Name = "TB_StationCode";
            this.TB_StationCode.Size = new System.Drawing.Size(121, 22);
            this.TB_StationCode.TabIndex = 10;
            // 
            // TB_PersonNumber
            // 
            this.TB_PersonNumber.Location = new System.Drawing.Point(131, 59);
            this.TB_PersonNumber.Name = "TB_PersonNumber";
            this.TB_PersonNumber.Size = new System.Drawing.Size(121, 22);
            this.TB_PersonNumber.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-POSTA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "TELEFON NO:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "DOĞUM TARİHİ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "ÇALIŞTIĞI BÖLÜM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "İSTASYON KODU:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "PERSONEL NO:";
            // 
            // TB_UID
            // 
            this.TB_UID.Location = new System.Drawing.Point(119, 162);
            this.TB_UID.Name = "TB_UID";
            this.TB_UID.Size = new System.Drawing.Size(100, 22);
            this.TB_UID.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "UID:";
            // 
            // TB_USID
            // 
            this.TB_USID.Location = new System.Drawing.Point(639, 179);
            this.TB_USID.Name = "TB_USID";
            this.TB_USID.Size = new System.Drawing.Size(121, 22);
            this.TB_USID.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "USID:";
            // 
            // TB_Department
            // 
            this.TB_Department.Location = new System.Drawing.Point(131, 1);
            this.TB_Department.Name = "TB_Department";
            this.TB_Department.Size = new System.Drawing.Size(121, 22);
            this.TB_Department.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 188);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // P_Person
            // 
            this.P_Person.Controls.Add(this.label7);
            this.P_Person.Controls.Add(this.TB_Department);
            this.P_Person.Controls.Add(this.label8);
            this.P_Person.Controls.Add(this.TB_StationCode);
            this.P_Person.Controls.Add(this.label9);
            this.P_Person.Controls.Add(this.TB_PersonNumber);
            this.P_Person.Location = new System.Drawing.Point(318, 81);
            this.P_Person.Name = "P_Person";
            this.P_Person.Size = new System.Drawing.Size(265, 100);
            this.P_Person.TabIndex = 31;
            // 
            // CB_UAP
            // 
            this.CB_UAP.FormattingEnabled = true;
            this.CB_UAP.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.CB_UAP.Location = new System.Drawing.Point(491, 37);
            this.CB_UAP.Name = "CB_UAP";
            this.CB_UAP.Size = new System.Drawing.Size(121, 24);
            this.CB_UAP.TabIndex = 35;
            // 
            // AdminUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_UAP);
            this.Controls.Add(this.P_Person);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_USID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_UID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_E_Posta);
            this.Controls.Add(this.TB_TelephoneNumber);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Surname);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Update);
            this.Name = "AdminUpdateDelete";
            this.Text = "AdminUpdateDelete";
            this.Load += new System.EventHandler(this.AdminUpdateDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.P_Person.ResumeLayout(false);
            this.P_Person.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_TelephoneNumber;
        private System.Windows.Forms.TextBox TB_E_Posta;
        private System.Windows.Forms.TextBox TB_StationCode;
        private System.Windows.Forms.TextBox TB_PersonNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_UID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_USID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_Department;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel P_Person;
        private System.Windows.Forms.ComboBox CB_UAP;
    }
}