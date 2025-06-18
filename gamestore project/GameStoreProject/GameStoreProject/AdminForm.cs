using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color with other forms
        }

        // Manage Users
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsers userForm = new ManageUsers();
            userForm.ShowDialog();
            
        }

        // Manage Games
        private void btnManageGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGames gameForm = new ManageGames();
            gameForm.ShowDialog();
        }

        // View Orders
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrders orderForm = new ViewOrders();
            orderForm.ShowDialog();
        }

        // Logout and return to Login
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        // Admin form load logic
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Optional: Add initialization logic if needed
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 loginForm = new Form2();
            loginForm.Show();
        }
    }
}