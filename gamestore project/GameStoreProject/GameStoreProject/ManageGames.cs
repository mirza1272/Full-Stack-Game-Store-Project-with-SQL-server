using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class ManageGames : Form
    {
        public ManageGames()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color
        }

        private void viewallgames_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewallgames viewForm = new viewallgames();
            viewForm.ShowDialog();
        }

        private void deletgamebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteGame deleteForm = new DeleteGame();
            deleteForm.ShowDialog();
        }

        private void addgamebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame addForm = new AddGame();
            addForm.ShowDialog();
        }

        private void gotoadminpagetn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}