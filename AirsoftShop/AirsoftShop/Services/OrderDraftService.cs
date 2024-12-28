using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public class OrderDraftService
    {
        private readonly CartService _cartService;

        public OrderDraft CurrentOrderDraft { get; private set; } = new OrderDraft();

        public OrderDraftService(CartService cartService)
        {
            _cartService = cartService;
            ResetOrderDraft();
        }

        public void ResetOrderDraft()
        {
            CurrentOrderDraft = new OrderDraft
            {
                CartItems = (List<CartItem>)_cartService.GetCartItems()
            };
        }

        public void UpdateCustomerDetails(string name, string surname, string phone, string city, string postalCode, string Address)
        {
            CurrentOrderDraft.CustomerName = name;
            CurrentOrderDraft.CustomerSurname = surname;
            CurrentOrderDraft.PhoneNumber = phone;
            CurrentOrderDraft.City = city;
            CurrentOrderDraft.PostalCode = postalCode;
            CurrentOrderDraft.Address = Address;
        }

        public void UpdatePaymentDetails(PaymentMethod paymentMethod, string? comment)
        {
            CurrentOrderDraft.PaymentMethod = paymentMethod;
            CurrentOrderDraft.CustomerComment = comment;
        }
    }
}
