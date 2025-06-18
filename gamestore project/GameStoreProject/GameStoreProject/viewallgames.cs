using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class viewallgames : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";
        private DataTable gamesDataTable;

        public viewallgames()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color
        }

        private void viewallgames_Load(object sender, EventArgs e)
        {
            LoadGameData();
            SetupDataGridView();
        }

        private void LoadGameData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            game_id AS Id, 
                            title AS Title, 
                            COALESCE(description, '') AS Description, 
                            price AS Price, 
                            COALESCE(genre, '') AS Genre, 
                            COALESCE(platform, '') AS Platform, 
                            release_date AS ReleaseDate 
                        FROM Games";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        gamesDataTable = new DataTable();
                        adapter.Fill(gamesDataTable);
                        dataGridView1.DataSource = gamesDataTable;

                        if (gamesDataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No games found in the database. Please add games using the Add Game form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Error loading game data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                dataGridView1.Columns["Id"].HeaderText = "Game ID";
                dataGridView1.Columns["Title"].HeaderText = "Title";
                dataGridView1.Columns["Description"].HeaderText = "Description";
                dataGridView1.Columns["Price"].HeaderText = "Price";
                dataGridView1.Columns["Genre"].HeaderText = "Genre";
                dataGridView1.Columns["Platform"].HeaderText = "Platform";
                dataGridView1.Columns["ReleaseDate"].HeaderText = "Release Date";

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
                dataGridView1.MultiSelect = false;

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGames manageGamesForm = new ManageGames();
            manageGamesForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty unless specific cell-click functionality is needed
        }
    }
}