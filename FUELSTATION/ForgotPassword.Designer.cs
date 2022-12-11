namespace FUELSTATION
{
    partial class ForgotPassword
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
            this.CB_Questions = new System.Windows.Forms.ComboBox();
            this.TB_Answers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Questions = new System.Windows.Forms.GroupBox();
            this.BT_Control = new System.Windows.Forms.Button();
            this.TB_E_Posta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_GO = new System.Windows.Forms.Button();
            this.GB_Questions.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Questions
            // 
            this.CB_Questions.FormattingEnabled = true;
            this.CB_Questions.Location = new System.Drawing.Point(39, 46);
            this.CB_Questions.Name = "CB_Questions";
            this.CB_Questions.Size = new System.Drawing.Size(375, 24);
            this.CB_Questions.TabIndex = 0;
            // 
            // TB_Answers
            // 
            this.TB_Answers.Location = new System.Drawing.Point(39, 76);
            this.TB_Answers.Name = "TB_Answers";
            this.TB_Answers.Size = new System.Drawing.Size(375, 22);
            this.TB_Answers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "LÜTFEN ŞİFRENİZİ DEĞİŞTİRMEK İÇİN BELİRLEDİĞİNİZ GÜVENLİK SORUSUNUN CEVABINI YAZI" +
    "NIZ";
            // 
            // GB_Questions
            // 
            this.GB_Questions.Controls.Add(this.BT_Control);
            this.GB_Questions.Controls.Add(this.label1);
            this.GB_Questions.Controls.Add(this.TB_Answers);
            this.GB_Questions.Controls.Add(this.CB_Questions);
            this.GB_Questions.Location = new System.Drawing.Point(112, 180);
            this.GB_Questions.Name = "GB_Questions";
            this.GB_Questions.Size = new System.Drawing.Size(643, 236);
            this.GB_Questions.TabIndex = 3;
            this.GB_Questions.TabStop = false;
            this.GB_Questions.Text = "GB_Questions";
            this.GB_Questions.Enter += new System.EventHandler(this.GB_Questions_Enter);
            // 
            // BT_Control
            // 
            this.BT_Control.Location = new System.Drawing.Point(447, 105);
            this.BT_Control.Name = "BT_Control";
            this.BT_Control.Size = new System.Drawing.Size(110, 23);
            this.BT_Control.TabIndex = 3;
            this.BT_Control.Text = "KONTROL ET";
            this.BT_Control.UseVisualStyleBackColor = true;
            this.BT_Control.Click += new System.EventHandler(this.BT_Control_Click);
            // 
            // TB_E_Posta
            // 
            this.TB_E_Posta.Location = new System.Drawing.Point(286, 71);
            this.TB_E_Posta.Name = "TB_E_Posta";
            this.TB_E_Posta.Size = new System.Drawing.Size(185, 22);
            this.TB_E_Posta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "LÜTFEN E MAİL ADRESİNİZİ GİRİNİZ";
            // 
            // BT_GO
            // 
            this.BT_GO.Location = new System.Drawing.Point(461, 134);
            this.BT_GO.Name = "BT_GO";
            this.BT_GO.Size = new System.Drawing.Size(101, 23);
            this.BT_GO.TabIndex = 6;
            this.BT_GO.Text = "DEVAM ET";
            this.BT_GO.UseVisualStyleBackColor = true;
            this.BT_GO.Click += new System.EventHandler(this.BT_GO_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_GO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_E_Posta);
            this.Controls.Add(this.GB_Questions);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.GB_Questions.ResumeLayout(false);
            this.GB_Questions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Questions;
        private System.Windows.Forms.TextBox TB_Answers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Questions;
        private System.Windows.Forms.TextBox TB_E_Posta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_GO;
        private System.Windows.Forms.Button BT_Control;
    }
}