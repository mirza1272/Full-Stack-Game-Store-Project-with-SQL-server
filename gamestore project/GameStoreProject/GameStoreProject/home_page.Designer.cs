namespace GameStoreProject
{
    partial class home_page
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Button buttonAdventure;
        private System.Windows.Forms.Button buttonRPG;

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.Button buttonLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.buttonAdventure = new System.Windows.Forms.Button();
            this.buttonRPG = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonViewCart = new System.Windows.Forms.Button();
            this.viewproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(20, 370);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 60);
            this.buttonAll.TabIndex = 1;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(110, 370);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(75, 60);
            this.buttonAction.TabIndex = 2;
            this.buttonAction.Text = "Action";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonAdventure
            // 
            this.buttonAdventure.Location = new System.Drawing.Point(200, 370);
            this.buttonAdventure.Name = "buttonAdventure";
            this.buttonAdventure.Size = new System.Drawing.Size(90, 60);
            this.buttonAdventure.TabIndex = 3;
            this.buttonAdventure.Text = "Adventure";
            this.buttonAdventure.UseVisualStyleBackColor = true;
            this.buttonAdventure.Click += new System.EventHandler(this.buttonAdventure_Click);
            // 
            // buttonRPG
            // 
            this.buttonRPG.Location = new System.Drawing.Point(300, 370);
            this.buttonRPG.Name = "buttonRPG";
            this.buttonRPG.Size = new System.Drawing.Size(75, 60);
            this.buttonRPG.TabIndex = 4;
            this.buttonRPG.Text = "RPG";
            this.buttonRPG.UseVisualStyleBackColor = true;
            this.buttonRPG.Click += new System.EventHandler(this.buttonRPG_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(20, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 22);
            this.textBoxSearch.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(230, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 30);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(654, 370);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 60);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 310);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(381, 370);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(75, 60);
            this.buttonAddToCart.TabIndex = 9;
            this.buttonAddToCart.Text = "Add to cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click_1);
            // 
            // buttonViewCart
            // 
            this.buttonViewCart.Location = new System.Drawing.Point(462, 370);
            this.buttonViewCart.Name = "buttonViewCart";
            this.buttonViewCart.Size = new System.Drawing.Size(75, 60);
            this.buttonViewCart.TabIndex = 10;
            this.buttonViewCart.Text = "View cart";
            this.buttonViewCart.UseVisualStyleBackColor = true;
            this.buttonViewCart.Click += new System.EventHandler(this.buttonViewCart_Click_1);
            // 
            // viewproduct
            // 
            this.viewproduct.Location = new System.Drawing.Point(543, 370);
            this.viewproduct.Name = "viewproduct";
            this.viewproduct.Size = new System.Drawing.Size(103, 60);
            this.viewproduct.TabIndex = 11;
            this.viewproduct.Text = "View Product";
            this.viewproduct.UseVisualStyleBackColor = true;
            this.viewproduct.Click += new System.EventHandler(this.viewproduct_Click);
            // 
            // home_page
            // 
            this.ClientSize = new System.Drawing.Size(759, 442);
            this.Controls.Add(this.viewproduct);
            this.Controls.Add(this.buttonViewCart);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.buttonAdventure);
            this.Controls.Add(this.buttonRPG);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonLogout);
            this.Name = "home_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Store Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonViewCart;
        private System.Windows.Forms.Button viewproduct;
    }
}