namespace GameStoreProject
{
    partial class paymentmethod
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iban = new System.Windows.Forms.TextBox();
            this.buttonProceedPayment = new System.Windows.Forms.Button();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Proceed Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose payment method:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(458, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter IBAN:";
            // 
            // iban
            // 
            this.iban.Location = new System.Drawing.Point(65, 303);
            this.iban.Name = "iban";
            this.iban.Size = new System.Drawing.Size(458, 22);
            this.iban.TabIndex = 4;
            this.iban.TextChanged += new System.EventHandler(this.iban_TextChanged);
            // 
            // buttonProceedPayment
            // 
            this.buttonProceedPayment.BackColor = System.Drawing.Color.Teal;
            this.buttonProceedPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProceedPayment.Location = new System.Drawing.Point(65, 408);
            this.buttonProceedPayment.Name = "buttonProceedPayment";
            this.buttonProceedPayment.Size = new System.Drawing.Size(170, 73);
            this.buttonProceedPayment.TabIndex = 5;
            this.buttonProceedPayment.Text = "Proceed to Payment";
            this.buttonProceedPayment.UseVisualStyleBackColor = false;
            this.buttonProceedPayment.Click += new System.EventHandler(this.buttonProceedPayment_Click);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalCost.ForeColor = System.Drawing.Color.White;
            this.labelTotalCost.Location = new System.Drawing.Point(60, 357);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(170, 28);
            this.labelTotalCost.TabIndex = 6;
            this.labelTotalCost.Text = "Total Cost: $0.00";
            this.labelTotalCost.Click += new System.EventHandler(this.labelTotalCost_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Teal;
            this.buttonCancel.Location = new System.Drawing.Point(401, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 73);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // paymentmethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(616, 504);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.buttonProceedPayment);
            this.Controls.Add(this.iban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "paymentmethod";
            this.Text = "paymentmethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iban;
        private System.Windows.Forms.Button buttonProceedPayment;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button buttonCancel;
    }
}