using AirsoftShop.Data;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AirsoftShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly IProductService _productService;
        private readonly ApplicationDbContext _context;
        private readonly CartService _cartService;

        public OrderService(ApplicationDbContext context, IProductService productService, CartService cartService)
        {
            _context = context;
            _productService = productService;
            _cartService = cartService;
        }

        public async Task<Order> CreateOrderAsync(
    string userId,
    string customerName,
    string customerSurname,
    string phoneNumber,
    List<CartItem> cartItems,
    string shippingAddress,
    string customerComment,
    CourierCompany courierCompany,
    PaymentMethod paymentMethod)
        {
            var order = new Order
            {
                UserId = userId,
                CustomerName = customerName,
                CustomerSurname = customerSurname,
                PhoneNumber = phoneNumber,
                OrderDate = DateTime.Now,
                OrderStatus = OrderStatus.Created,
                ShippingAddress = shippingAddress,
                PaymentMethod = paymentMethod,
                PaymentStatus = PaymentStatus.Pending,
                CourierCompany = courierCompany,
                CustomerComment = customerComment,
                OrderItems = new List<OrderItem>()
            };

            decimal totalAmount = 0;

            foreach (var cartItem in cartItems)
            {
                var product = await _productService.GetProductDetailsAsync(cartItem.Product.Id, cartItem.Product.ProductType);

                if (product != null)
                {
                    totalAmount += (decimal)(product.Price * cartItem.Quantity);

                    var orderItem = new OrderItem
                    {
                        Quantity = cartItem.Quantity,
                        Price = (decimal)(product.Price * cartItem.Quantity),
                        Order = order
                    };

                    switch (cartItem.Product.ProductType)
                    {
                        case ProductType.Replica:
                            var replica = await _context.Replicas.FindAsync(cartItem.Product.Id);
                            if (replica != null)
                            {
                                if (replica.Count < cartItem.Quantity)
                                {
                                    throw new InvalidOperationException($"Za mało przedmiotów w magazynie dla repliki: {replica.Name}");
                                }
                                replica.Count -= cartItem.Quantity;
                                orderItem.ReplicaId = replica.Id;
                                orderItem.Replica = replica;
                            }
                            break;

                        case ProductType.Part:
                            var part = await _context.Parts.FindAsync(cartItem.Product.Id);
                            if (part != null)
                            {
                                if (part.Count < cartItem.Quantity)
                                {
                                    throw new InvalidOperationException($"Za mało przedmiotów w magazynie dla części: {part.Name}");
                                }
                                part.Count -= cartItem.Quantity;
                                orderItem.PartId = part.Id;
                                orderItem.Part = part;
                            }
                            break;

                        case ProductType.Accessory:
                            var accessory = await _context.Accessories.FindAsync(cartItem.Product.Id);
                            if (accessory != null)
                            {
                                if (accessory.Count < cartItem.Quantity)
                                {
                                    throw new InvalidOperationException($"Za mało przedmiotów w magazynie dla dodatku: {accessory.Name}");
                                }
                                accessory.Count -= cartItem.Quantity;
                                orderItem.AccessoryId = accessory.Id;
                                orderItem.Accessory = accessory;
                            }
                            break;

                        default:
                            throw new ArgumentException("Unknown product type");
                    }

                    order.OrderItems.Add(orderItem);
                }
            }

            order.TotalAmount = totalAmount;

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            _cartService.ClearCart();

            return order;
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Order> GetOrderByIdAsync(int orderId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Replica)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Part)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Accessory)
                .FirstOrDefaultAsync(o => o.Id == orderId);
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
        {
            return await _context.Orders
                .Where(o => o.UserId == userId)
                .ToListAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task CancelOrderAsync(int orderId)
        {
            var order = await GetOrderByIdAsync(orderId);
            if (order != null)
            {
                order.OrderStatus = OrderStatus.Canceled;
                await UpdateOrderAsync(order);
            }
            else
            {
                throw new ArgumentException("Zamówienie nie zostało znalezione");
            }
        }

        public async Task UpdatePaymentStatusAsync(int orderId, PaymentStatus paymentStatus)
        {
            var order = await GetOrderByIdAsync(orderId);
            if (order != null)
            {
                order.PaymentStatus = paymentStatus;
                await UpdateOrderAsync(order);
            }
            else
            {
                throw new ArgumentException("Zamówienie nie zostało znalezione");
            }
        }
    }
}
