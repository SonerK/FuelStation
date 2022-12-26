namespace FUELSTATION
{
    partial class StatyonCoin
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
            this.L_Coin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statyon Coin Miktarınız";
            // 
            // L_Coin
            // 
            this.L_Coin.AutoSize = true;
            this.L_Coin.Location = new System.Drawing.Point(12, 74);
            this.L_Coin.Name = "L_Coin";
            this.L_Coin.Size = new System.Drawing.Size(44, 16);
            this.L_Coin.TabIndex = 1;
            this.L_Coin.Text = "label2";
            // 
            // StatyonCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 156);
            this.Controls.Add(this.L_Coin);
            this.Controls.Add(this.label1);
            this.Name = "StatyonCoin";
            this.Text = "StatyonCoin";
            this.Load += new System.EventHandler(this.StatyonCoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Coin;
    }
}