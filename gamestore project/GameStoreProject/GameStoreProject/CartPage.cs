using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class CartPage : Form
    {
        private List<CartItem> cartItems;
        private List<CartItem> selectedItems = new List<CartItem>();
        private int currentUserId;

        public CartPage(List<CartItem> items, int userId)
        {
            InitializeComponent();
            cartItems = items ?? new List<CartItem>();
            currentUserId = userId;
            this.BackColor = Color.FromArgb(33, 47, 60);

            if (listViewCart.Columns.Count == 0)
            {
                listViewCart.Columns.Add("Title", 150);
                listViewCart.Columns.Add("Genre", 100);
                listViewCart.Columns.Add("Qty", 50);
                listViewCart.Columns.Add("Unit Price", 80);
                listViewCart.Columns.Add("Total", 80);
                listViewCart.View = View.Details;
                listViewCart.CheckBoxes = true;
                listViewCart.FullRowSelect = true;
            }

            LoadCartItems();
            UpdateTotalPrice();
        }

        public List<CartItem> GetCartItems() => cartItems;
        public List<CartItem> GetSelectedItems() => selectedItems;

        private void LoadCartItems()
        {
            try
            {
                listViewCart.Items.Clear();
                foreach (var item in cartItems)
                {
                    var lvi = new ListViewItem(item.Game.Title);
                    lvi.SubItems.Add(item.Game.Genre);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.Game.Price.ToString("C2"));
                    lvi.SubItems.Add((item.Game.Price * item.Quantity).ToString("C2"));
                    lvi.Tag = item;
                    lvi.Checked = true;
                    listViewCart.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying cart items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalPrice()
        {
            selectedItems = listViewCart.CheckedItems
                .Cast<ListViewItem>()
                .Select(item => (CartItem)item.Tag)
                .ToList();

            decimal total = selectedItems.Sum(i => i.Game.Price * i.Quantity);
            labelTotal.Text = $"Total Selected: {total:C2}";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = (CartItem)listViewCart.SelectedItems[0].Tag;
            cartItems.Remove(item);
            LoadCartItems();
            UpdateTotalPrice();
        }

        private void buttonUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to update quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(textBoxQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter a valid quantity (positive integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (CartItem)listViewCart.SelectedItems[0].Tag;
            item.Quantity = qty;
            LoadCartItems();
            UpdateTotalPrice();
        }

        private void buttonProceedOrder_Click(object sender, EventArgs e)
        {
            selectedItems = listViewCart.CheckedItems
                .Cast<ListViewItem>()
                .Select(item => (CartItem)item.Tag)
                .ToList();

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("No items selected. Please check items to purchase.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (OrderSummaryPage orderSummaryPage = new OrderSummaryPage(selectedItems, currentUserId))
            {
                if (orderSummaryPage.ShowDialog() == DialogResult.OK && orderSummaryPage.OrderConfirmed)
                {
                    foreach (var selectedItem in selectedItems.ToList())
                    {
                        cartItems.Remove(selectedItem);
                    }
                    LoadCartItems();
                    UpdateTotalPrice();
                }
            }
        }

        private void listViewCart_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void backtohome_Click(object sender, EventArgs e)
        {
            home_page homePage = new home_page(currentUserId);
            homePage.Show();
            this.Hide();
        }
    }
}