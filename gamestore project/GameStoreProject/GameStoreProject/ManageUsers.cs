using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color with other forms
        }

        private void viewallusers_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewallusers viewForm = new viewallusers();
            viewForm.ShowDialog();
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser addForm = new AddUser();
            addForm.ShowDialog();
        }

        private void deleteuserbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser deleteForm = new DeleteUser();
            deleteForm.ShowDialog();
        }

        private void gotoadminpage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}