namespace GameStoreProject
{
    partial class OrderSummaryPage
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;

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

        /// <summary>
        /// Initialize the components of the form.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOrder
            // 
            this.listViewOrder.Location = new System.Drawing.Point(20, 20);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(600, 300);
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Columns.Add("Game Title", 250);
            this.listViewOrder.Columns.Add("Quantity", 100);
            this.listViewOrder.Columns.Add("Unit Price", 100);
            this.listViewOrder.Columns.Add("Subtotal", 130);
            this.listViewOrder.TabIndex = 0;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalCost.ForeColor = System.Drawing.Color.White;
            this.labelTotalCost.Location = new System.Drawing.Point(20, 330);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(140, 28);
            this.labelTotalCost.TabIndex = 1;
            this.labelTotalCost.Text = "Total Cost: $0.00";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(380, 370);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(120, 40);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(520, 370);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // OrderSummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(33, 47, 60);
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.listViewOrder);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OrderSummaryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Summary";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}