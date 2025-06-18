namespace GameStoreProject
{
    partial class ViewOrders
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
            this.vieworderdetailsbtn = new System.Windows.Forms.Button();
            this.gotoadminpagebtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vieworderdetailsbtn
            // 
            this.vieworderdetailsbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.vieworderdetailsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vieworderdetailsbtn.Location = new System.Drawing.Point(110, 90);
            this.vieworderdetailsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vieworderdetailsbtn.Name = "vieworderdetailsbtn";
            this.vieworderdetailsbtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.vieworderdetailsbtn.Size = new System.Drawing.Size(155, 68);
            this.vieworderdetailsbtn.TabIndex = 0;
            this.vieworderdetailsbtn.Text = "View Orders Detail";
            this.vieworderdetailsbtn.UseVisualStyleBackColor = false;
            this.vieworderdetailsbtn.Click += new System.EventHandler(this.vieworderdetailsbtn_Click);
            // 
            // gotoadminpagebtn
            // 
            this.gotoadminpagebtn.BackColor = System.Drawing.Color.Tan;
            this.gotoadminpagebtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoadminpagebtn.Location = new System.Drawing.Point(414, 219);
            this.gotoadminpagebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gotoadminpagebtn.Name = "gotoadminpagebtn";
            this.gotoadminpagebtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.gotoadminpagebtn.Size = new System.Drawing.Size(165, 60);
            this.gotoadminpagebtn.TabIndex = 1;
            this.gotoadminpagebtn.Text = "Go To Homepage";
            this.gotoadminpagebtn.UseVisualStyleBackColor = false;
            this.gotoadminpagebtn.Click += new System.EventHandler(this.gotoadminpagebtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(110, 218);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.logoutbtn.Size = new System.Drawing.Size(155, 59);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.gotoadminpagebtn);
            this.Controls.Add(this.vieworderdetailsbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewOrders";
            this.Tag = "";
            this.Text = "  View Orders   ";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vieworderdetailsbtn;
        private System.Windows.Forms.Button gotoadminpagebtn;
        private System.Windows.Forms.Button logoutbtn;
    }
}