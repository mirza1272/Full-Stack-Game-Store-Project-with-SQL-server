namespace GameStoreProject
{
    partial class DeleteGame
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
            this.gameidortitletxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gotomanagegamesbtn = new System.Windows.Forms.Button();
            this.deletegamebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameidortitletxtbox
            // 
            this.gameidortitletxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameidortitletxtbox.Location = new System.Drawing.Point(116, 168);
            this.gameidortitletxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameidortitletxtbox.Name = "gameidortitletxtbox";
            this.gameidortitletxtbox.Size = new System.Drawing.Size(272, 27);
            this.gameidortitletxtbox.TabIndex = 0;
            this.gameidortitletxtbox.TextChanged += new System.EventHandler(this.gameidortitletxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Required Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Game ID OR Title:";
            // 
            // gotomanagegamesbtn
            // 
            this.gotomanagegamesbtn.BackColor = System.Drawing.Color.BurlyWood;
            this.gotomanagegamesbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotomanagegamesbtn.ForeColor = System.Drawing.Color.Black;
            this.gotomanagegamesbtn.Location = new System.Drawing.Point(470, 263);
            this.gotomanagegamesbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gotomanagegamesbtn.Name = "gotomanagegamesbtn";
            this.gotomanagegamesbtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.gotomanagegamesbtn.Size = new System.Drawing.Size(119, 50);
            this.gotomanagegamesbtn.TabIndex = 5;
            this.gotomanagegamesbtn.Text = "Go To Homepage";
            this.gotomanagegamesbtn.UseVisualStyleBackColor = false;
            this.gotomanagegamesbtn.Click += new System.EventHandler(this.gotomanagegamesbtn_Click);
            // 
            // deletegamebtn
            // 
            this.deletegamebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deletegamebtn.Location = new System.Drawing.Point(116, 237);
            this.deletegamebtn.Name = "deletegamebtn";
            this.deletegamebtn.Size = new System.Drawing.Size(147, 44);
            this.deletegamebtn.TabIndex = 6;
            this.deletegamebtn.Text = "Delete";
            this.deletegamebtn.UseVisualStyleBackColor = false;
            this.deletegamebtn.Click += new System.EventHandler(this.deletegamebtn_Click);
            // 
            // DeleteGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.deletegamebtn);
            this.Controls.Add(this.gotomanagegamesbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameidortitletxtbox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteGame";
            this.Text = "Delete Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameidortitletxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gotomanagegamesbtn;
        private System.Windows.Forms.Button deletegamebtn;
    }
}