namespace GameStoreProject
{
    partial class CartPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdateQuantity;
        private System.Windows.Forms.Button buttonProceedOrder;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdateQuantity = new System.Windows.Forms.Button();
            this.buttonProceedOrder = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.listViewCart = new System.Windows.Forms.ListView();
            this.backtohome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(20, 340);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 30);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove Selected";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdateQuantity
            // 
            this.buttonUpdateQuantity.Location = new System.Drawing.Point(320, 340);
            this.buttonUpdateQuantity.Name = "buttonUpdateQuantity";
            this.buttonUpdateQuantity.Size = new System.Drawing.Size(150, 30);
            this.buttonUpdateQuantity.TabIndex = 2;
            this.buttonUpdateQuantity.Text = "Update Quantity";
            this.buttonUpdateQuantity.UseVisualStyleBackColor = true;
            this.buttonUpdateQuantity.Click += new System.EventHandler(this.buttonUpdateQuantity_Click);
            // 
            // buttonProceedOrder
            // 
            this.buttonProceedOrder.Location = new System.Drawing.Point(487, 340);
            this.buttonProceedOrder.Name = "buttonProceedOrder";
            this.buttonProceedOrder.Size = new System.Drawing.Size(133, 30);
            this.buttonProceedOrder.TabIndex = 3;
            this.buttonProceedOrder.Text = "Proceed to Order";
            this.buttonProceedOrder.UseVisualStyleBackColor = true;
            this.buttonProceedOrder.Click += new System.EventHandler(this.buttonProceedOrder_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(230, 344);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(70, 22);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(160, 347);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(58, 16);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(20, 390);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(94, 28);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total: $0";
            // 
            // listViewCart
            // 
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.GridLines = true;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(20, 20);
            this.listViewCart.MultiSelect = false;
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(600, 300);
            this.listViewCart.TabIndex = 0;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // backtohome
            // 
            this.backtohome.Location = new System.Drawing.Point(487, 388);
            this.backtohome.Name = "backtohome";
            this.backtohome.Size = new System.Drawing.Size(133, 30);
            this.backtohome.TabIndex = 7;
            this.backtohome.Text = "Back to Home";
            this.backtohome.UseVisualStyleBackColor = true;
            this.backtohome.Click += new System.EventHandler(this.backtohome_Click);
            // 
            // CartPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.backtohome);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonProceedOrder);
            this.Controls.Add(this.buttonUpdateQuantity);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listViewCart);
            this.Name = "CartPage";
            this.Text = "Shopping Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.Button backtohome;
    }
}