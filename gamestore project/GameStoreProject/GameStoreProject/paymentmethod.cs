using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class paymentmethod : Form
    {
        private readonly int orderId;
        private readonly decimal totalAmount;
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GameStore;Integrated Security=True;Encrypt=False";

        public paymentmethod(int orderId, decimal totalAmount)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.totalAmount = totalAmount;
            comboBox1.Items.AddRange(new string[] { "credit_card", "paypal", "bank_transfer", "crypto" });
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if (totalAmount > 0)
            {
                labelTotalCost.Text = $"Total Cost: {totalAmount:C2}";
            }
            iban.Text = "Enter 14-digit IBAN";
            iban.ForeColor = SystemColors.GrayText;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a payment method to proceed", "Payment Method Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void iban_TextChanged(object sender, EventArgs e)
        {
            if (iban.Text.Length > 0 && iban.Text != "Enter 14-digit IBAN")
            {
                iban.ForeColor = SystemColors.WindowText;
            }
        }

        private void labelTotalCost_Click(object sender, EventArgs e)
        {
        }

        private void buttonProceedPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(iban.Text) || iban.Text == "Enter 14-digit IBAN" || iban.Text.Length != 14)
            {
                MessageBox.Show("Please enter a valid 14-digit IBAN number", "Invalid IBAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string paymentMethod = comboBox1.SelectedItem.ToString();

                if (ProcessPayment(paymentMethod))
                {
                    MessageBox.Show($"Payment of {totalAmount:C2} processed successfully!\nOrder #{orderId} will be delivered soon.", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment failed: {ex.Message}", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ProcessPayment(string paymentMethod)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Payments 
                               (order_id, amount, payment_method, status) 
                               VALUES (@orderId, @amount, @method, 'completed')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@amount", totalAmount);
                    cmd.Parameters.AddWithValue("@method", paymentMethod);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        query = "UPDATE Orders SET status = 'delivered' WHERE order_id = @orderId";
                        cmd.CommandText = query;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    return false;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void iban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}