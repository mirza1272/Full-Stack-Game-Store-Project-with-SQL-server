namespace GameStoreProject
{
    public class CartItem
    {
        public GameModel Game { get; set; }
        public int Quantity { get; set; }

        public CartItem(GameModel game, int quantity)
        {
            Game = game;
            Quantity = quantity;
        }
    }
}