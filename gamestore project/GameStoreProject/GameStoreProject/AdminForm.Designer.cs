namespace GameStoreProject
{
    partial class AdminForm
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
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageGames = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageUsers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(119, 86);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnManageUsers.Size = new System.Drawing.Size(162, 57);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageGames
            // 
            this.btnManageGames.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageGames.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnManageGames.Location = new System.Drawing.Point(119, 168);
            this.btnManageGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageGames.Name = "btnManageGames";
            this.btnManageGames.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnManageGames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnManageGames.Size = new System.Drawing.Size(162, 57);
            this.btnManageGames.TabIndex = 1;
            this.btnManageGames.Text = "Manage Games";
            this.btnManageGames.UseVisualStyleBackColor = false;
            this.btnManageGames.Click += new System.EventHandler(this.btnManageGames_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.DarkCyan;
            this.btnViewOrders.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnViewOrders.Location = new System.Drawing.Point(119, 250);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnViewOrders.Size = new System.Drawing.Size(162, 52);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(524, 270);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 41);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Dashboard";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnManageGames);
            this.Controls.Add(this.btnManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "GameStore Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageGames;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}