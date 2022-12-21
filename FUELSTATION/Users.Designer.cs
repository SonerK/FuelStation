namespace FUELSTATION
{
    partial class Users
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
            this.BT_Campaign = new System.Windows.Forms.Button();
            this.BT_Car = new System.Windows.Forms.Button();
            this.BT_Coin = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Campaign
            // 
            this.BT_Campaign.Location = new System.Drawing.Point(68, 36);
            this.BT_Campaign.Name = "BT_Campaign";
            this.BT_Campaign.Size = new System.Drawing.Size(178, 23);
            this.BT_Campaign.TabIndex = 0;
            this.BT_Campaign.Text = "KAMPANYALAR";
            this.BT_Campaign.UseVisualStyleBackColor = true;
            this.BT_Campaign.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_Car
            // 
            this.BT_Car.Location = new System.Drawing.Point(447, 130);
            this.BT_Car.Name = "BT_Car";
            this.BT_Car.Size = new System.Drawing.Size(170, 103);
            this.BT_Car.TabIndex = 1;
            this.BT_Car.Text = "ARAÇ BİLGİSİNİ GÜNCELLE";
            this.BT_Car.UseVisualStyleBackColor = true;
            this.BT_Car.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_Coin
            // 
            this.BT_Coin.Location = new System.Drawing.Point(447, 36);
            this.BT_Coin.Name = "BT_Coin";
            this.BT_Coin.Size = new System.Drawing.Size(170, 23);
            this.BT_Coin.TabIndex = 3;
            this.BT_Coin.Text = "STATYONCOİN";
            this.BT_Coin.UseVisualStyleBackColor = true;
            this.BT_Coin.Click += new System.EventHandler(this.button4_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(68, 130);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(178, 103);
            this.BT_Update.TabIndex = 4;
            this.BT_Update.Text = "BİLGİLERİMİ GÜNCELLE";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.button3_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Coin);
            this.Controls.Add(this.BT_Car);
            this.Controls.Add(this.BT_Campaign);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Campaign;
        private System.Windows.Forms.Button BT_Car;
        private System.Windows.Forms.Button BT_Coin;
        private System.Windows.Forms.Button BT_Update;
    }
}