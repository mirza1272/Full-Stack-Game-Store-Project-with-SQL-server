namespace GameStoreProject
{
    partial class ManageGames
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
            this.viewallgames = new System.Windows.Forms.Button();
            this.deletgamebtn = new System.Windows.Forms.Button();
            this.addgamebtn = new System.Windows.Forms.Button();
            this.gotoadminpagetn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewallgames
            // 
            this.viewallgames.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewallgames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallgames.Location = new System.Drawing.Point(101, 56);
            this.viewallgames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewallgames.Name = "viewallgames";
            this.viewallgames.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.viewallgames.Size = new System.Drawing.Size(144, 46);
            this.viewallgames.TabIndex = 0;
            this.viewallgames.Text = "View All Games";
            this.viewallgames.UseVisualStyleBackColor = false;
            this.viewallgames.Click += new System.EventHandler(this.viewallgames_Click);
            // 
            // deletgamebtn
            // 
            this.deletgamebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletgamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletgamebtn.Location = new System.Drawing.Point(101, 146);
            this.deletgamebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletgamebtn.Name = "deletgamebtn";
            this.deletgamebtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.deletgamebtn.Size = new System.Drawing.Size(144, 48);
            this.deletgamebtn.TabIndex = 1;
            this.deletgamebtn.Text = "Delete Game";
            this.deletgamebtn.UseVisualStyleBackColor = false;
            this.deletgamebtn.Click += new System.EventHandler(this.deletgamebtn_Click);
            // 
            // addgamebtn
            // 
            this.addgamebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addgamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addgamebtn.Location = new System.Drawing.Point(101, 234);
            this.addgamebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addgamebtn.Name = "addgamebtn";
            this.addgamebtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.addgamebtn.Size = new System.Drawing.Size(144, 47);
            this.addgamebtn.TabIndex = 2;
            this.addgamebtn.Text = "Add Game";
            this.addgamebtn.UseVisualStyleBackColor = false;
            this.addgamebtn.Click += new System.EventHandler(this.addgamebtn_Click);
            // 
            // gotoadminpagetn
            // 
            this.gotoadminpagetn.BackColor = System.Drawing.Color.BurlyWood;
            this.gotoadminpagetn.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoadminpagetn.Location = new System.Drawing.Point(484, 260);
            this.gotoadminpagetn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gotoadminpagetn.Name = "gotoadminpagetn";
            this.gotoadminpagetn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.gotoadminpagetn.Size = new System.Drawing.Size(139, 54);
            this.gotoadminpagetn.TabIndex = 3;
            this.gotoadminpagetn.Text = "Go To Homepage";
            this.gotoadminpagetn.UseVisualStyleBackColor = false;
            this.gotoadminpagetn.Click += new System.EventHandler(this.gotoadminpagetn_Click);
            // 
            // ManageGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.gotoadminpagetn);
            this.Controls.Add(this.addgamebtn);
            this.Controls.Add(this.deletgamebtn);
            this.Controls.Add(this.viewallgames);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageGames";
            this.Text = "ManageGames";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewallgames;
        private System.Windows.Forms.Button deletgamebtn;
        private System.Windows.Forms.Button addgamebtn;
        private System.Windows.Forms.Button gotoadminpagetn;
    }
}