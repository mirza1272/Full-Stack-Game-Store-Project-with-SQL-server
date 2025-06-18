using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class OrderSummaryPage : Form
    {
        private List<CartItem> cartItems;
        private int orderId;
        private int currentUserId;
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";
        public bool OrderConfirmed { get; private set; } = false;

        public OrderSummaryPage(List<CartItem> items, int userId)
        {
            InitializeComponent();
            cartItems = items ?? new List<CartItem>();
            currentUserId = userId;
            this.BackColor = Color.FromArgb(33, 47, 60);
            orderId = CreateOrder();
            if (orderId > 0)
            {
                AddOrderItems();
                LoadOrderSummary();
            }
            else
            {
                MessageBox.Show("Failed to create order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadOrderSummary()
        {
            listViewOrder.Items.Clear();
            listViewOrder.View = View.Details;

            if (listViewOrder.Columns.Count == 0)
            {
                listViewOrder.Columns.Add("Game Title", 200);
                listViewOrder.Columns.Add("Quantity", 80);
                listViewOrder.Columns.Add("Unit Price", 100);
                listViewOrder.Columns.Add("Total", 100);
            }

            foreach (var item in cartItems)
            {
                var lvi = new ListViewItem(item.Game.Title);
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Game.Price.ToString("C2"));
                lvi.SubItems.Add((item.Game.Price * item.Quantity).ToString("C2"));
                listViewOrder.Items.Add(lvi);
            }

            decimal total = cartItems.Sum(i => i.Game.Price * i.Quantity);
            labelTotalCost.Text = $"Total Cost: {total:C2}";
        }

        private int CreateOrder()
        {
            try
            {
                decimal totalAmount = cartItems.Sum(i => i.Game.Price * i.Quantity);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Orders (user_id, total_amount, status) 
                                   VALUES (@userId, @totalAmount, 'pending');
                                   SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void AddOrderItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (var item in cartItems)
                    {
                        string query = @"INSERT INTO Order_Items 
                                       (order_id, game_id, quantity, unit_price)
                                       VALUES (@orderId, @gameId, @quantity, @unitPrice)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@orderId", orderId);
                            cmd.Parameters.AddWithValue("@gameId", item.Game.Id);
                            cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                            cmd.Parameters.AddWithValue("@unitPrice", item.Game.Price);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            decimal totalAmount = cartItems.Sum(i => i.Game.Price * i.Quantity);

            using (paymentmethod paymentForm = new paymentmethod(orderId, totalAmount))
            {
                this.Hide();

                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    OrderConfirmed = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("cancelled");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool UpdateOrderStatus(string status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Orders SET status = @status WHERE order_id = @orderId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}