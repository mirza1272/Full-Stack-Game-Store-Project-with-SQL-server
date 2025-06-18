using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class home_page : Form
    {
        private DataTable gamesDataTable;
        public List<CartItem> Cart = new List<CartItem>();
        private int currentUserId;

        public home_page(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            this.BackColor = Color.FromArgb(33, 47, 60);
            LoadGameData();
            SetupDataGridView();
        }

        private void LoadGameData()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT game_id as Id, title as Title, description as Description, price as Price, genre as Genre, platform as Platform, release_date FROM Games";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        gamesDataTable = new DataTable();
                        adapter.Fill(gamesDataTable);
                        dataGridView1.DataSource = gamesDataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading game data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns["Id"].HeaderText = "Game ID";
            dataGridView1.Columns["Title"].HeaderText = "Title";
            dataGridView1.Columns["Description"].HeaderText = "Description";
            dataGridView1.Columns["Price"].HeaderText = "Price";
            dataGridView1.Columns["Genre"].HeaderText = "Genre";
            dataGridView1.Columns["Platform"].HeaderText = "Platform";
            dataGridView1.Columns["release_date"].HeaderText = "Release Date";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C2";
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            gamesDataTable.DefaultView.RowFilter = "";
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            gamesDataTable.DefaultView.RowFilter = "Genre = 'Action'";
        }

        private void buttonAdventure_Click(object sender, EventArgs e)
        {
            gamesDataTable.DefaultView.RowFilter = "Genre = 'Adventure'";
        }

        private void buttonRPG_Click(object sender, EventArgs e)
        {
            gamesDataTable.DefaultView.RowFilter = "Genre = 'RPG'";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string term = textBoxSearch.Text.Trim();
            gamesDataTable.DefaultView.RowFilter = string.IsNullOrEmpty(term) ? "" : $"Title LIKE '%{term}%' OR Genre LIKE '%{term}%' OR Platform LIKE '%{term}%'";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Close();
        }

        private void buttonAddToCart_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a game first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value == null || selectedRow.Cells["Title"].Value == null)
                {
                    MessageBox.Show("Selected game data is incomplete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var game = new GameModel
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Title = selectedRow.Cells["Title"].Value.ToString(),
                    Genre = selectedRow.Cells["Genre"].Value.ToString(),
                    Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value),
                    Description = selectedRow.Cells["Description"].Value.ToString(),
                    Platform = selectedRow.Cells["Platform"].Value.ToString()
                };

                var existingItem = Cart.FirstOrDefault(item => item.Game.Id == game.Id);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                    MessageBox.Show($"Quantity increased for {game.Title}\nTotal in cart: {existingItem.Quantity}", "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cart.Add(new CartItem(game, 1));
                    MessageBox.Show($"{game.Title} added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewCart_Click_1(object sender, EventArgs e)
        {
            try
            {
                var cartCopy = Cart.Select(item => new CartItem(
                    new GameModel
                    {
                        Id = item.Game.Id,
                        Title = item.Game.Title,
                        Genre = item.Game.Genre,
                        Price = item.Game.Price,
                        Description = item.Game.Description,
                        Platform = item.Game.Platform
                    },
                    item.Quantity
                )).ToList();

                using (CartPage cartPage = new CartPage(cartCopy, currentUserId))
                {
                    this.Hide();

                    if (cartPage.ShowDialog() == DialogResult.OK)
                    {
                        Cart = cartPage.GetCartItems();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewproduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a game first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                var game = new GameModel
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Title = selectedRow.Cells["Title"].Value.ToString(),
                    Genre = selectedRow.Cells["Genre"].Value.ToString(),
                    Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value),
                    Description = selectedRow.Cells["Description"].Value.ToString(),
                    Platform = selectedRow.Cells["Platform"].Value.ToString()
                };

                ProductDetailsPage detailsPage = new ProductDetailsPage(game, Cart);
                this.Hide();
                detailsPage.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}