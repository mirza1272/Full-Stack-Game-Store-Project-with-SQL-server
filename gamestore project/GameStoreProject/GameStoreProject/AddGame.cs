using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class AddGame : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";

        public AddGame()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color
            dateTimePicker1.Value = DateTime.Today; // Default to today
        }

        private void addgamebtn_Click(object sender, EventArgs e)
        {
            string title = titletxtbox.Text.Trim();
            string description = descriptiontxtbox.Text.Trim();
            string genre = genretxtbox.Text.Trim();
            string priceText = pricetxtbox.Text.Trim();
            string platform = platformtxtbox.Text.Trim();
            DateTime releaseDate = dateTimePicker1.Value;

            // Input validation
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(genre) || string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(platform))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price) || price < 0 || price > 99999999.99m)
            {
                MessageBox.Show("Please enter a valid price (0 to 99999.99).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if title already exists
            if (CheckTitleExists(title))
            {
                MessageBox.Show("A game with this title already exists. Please choose a different title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the game and inventory record
            bool success = AddGameToDatabase(title, description, price, genre, platform, releaseDate);

            if (success)
            {
                MessageBox.Show($"Game {title} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add game. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckTitleExists(string title)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Games WHERE title = @title";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool AddGameToDatabase(string title, string description, decimal price, string genre, string platform, DateTime releaseDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert into Games table
                        string gameQuery = @"
                            INSERT INTO Games (title, description, price, genre, platform, release_date)
                            VALUES (@title, @description, @price, @genre, @platform, @release_date);
                            SELECT SCOPE_IDENTITY();";

                        int gameId;
                        using (SqlCommand command = new SqlCommand(gameQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@title", title);
                            command.Parameters.AddWithValue("@description", description);
                            command.Parameters.AddWithValue("@price", price);
                            command.Parameters.AddWithValue("@genre", genre);
                            command.Parameters.AddWithValue("@platform", platform);
                            command.Parameters.AddWithValue("@release_date", releaseDate);
                            gameId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Insert into Inventory table
                        string inventoryQuery = @"
                            INSERT INTO Inventory (game_id, quantity)
                            VALUES (@game_id, @quantity)";

                        using (SqlCommand command = new SqlCommand(inventoryQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@game_id", gameId);
                            command.Parameters.AddWithValue("@quantity", 0); // Default quantity
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error adding game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        private void ClearForm()
        {
            titletxtbox.Text = "";
            descriptiontxtbox.Text = "";
            genretxtbox.Text = "";
            pricetxtbox.Text = "";
            platformtxtbox.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }

        private void gotomanagegames_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGames manageGamesForm = new ManageGames();
            manageGamesForm.Show();
        }

        private void titletxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void descriptiontxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void genretxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void pricetxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void platformtxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }
    }
}