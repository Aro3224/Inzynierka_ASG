using AirsoftShop.Data;
namespace AirsoftShop.Services
{
    public class CartService
    {
        private readonly List<CartItem> _cartItems;

        public CartService()
        {
            _cartItems = new List<CartItem>();
        }

        public IEnumerable<CartItem> GetCartItems() => _cartItems;

        public int GetTotalCount()
        {
            return _cartItems.Sum(item => item.Quantity);
        }

        public event Action? CartChanged;

        private void NotifyCartChanged() => CartChanged?.Invoke();

        public void AddToCart(Product product, int quantity = 1)
        {
            if (product == null || quantity <= 0)
                return;

            var existingItem = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    Product = product,
                    Quantity = quantity
                });
            }

            if (existingItem?.Quantity > product.Count)
            {
                existingItem.Quantity = product.Count;

                Console.WriteLine($"Quantity added was bigger than available. Changing to max {product.Count}");
            }

            Console.WriteLine($"Added item to cart. Current items: {_cartItems.Count}");

            NotifyCartChanged();
        }

        public void RemoveFromCart(int productId)
        {
            var itemToRemove = _cartItems.FirstOrDefault(item => item.Product.Id == productId);
            if (itemToRemove != null)
            {
                _cartItems.Remove(itemToRemove);
            }

            NotifyCartChanged();
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            if (quantity <= 0)
            {
                RemoveFromCart(productId);
                return;
            }

            var existingItem = _cartItems.FirstOrDefault(item => item.Product.Id == productId);
            if (existingItem != null)
            {
                existingItem.Quantity = quantity;
            }
        }

        public decimal GetTotalPrice()
        {
            return _cartItems.Sum(item => item.Product.Price.GetValueOrDefault() * item.Quantity);
        }

        public void ClearCart()
        {
            _cartItems.Clear();
        }
    }
}
