using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class vieworderdetails : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";
        private DataTable ordersDataTable;

        public vieworderdetails()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 47, 60); // Consistent background color
        }

        private void vieworderdetails_Load(object sender, EventArgs e)
        {
            LoadOrderData();
            SetupDataGridView();
        }

        private void LoadOrderData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            order_id AS Id, 
                            user_id AS UserId, 
                            order_date AS OrderDate, 
                            total_amount AS Amount, 
                            status AS Status
                        FROM Orders";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        ordersDataTable = new DataTable();
                        adapter.Fill(ordersDataTable);
                        dataGridView1.DataSource = ordersDataTable;

                        if (ordersDataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No orders found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Error loading order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                dataGridView1.Columns["Id"].HeaderText = "Order ID";
                dataGridView1.Columns["UserId"].HeaderText = "User ID";
                dataGridView1.Columns["OrderDate"].HeaderText = "Order Date";
                dataGridView1.Columns["Amount"].HeaderText = "Amount";
                dataGridView1.Columns["Status"].HeaderText = "Status";

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.ReadOnly = true;
                }
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "C2";
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

        private void gotovieworders_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrders viewOrdersForm = new ViewOrders();
            viewOrdersForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty unless specific cell-click functionality is needed
        }
    }
}