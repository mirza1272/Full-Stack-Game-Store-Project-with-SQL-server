namespace GameStoreProject
{
    partial class DeleteUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.deleteuserbyidorusername = new System.Windows.Forms.TextBox();
            this.gotoadminpage = new System.Windows.Forms.Button();
            this.deleteuserbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Required Information:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter user ID or username:";
            // 
            // deleteuserbyidorusername
            // 
            this.deleteuserbyidorusername.Location = new System.Drawing.Point(95, 160);
            this.deleteuserbyidorusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteuserbyidorusername.Name = "deleteuserbyidorusername";
            this.deleteuserbyidorusername.Size = new System.Drawing.Size(236, 22);
            this.deleteuserbyidorusername.TabIndex = 3;
            this.deleteuserbyidorusername.TextChanged += new System.EventHandler(this.deleteuserbyidorusername_TextChanged);
            // 
            // gotoadminpage
            // 
            this.gotoadminpage.BackColor = System.Drawing.Color.BurlyWood;
            this.gotoadminpage.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoadminpage.ForeColor = System.Drawing.Color.Black;
            this.gotoadminpage.Location = new System.Drawing.Point(488, 242);
            this.gotoadminpage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gotoadminpage.Name = "gotoadminpage";
            this.gotoadminpage.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.gotoadminpage.Size = new System.Drawing.Size(111, 52);
            this.gotoadminpage.TabIndex = 5;
            this.gotoadminpage.Text = "GoTo Homepage";
            this.gotoadminpage.UseVisualStyleBackColor = false;
            this.gotoadminpage.Click += new System.EventHandler(this.gotoadminpage_Click);
            // 
            // deleteuserbtn
            // 
            this.deleteuserbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteuserbtn.Location = new System.Drawing.Point(95, 228);
            this.deleteuserbtn.Name = "deleteuserbtn";
            this.deleteuserbtn.Size = new System.Drawing.Size(147, 38);
            this.deleteuserbtn.TabIndex = 6;
            this.deleteuserbtn.Text = "Delete User";
            this.deleteuserbtn.UseVisualStyleBackColor = false;
            this.deleteuserbtn.Click += new System.EventHandler(this.deleteuserbtn_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.deleteuserbtn);
            this.Controls.Add(this.gotoadminpage);
            this.Controls.Add(this.deleteuserbyidorusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deleteuserbyidorusername;
        private System.Windows.Forms.Button gotoadminpage;
        private System.Windows.Forms.Button deleteuserbtn;
    }
}