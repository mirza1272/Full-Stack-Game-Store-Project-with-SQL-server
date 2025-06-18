namespace GameStoreProject
{
    partial class AddUser
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
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rolecombobox = new System.Windows.Forms.ComboBox();
            this.adduserbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(184, 93);
            this.usernametxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(192, 22);
            this.usernametxtbox.TabIndex = 0;
            this.usernametxtbox.TextChanged += new System.EventHandler(this.usernametxtbox_TextChanged);
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(184, 146);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(192, 22);
            this.emailtxtbox.TabIndex = 1;
            this.emailtxtbox.Text = " ";
            this.emailtxtbox.TextChanged += new System.EventHandler(this.emailtxtbox_TextChanged);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(184, 207);
            this.passwordtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(192, 22);
            this.passwordtxtbox.TabIndex = 2;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.passwordtxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "User Details:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(485, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Go To View Users";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rolecombobox
            // 
            this.rolecombobox.FormattingEnabled = true;
            this.rolecombobox.Location = new System.Drawing.Point(184, 266);
            this.rolecombobox.Name = "rolecombobox";
            this.rolecombobox.Size = new System.Drawing.Size(192, 24);
            this.rolecombobox.TabIndex = 10;
            this.rolecombobox.SelectedIndexChanged += new System.EventHandler(this.rolecombobox_SelectedIndexChanged);
            // 
            // adduserbtn
            // 
            this.adduserbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adduserbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adduserbtn.Location = new System.Drawing.Point(72, 305);
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.Size = new System.Drawing.Size(139, 43);
            this.adduserbtn.TabIndex = 11;
            this.adduserbtn.Text = "Add user";
            this.adduserbtn.UseVisualStyleBackColor = false;
            this.adduserbtn.Click += new System.EventHandler(this.adduserbtn_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.adduserbtn);
            this.Controls.Add(this.rolecombobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.usernametxtbox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox rolecombobox;
        private System.Windows.Forms.Button adduserbtn;
    }
}