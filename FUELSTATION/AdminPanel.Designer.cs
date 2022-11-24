namespace FUELSTATION
{
    partial class AdminPanel
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
            this.BT_NewStation = new System.Windows.Forms.Button();
            this.BT_UsersUpdateDelete = new System.Windows.Forms.Button();
            this.BT_NewUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_NewStation
            // 
            this.BT_NewStation.Location = new System.Drawing.Point(145, 86);
            this.BT_NewStation.Name = "BT_NewStation";
            this.BT_NewStation.Size = new System.Drawing.Size(342, 23);
            this.BT_NewStation.TabIndex = 0;
            this.BT_NewStation.Text = "YAKIT İSTASYONU EKLE";
            this.BT_NewStation.UseVisualStyleBackColor = true;
            this.BT_NewStation.Click += new System.EventHandler(this.BT_NewStation_Click);
            // 
            // BT_UsersUpdateDelete
            // 
            this.BT_UsersUpdateDelete.Location = new System.Drawing.Point(145, 135);
            this.BT_UsersUpdateDelete.Name = "BT_UsersUpdateDelete";
            this.BT_UsersUpdateDelete.Size = new System.Drawing.Size(342, 23);
            this.BT_UsersUpdateDelete.TabIndex = 1;
            this.BT_UsersUpdateDelete.Text = "KULLANICI GÜNCELLE-SİL";
            this.BT_UsersUpdateDelete.UseVisualStyleBackColor = true;
            this.BT_UsersUpdateDelete.Click += new System.EventHandler(this.BT_UsersUpdate_Click);
            // 
            // BT_NewUsers
            // 
            this.BT_NewUsers.Location = new System.Drawing.Point(145, 187);
            this.BT_NewUsers.Name = "BT_NewUsers";
            this.BT_NewUsers.Size = new System.Drawing.Size(342, 22);
            this.BT_NewUsers.TabIndex = 2;
            this.BT_NewUsers.Text = "KULLANICI EKLE";
            this.BT_NewUsers.UseVisualStyleBackColor = true;
            this.BT_NewUsers.Click += new System.EventHandler(this.BT_NewDeleteUsers_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.BT_NewUsers);
            this.Controls.Add(this.BT_UsersUpdateDelete);
            this.Controls.Add(this.BT_NewStation);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_NewStation;
        private System.Windows.Forms.Button BT_UsersUpdateDelete;
        private System.Windows.Forms.Button BT_NewUsers;
    }
}