using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(string userId, List<CartItem> cartItems, string shippingAddress, PaymentMethod paymentMethod);

        Task DeleteOrderAsync(int id);

        Task<Order> GetOrderByIdAsync(int id);

        Task<List<Order>> GetOrdersByUserIdAsync(string userId);

        Task UpdateOrderAsync(Order order);

        Task CancelOrderAsync(int orderId);

        Task UpdatePaymentStatusAsync(int orderId, PaymentStatus paymentStatus);
    }
}
