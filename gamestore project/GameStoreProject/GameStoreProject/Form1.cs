using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class Form1 : Form
    {
        //Database connection string
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(33, 47, 60);
            // Initialize role selection combo box
            userroleselectioncombobox.Items.Add("customer");
            userroleselectioncombobox.Items.Add("admin");
            userroleselectioncombobox.SelectedIndex = 0;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();
            string role = userroleselectioncombobox.SelectedItem.ToString();
            // Input validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkBoxCaptcha.Checked)
            {
                MessageBox.Show("Please confirm you are not a robot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if user already exists
            bool usernameExists = CheckUsernameExists(name);
            bool emailExists = CheckEmailExists(email);

            if (usernameExists)
            {
                MessageBox.Show("Username already exists. Please choose a different username.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (emailExists)
            {
                MessageBox.Show("Email address is already registered.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Register the user
            int userId = RegisterUser(name, email, password, role);

            if (userId > 0)
            {
                MessageBox.Show($"Account created successfully for {name}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Role-based navigation
                if (role == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    home_page homePage = new home_page(userId);
                    homePage.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to create account. Please try again.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool CheckEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE email = @email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private int RegisterUser(string username, string email, string password, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (username, email, password, role) " +
                              "VALUES (@username, @email, @password, @role); " +
                              "SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password); // In real project, hash this
                command.Parameters.AddWithValue("@role", role);

                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
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
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            checkBoxCaptcha.Checked = false;
            userroleselectioncombobox.SelectedIndex = 0;
        }

        private void buttonGoToLogin_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization if needed
        }

        private void userroleselectioncombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty as requested
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}