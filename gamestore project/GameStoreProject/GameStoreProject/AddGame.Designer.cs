namespace GameStoreProject
{
    partial class AddGame
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
            this.titletxtbox = new System.Windows.Forms.TextBox();
            this.descriptiontxtbox = new System.Windows.Forms.TextBox();
            this.genretxtbox = new System.Windows.Forms.TextBox();
            this.pricetxtbox = new System.Windows.Forms.TextBox();
            this.platformtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gotomanagegames = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addgamebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titletxtbox
            // 
            this.titletxtbox.Location = new System.Drawing.Point(171, 74);
            this.titletxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titletxtbox.Name = "titletxtbox";
            this.titletxtbox.Size = new System.Drawing.Size(157, 22);
            this.titletxtbox.TabIndex = 0;
            this.titletxtbox.TextChanged += new System.EventHandler(this.titletxtbox_TextChanged);
            // 
            // descriptiontxtbox
            // 
            this.descriptiontxtbox.Location = new System.Drawing.Point(171, 130);
            this.descriptiontxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptiontxtbox.Name = "descriptiontxtbox";
            this.descriptiontxtbox.Size = new System.Drawing.Size(157, 22);
            this.descriptiontxtbox.TabIndex = 1;
            this.descriptiontxtbox.TextChanged += new System.EventHandler(this.descriptiontxtbox_TextChanged);
            // 
            // genretxtbox
            // 
            this.genretxtbox.Location = new System.Drawing.Point(171, 183);
            this.genretxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genretxtbox.Name = "genretxtbox";
            this.genretxtbox.Size = new System.Drawing.Size(157, 22);
            this.genretxtbox.TabIndex = 2;
            this.genretxtbox.TextChanged += new System.EventHandler(this.genretxtbox_TextChanged);
            // 
            // pricetxtbox
            // 
            this.pricetxtbox.Location = new System.Drawing.Point(171, 232);
            this.pricetxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricetxtbox.Name = "pricetxtbox";
            this.pricetxtbox.Size = new System.Drawing.Size(157, 22);
            this.pricetxtbox.TabIndex = 3;
            this.pricetxtbox.TextChanged += new System.EventHandler(this.pricetxtbox_TextChanged);
            // 
            // platformtxtbox
            // 
            this.platformtxtbox.Location = new System.Drawing.Point(472, 82);
            this.platformtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformtxtbox.Name = "platformtxtbox";
            this.platformtxtbox.Size = new System.Drawing.Size(178, 22);
            this.platformtxtbox.TabIndex = 4;
            this.platformtxtbox.TextChanged += new System.EventHandler(this.platformtxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "GameTitle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Platform:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Release Date:";
            // 
            // gotomanagegames
            // 
            this.gotomanagegames.BackColor = System.Drawing.Color.BurlyWood;
            this.gotomanagegames.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotomanagegames.ForeColor = System.Drawing.Color.Black;
            this.gotomanagegames.Location = new System.Drawing.Point(493, 256);
            this.gotomanagegames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gotomanagegames.Name = "gotomanagegames";
            this.gotomanagegames.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.gotomanagegames.Size = new System.Drawing.Size(125, 58);
            this.gotomanagegames.TabIndex = 13;
            this.gotomanagegames.Text = "Go To Homepage";
            this.gotomanagegames.UseVisualStyleBackColor = false;
            this.gotomanagegames.Click += new System.EventHandler(this.gotomanagegames_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(472, 129);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // addgamebtn
            // 
            this.addgamebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addgamebtn.Location = new System.Drawing.Point(80, 290);
            this.addgamebtn.Name = "addgamebtn";
            this.addgamebtn.Size = new System.Drawing.Size(118, 39);
            this.addgamebtn.TabIndex = 15;
            this.addgamebtn.Text = "Add Game";
            this.addgamebtn.UseVisualStyleBackColor = false;
            this.addgamebtn.Click += new System.EventHandler(this.addgamebtn_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.addgamebtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gotomanagegames);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platformtxtbox);
            this.Controls.Add(this.pricetxtbox);
            this.Controls.Add(this.genretxtbox);
            this.Controls.Add(this.descriptiontxtbox);
            this.Controls.Add(this.titletxtbox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titletxtbox;
        private System.Windows.Forms.TextBox descriptiontxtbox;
        private System.Windows.Forms.TextBox genretxtbox;
        private System.Windows.Forms.TextBox pricetxtbox;
        private System.Windows.Forms.TextBox platformtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button gotomanagegames;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addgamebtn;
    }
}