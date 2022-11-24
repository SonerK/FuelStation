namespace FUELSTATION
{
    partial class AdminNewAccount
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
            this.components = new System.ComponentModel.Container();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_SurName = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_PersonNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TB_StationCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BT_Save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.TB_E_Mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RB_Admin = new System.Windows.Forms.RadioButton();
            this.RB_Person = new System.Windows.Forms.RadioButton();
            this.P_Person = new System.Windows.Forms.Panel();
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.gASSTATIONDataSet = new FUELSTATION.GASSTATIONDataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new FUELSTATION.GASSTATIONDataSetTableAdapters.USERSTableAdapter();
            this.P_Person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gASSTATIONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(156, 24);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 22);
            this.TB_Name.TabIndex = 0;
            // 
            // TB_SurName
            // 
            this.TB_SurName.Location = new System.Drawing.Point(156, 70);
            this.TB_SurName.Name = "TB_SurName";
            this.TB_SurName.Size = new System.Drawing.Size(100, 22);
            this.TB_SurName.TabIndex = 1;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(156, 122);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '•';
            this.TB_Password.Size = new System.Drawing.Size(100, 22);
            this.TB_Password.TabIndex = 2;
            // 
            // TB_PersonNumber
            // 
            this.TB_PersonNumber.Location = new System.Drawing.Point(123, 129);
            this.TB_PersonNumber.Name = "TB_PersonNumber";
            this.TB_PersonNumber.Size = new System.Drawing.Size(154, 22);
            this.TB_PersonNumber.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 5, 18, 33, 54, 0);
            // 
            // TB_StationCode
            // 
            this.TB_StationCode.Location = new System.Drawing.Point(123, 70);
            this.TB_StationCode.Name = "TB_StationCode";
            this.TB_StationCode.Size = new System.Drawing.Size(151, 22);
            this.TB_StationCode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ŞİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "PERSONEL NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "PERSONEL STATÜSÜ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "DOĞUM TARİHİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ÇALIŞTIĞI BÖLÜM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "İSTASYON KODU:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "SOYAD:";
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(583, 455);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 17;
            this.BT_Save.Text = "KAYDET";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefon No:";
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.Location = new System.Drawing.Point(482, 128);
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.TB_PhoneNumber.TabIndex = 19;
            // 
            // TB_E_Mail
            // 
            this.TB_E_Mail.Location = new System.Drawing.Point(482, 183);
            this.TB_E_Mail.Name = "TB_E_Mail";
            this.TB_E_Mail.Size = new System.Drawing.Size(100, 22);
            this.TB_E_Mail.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "E-Posta";
            // 
            // RB_Admin
            // 
            this.RB_Admin.AutoSize = true;
            this.RB_Admin.Location = new System.Drawing.Point(410, 49);
            this.RB_Admin.Name = "RB_Admin";
            this.RB_Admin.Size = new System.Drawing.Size(66, 20);
            this.RB_Admin.TabIndex = 22;
            this.RB_Admin.TabStop = true;
            this.RB_Admin.Text = "Admin";
            this.RB_Admin.UseVisualStyleBackColor = true;
            this.RB_Admin.CheckedChanged += new System.EventHandler(this.RB_Admin_CheckedChanged);
            // 
            // RB_Person
            // 
            this.RB_Person.AutoSize = true;
            this.RB_Person.Location = new System.Drawing.Point(410, 76);
            this.RB_Person.Name = "RB_Person";
            this.RB_Person.Size = new System.Drawing.Size(82, 20);
            this.RB_Person.TabIndex = 23;
            this.RB_Person.TabStop = true;
            this.RB_Person.Text = "Personel";
            this.RB_Person.UseVisualStyleBackColor = true;
            this.RB_Person.CheckedChanged += new System.EventHandler(this.RB_Person_CheckedChanged);
            // 
            // P_Person
            // 
            this.P_Person.Controls.Add(this.CB_Department);
            this.P_Person.Controls.Add(this.TB_StationCode);
            this.P_Person.Controls.Add(this.label6);
            this.P_Person.Controls.Add(this.label7);
            this.P_Person.Controls.Add(this.label3);
            this.P_Person.Controls.Add(this.TB_PersonNumber);
            this.P_Person.Location = new System.Drawing.Point(384, 231);
            this.P_Person.Name = "P_Person";
            this.P_Person.Size = new System.Drawing.Size(277, 185);
            this.P_Person.TabIndex = 24;
            // 
            // CB_Department
            // 
            this.CB_Department.FormattingEnabled = true;
            this.CB_Department.Location = new System.Drawing.Point(123, 17);
            this.CB_Department.Name = "CB_Department";
            this.CB_Department.Size = new System.Drawing.Size(151, 24);
            this.CB_Department.TabIndex = 15;
            // 
            // gASSTATIONDataSet
            // 
            this.gASSTATIONDataSet.DataSetName = "GASSTATIONDataSet";
            this.gASSTATIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.gASSTATIONDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // AdminNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 568);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_Person);
            this.Controls.Add(this.TB_E_Mail);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_PhoneNumber);
            this.Controls.Add(this.RB_Person);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_SurName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RB_Admin);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AdminNewAccount";
            this.Text = "AdminNewAccount";
            this.Load += new System.EventHandler(this.AdminNewAccount_Load);
            this.P_Person.ResumeLayout(false);
            this.P_Person.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gASSTATIONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_SurName;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_PersonNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TB_StationCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_PhoneNumber;
        private System.Windows.Forms.TextBox TB_E_Mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RB_Admin;
        private System.Windows.Forms.RadioButton RB_Person;
        private System.Windows.Forms.Panel P_Person;
        private System.Windows.Forms.ComboBox CB_Department;
        private GASSTATIONDataSet gASSTATIONDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private GASSTATIONDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
    }
}