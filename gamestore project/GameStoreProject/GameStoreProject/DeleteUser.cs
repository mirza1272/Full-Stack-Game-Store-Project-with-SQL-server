using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class DeleteUser : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";

        public DeleteUser()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color
        }

        private void deleteuserbtn_Click(object sender, EventArgs e)
        {
            string input = deleteuserbyidorusername.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a user ID or username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isUserId = int.TryParse(input, out int userId);
            string username = isUserId ? null : input;

            // Check if the user exists
            bool userExists = false;
            string foundUsername = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = isUserId
                    ? "SELECT username FROM Users WHERE user_id = @userId"
                    : "SELECT username FROM Users WHERE username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (isUserId)
                        command.Parameters.AddWithValue("@userId", userId);
                    else
                        command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userExists = true;
                            foundUsername = reader.GetString(0);
                        }
                    }
                }

                if (!userExists)
                {
                    MessageBox.Show($"No user found with {(isUserId ? "ID " + userId : "username " + username)}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete related payments, orders, and user in a transaction
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete payments related to user's orders
                        string deletePaymentsQuery = @"
                            DELETE FROM Payments
                            WHERE order_id IN (
                                SELECT order_id FROM Orders WHERE user_id = @userId
                            )";
                        using (SqlCommand command = new SqlCommand(deletePaymentsQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@userId", isUserId ? userId : GetUserIdByUsername(username, connection, transaction));
                            command.ExecuteNonQuery();
                        }

                        // Delete user's orders
                        string deleteOrdersQuery = "DELETE FROM Orders WHERE user_id = @userId";
                        using (SqlCommand command = new SqlCommand(deleteOrdersQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@userId", isUserId ? userId : GetUserIdByUsername(username, connection, transaction));
                            command.ExecuteNonQuery();
                        }

                        // Delete the user
                        string deleteUserQuery = isUserId
                            ? "DELETE FROM Users WHERE user_id = @userId"
                            : "DELETE FROM Users WHERE username = @username";
                        using (SqlCommand command = new SqlCommand(deleteUserQuery, connection, transaction))
                        {
                            if (isUserId)
                                command.Parameters.AddWithValue("@userId", userId);
                            else
                                command.Parameters.AddWithValue("@username", username);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show($"User {foundUsername} and their orders deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                deleteuserbyidorusername.Text = ""; // Clear the textbox
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private int GetUserIdByUsername(string username, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT user_id FROM Users WHERE username = @username";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@username", username);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void gotoadminpage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty unless specific functionality is needed
        }

        private void deleteuserbyidorusername_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }
    }
}