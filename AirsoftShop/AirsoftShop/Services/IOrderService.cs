using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(string userId, string customerName, string customerSurname, string phoneNumber, List<CartItem> cartItems, string shippingAddress, string customerComment, CourierCompany courierCompany, PaymentMethod paymentMethod);

        Task DeleteOrderAsync(int id);

        Task<Order> GetOrderByIdAsync(int id);

        Task<List<Order>> GetOrdersByUserIdAsync(string userId);

        Task UpdateOrderAsync(Order order);

        Task CancelOrderAsync(int orderId);

        Task UpdatePaymentStatusAsync(int orderId, PaymentStatus paymentStatus);
    }
}
