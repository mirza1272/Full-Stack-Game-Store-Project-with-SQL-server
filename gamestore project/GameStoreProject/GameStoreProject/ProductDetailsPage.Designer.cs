// ProductDetailsPage.Designer.cs
namespace GameStoreProject
{
    partial class ProductDetailsPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(400, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Game Title";
            // 
            // labelGenre
            // 
            this.labelGenre.ForeColor = System.Drawing.Color.White;
            this.labelGenre.Location = new System.Drawing.Point(30, 70);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(200, 23);
            this.labelGenre.TabIndex = 1;
            this.labelGenre.Text = "Genre:";
            // 
            // labelPlatform
            // 
            this.labelPlatform.ForeColor = System.Drawing.Color.White;
            this.labelPlatform.Location = new System.Drawing.Point(30, 100);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(200, 23);
            this.labelPlatform.TabIndex = 2;
            this.labelPlatform.Text = "Platform:";
            // 
            // labelPrice
            // 
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(30, 130);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(200, 23);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.textBoxDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxDescription.Location = new System.Drawing.Point(30, 170);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(400, 150);
            this.textBoxDescription.TabIndex = 4;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddToCart.ForeColor = System.Drawing.Color.White;
            this.buttonAddToCart.Location = new System.Drawing.Point(30, 340);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(150, 40);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "Add to Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(280, 340);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 40);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ProductDetailsPage
            // 
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.buttonBack);
            this.Name = "ProductDetailsPage";
            this.Text = "Game Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}