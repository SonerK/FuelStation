namespace FUELSTATION
{
    partial class Campaign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Campaign));
            this.BT_Campain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Campain
            // 
            this.BT_Campain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Campain.BackgroundImage")));
            this.BT_Campain.Location = new System.Drawing.Point(441, 104);
            this.BT_Campain.Name = "BT_Campain";
            this.BT_Campain.Size = new System.Drawing.Size(393, 442);
            this.BT_Campain.TabIndex = 16;
            this.BT_Campain.UseVisualStyleBackColor = true;
            this.BT_Campain.Click += new System.EventHandler(this.BT_Campain_Click);
            // 
            // Campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 598);
            this.Controls.Add(this.BT_Campain);
            this.Name = "Campaign";
            this.Text = "Campaign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Campain;
    }
}