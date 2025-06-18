using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace GameStoreProject
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";
        public static int CurrentUserId { get; private set; }
        public static string CurrentUserRole { get; private set; }

        public Form2()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(33, 47, 60);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT user_id, username, password, role FROM Users WHERE email = @email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CurrentUserId = reader.GetInt32(0);
                                string username = reader.GetString(1);
                                string storedPassword = reader.GetString(2);
                                CurrentUserRole = reader.GetString(3);

                                if (password == storedPassword)
                                {
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (CurrentUserRole == "admin")
                                    {
                                        AdminForm adminForm = new AdminForm();
                                        adminForm.Show();
                                    }
                                    else
                                    {
                                        home_page homePage = new home_page(CurrentUserId);
                                        homePage.Show();
                                    }
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No account found with this email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGoToRegister_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}