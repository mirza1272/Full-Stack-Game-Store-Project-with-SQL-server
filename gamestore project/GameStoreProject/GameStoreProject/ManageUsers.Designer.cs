namespace GameStoreProject
{
    partial class ManageUsers
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
            this.viewallusers = new System.Windows.Forms.Button();
            this.adduserbtn = new System.Windows.Forms.Button();
            this.deleteuserbtn = new System.Windows.Forms.Button();
            this.gotoadminpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewallusers
            // 
            this.viewallusers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewallusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallusers.Location = new System.Drawing.Point(152, 44);
            this.viewallusers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewallusers.Name = "viewallusers";
            this.viewallusers.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.viewallusers.Size = new System.Drawing.Size(143, 51);
            this.viewallusers.TabIndex = 0;
            this.viewallusers.Text = "View All Users";
            this.viewallusers.UseVisualStyleBackColor = false;
            this.viewallusers.Click += new System.EventHandler(this.viewallusers_Click);
            // 
            // adduserbtn
            // 
            this.adduserbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adduserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserbtn.Location = new System.Drawing.Point(152, 137);
            this.adduserbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.adduserbtn.Size = new System.Drawing.Size(143, 47);
            this.adduserbtn.TabIndex = 1;
            this.adduserbtn.Text = "Add User";
            this.adduserbtn.UseVisualStyleBackColor = false;
            this.adduserbtn.Click += new System.EventHandler(this.adduserbtn_Click);
            // 
            // deleteuserbtn
            // 
            this.deleteuserbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteuserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteuserbtn.Location = new System.Drawing.Point(152, 228);
            this.deleteuserbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteuserbtn.Name = "deleteuserbtn";
            this.deleteuserbtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.deleteuserbtn.Size = new System.Drawing.Size(143, 46);
            this.deleteuserbtn.TabIndex = 2;
            this.deleteuserbtn.Text = "Delete User";
            this.deleteuserbtn.UseVisualStyleBackColor = false;
            this.deleteuserbtn.Click += new System.EventHandler(this.deleteuserbtn_Click);
            // 
            // gotoadminpage
            // 
            this.gotoadminpage.BackColor = System.Drawing.Color.BurlyWood;
            this.gotoadminpage.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoadminpage.ForeColor = System.Drawing.Color.Black;
            this.gotoadminpage.Location = new System.Drawing.Point(512, 254);
            this.gotoadminpage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gotoadminpage.Name = "gotoadminpage";
            this.gotoadminpage.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.gotoadminpage.Size = new System.Drawing.Size(152, 51);
            this.gotoadminpage.TabIndex = 3;
            this.gotoadminpage.Text = "Go To Homepage";
            this.gotoadminpage.UseVisualStyleBackColor = false;
            this.gotoadminpage.Click += new System.EventHandler(this.gotoadminpage_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.gotoadminpage);
            this.Controls.Add(this.deleteuserbtn);
            this.Controls.Add(this.adduserbtn);
            this.Controls.Add(this.viewallusers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewallusers;
        private System.Windows.Forms.Button adduserbtn;
        private System.Windows.Forms.Button deleteuserbtn;
        private System.Windows.Forms.Button gotoadminpage;
    }
}