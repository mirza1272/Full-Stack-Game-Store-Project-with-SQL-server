using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class viewallusers : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";
        private DataTable usersDataTable;

        public viewallusers()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color
        }

        private void viewallusers_Load(object sender, EventArgs e)
        {
            LoadUserData();
            SetupDataGridView();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            user_id AS Id, 
                            username AS Username, 
                            email AS Email, 
                            role AS Role, 
                            created_at AS CreatedAt
                        FROM Users";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        usersDataTable = new DataTable();
                        adapter.Fill(usersDataTable);
                        dataGridView1.DataSource = usersDataTable;

                        if (usersDataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No users found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                dataGridView1.Columns["Id"].HeaderText = "User ID";
                dataGridView1.Columns["Username"].HeaderText = "Username";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["Role"].HeaderText = "Role";
                dataGridView1.Columns["CreatedAt"].HeaderText = "Created At"; // Added configuration for CreatedAt

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.ReadOnly = true;
                }
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gotomanageusers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsers manageUsersForm = new ManageUsers();
            manageUsersForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty unless specific cell-click functionality is needed
        }
    }
}