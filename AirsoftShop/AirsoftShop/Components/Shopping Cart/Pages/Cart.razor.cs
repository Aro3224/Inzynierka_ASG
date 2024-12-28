using AirsoftShop.Data;
using AirsoftShop.Services;

namespace AirsoftShop.Components.Shopping_Cart.Pages
{
    public partial class Cart
    {
        public required IEnumerable<CartItem> CartItems { get; set; }

        protected override void OnInitialized()
        {
            CartItems = CartService.GetCartItems();
        }

        private void IncreaseCounterValue(CartItem item)
        {
            if (item.Quantity < item.Product.Count)
            {
                item.Quantity++;
                CartService.UpdateQuantity(item.Product, item.Quantity);
            }
        }

        private void DecreaseCounterValue(CartItem item)
        {
            item.Quantity--;
            CartService.UpdateQuantity(item.Product, item.Quantity);
        }

        private void UpdateCount(CartItem item)
        {
            if (item.Quantity > item.Product.Count)
            {
                item.Quantity = item.Product.Count;
            }
            else if (item.Quantity < 1)
            {
                item.Quantity = 1;
            }

            CartService.UpdateQuantity(item.Product, item.Quantity);
        }

        private void RemoveItem(CartItem item)
        {
            CartService.RemoveFromCart(item.Product);
        }
    }
}