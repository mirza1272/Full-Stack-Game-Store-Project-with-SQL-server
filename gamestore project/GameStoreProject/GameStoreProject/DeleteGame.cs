using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class DeleteGame : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";

        public DeleteGame()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color
        }

        private void deletegamebtn_Click(object sender, EventArgs e)
        {
            string input = gameidortitletxtbox.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a game ID or title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isGameId = int.TryParse(input, out int gameId);
            string title = isGameId ? null : input;

            // Check if the game exists
            bool gameExists = false;
            string foundTitle = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = isGameId
                    ? "SELECT title FROM Games WHERE game_id = @gameId"
                    : "SELECT title FROM Games WHERE title = @title";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (isGameId)
                        command.Parameters.AddWithValue("@gameId", gameId);
                    else
                        command.Parameters.AddWithValue("@title", title);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            gameExists = true;
                            foundTitle = reader.GetString(0);
                        }
                    }
                }

                if (!gameExists)
                {
                    MessageBox.Show($"No game found with {(isGameId ? "ID " + gameId : "title " + title)}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete the game in a transaction
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete the game (Inventory records are automatically deleted due to ON DELETE CASCADE)
                        string deleteGameQuery = isGameId
                            ? "DELETE FROM Games WHERE game_id = @gameId"
                            : "DELETE FROM Games WHERE title = @title";
                        using (SqlCommand command = new SqlCommand(deleteGameQuery, connection, transaction))
                        {
                            if (isGameId)
                                command.Parameters.AddWithValue("@gameId", gameId);
                            else
                                command.Parameters.AddWithValue("@title", title);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show($"Game {foundTitle} deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                gameidortitletxtbox.Text = ""; // Clear the textbox
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Failed to delete game. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error deleting game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gotomanagegamesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGames manageGamesForm = new ManageGames();
            manageGamesForm.Show();
        }

        private void gameidortitletxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }
    }
}