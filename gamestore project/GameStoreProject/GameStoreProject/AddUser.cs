using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class AddUser : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";

        public AddUser()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color

            // Initialize role combobox
            rolecombobox.Items.Add("customer");
            rolecombobox.Items.Add("admin");
            rolecombobox.SelectedIndex = 0; // Default to customer
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxtbox.Text.Trim();
            string email = emailtxtbox.Text.Trim();
            string password = passwordtxtbox.Text.Trim();
            string role = rolecombobox.SelectedItem?.ToString();

            // Input validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsStrongPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, numbers, and special characters.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username or email already exists
            if (CheckUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckEmailExists(email))
            {
                MessageBox.Show("Email address is already registered.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Register the user with plain-text password
            bool success = RegisterUser(username, email, password, role);

            if (success)
            {
                MessageBox.Show($"User {username} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to create user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsers manageUsersForm = new ManageUsers();
            manageUsersForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewallusers viewAllUsersForm = new viewallusers();
            viewAllUsersForm.Show();
        }

        private bool CheckUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool CheckEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE email = @email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool RegisterUser(string username, string email, string password, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (username, email, password, role) " +
                                  "VALUES (@username, @email, @password, @role)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password); // Store plain text
                        command.Parameters.AddWithValue("@role", role);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsStrongPassword(string password)
        {
            return password.Length >= 8 &&
                   Regex.IsMatch(password, "[A-Z]") &&
                   Regex.IsMatch(password, "[a-z]") &&
                   Regex.IsMatch(password, "[0-9]") &&
                   Regex.IsMatch(password, "[^a-zA-Z0-9]");
        }

        private void ClearForm()
        {
            usernametxtbox.Text = "";
            emailtxtbox.Text = "";
            passwordtxtbox.Text = "";
            rolecombobox.SelectedIndex = 0;
        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void emailtxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void passwordtxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation if needed
        }

        private void rolecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle role selection changes if needed
        }
    }
}