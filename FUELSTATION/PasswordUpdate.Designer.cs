namespace FUELSTATION
{
    partial class PasswordUpdate
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
            this.TB_PassUpdate1 = new System.Windows.Forms.TextBox();
            this.TB_PassUpdate2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Save1 = new System.Windows.Forms.Button();
            this.BT_Save2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_PassUpdate1
            // 
            this.TB_PassUpdate1.Location = new System.Drawing.Point(64, 74);
            this.TB_PassUpdate1.Name = "TB_PassUpdate1";
            this.TB_PassUpdate1.Size = new System.Drawing.Size(100, 22);
            this.TB_PassUpdate1.TabIndex = 0;
            // 
            // TB_PassUpdate2
            // 
            this.TB_PassUpdate2.Location = new System.Drawing.Point(50, 210);
            this.TB_PassUpdate2.Name = "TB_PassUpdate2";
            this.TB_PassUpdate2.Size = new System.Drawing.Size(100, 22);
            this.TB_PassUpdate2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "YENİ ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "YENİ ŞİFRENİZİ TEKRAR GİRİNİZ";
            // 
            // BT_Save1
            // 
            this.BT_Save1.Location = new System.Drawing.Point(169, 116);
            this.BT_Save1.Name = "BT_Save1";
            this.BT_Save1.Size = new System.Drawing.Size(75, 23);
            this.BT_Save1.TabIndex = 4;
            this.BT_Save1.Text = "Devam Et";
            this.BT_Save1.UseVisualStyleBackColor = true;
            this.BT_Save1.Click += new System.EventHandler(this.BT_Save1_Click);
            // 
            // BT_Save2
            // 
            this.BT_Save2.Location = new System.Drawing.Point(169, 257);
            this.BT_Save2.Name = "BT_Save2";
            this.BT_Save2.Size = new System.Drawing.Size(75, 23);
            this.BT_Save2.TabIndex = 5;
            this.BT_Save2.Text = "Kaydet";
            this.BT_Save2.UseVisualStyleBackColor = true;
            this.BT_Save2.Click += new System.EventHandler(this.BT_Save2_Click);
            // 
            // PasswordUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 319);
            this.Controls.Add(this.BT_Save2);
            this.Controls.Add(this.TB_PassUpdate2);
            this.Controls.Add(this.BT_Save1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_PassUpdate1);
            this.Name = "PasswordUpdate";
            this.Text = "PasswordUpdate";
            this.Load += new System.EventHandler(this.PasswordUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_PassUpdate1;
        private System.Windows.Forms.TextBox TB_PassUpdate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Save1;
        private System.Windows.Forms.Button BT_Save2;
    }
}