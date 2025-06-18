using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class ProductDetailsPage : Form
    {
        private GameModel selectedGame;
        private List<CartItem> cart; // The shared cart list from main/home page

        // Updated constructor accepts cart list
        public ProductDetailsPage(GameModel game, List<CartItem> cartItems)
        {
            InitializeComponent();
            selectedGame = game ?? throw new ArgumentNullException(nameof(game));
            cart = cartItems ?? throw new ArgumentNullException(nameof(cartItems));
            DisplayGameDetails();
            this.BackColor = System.Drawing.Color.FromArgb(33, 47, 60); // Dark blue
        }

        private void DisplayGameDetails()
        {
            labelTitle.Text = selectedGame.Title;
            labelGenre.Text = $"Genre: {selectedGame.Genre}";
            labelPlatform.Text = $"Platform: {selectedGame.Platform}";
            labelPrice.Text = $"Price: ${selectedGame.Price:F2}";
            textBoxDescription.Text = selectedGame.Description;

            // Styling text colors
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelGenre.ForeColor = System.Drawing.Color.White;
            labelPlatform.ForeColor = System.Drawing.Color.White;
            labelPrice.ForeColor = System.Drawing.Color.White;
            textBoxDescription.ForeColor = System.Drawing.Color.White;
            textBoxDescription.BackColor = System.Drawing.Color.FromArgb(33, 47, 60);
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                var existingItem = cart.FirstOrDefault(ci => ci.Game.Id == selectedGame.Id);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                    MessageBox.Show($"Increased quantity for {selectedGame.Title}\nNow in cart: {existingItem.Quantity}",
                        "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cart.Add(new CartItem(selectedGame, 1));
                    MessageBox.Show($"{selectedGame.Title} added to cart!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}