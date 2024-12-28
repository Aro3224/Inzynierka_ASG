using System.ComponentModel.DataAnnotations;
using AirsoftShop.Data;
using AirsoftShop.Services;

namespace AirsoftShop.Components.Shopping_Cart.Pages
{
    public partial class OrderDetails
    {
        private Order order = new Order();
        private IEnumerable<CartItem> cartItems = new List<CartItem>();

        [Required]
        private string? city { get; set; }

        [Required]
        private string? postalCode { get; set; }

        [Required]
        private string? address { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var userId = await UserService.GetCurrentUserIdAsync();
            cartItems = CartService.GetCartItems();

            order.UserId = userId;
            order.OrderDate = DateTime.Now;
            order.Status = OrderStatus.Created;
            order.PaymentStatus = PaymentStatus.Pending;

            if (!string.IsNullOrEmpty(userId))
            {
                var userDetails = await UserService.Details(userId);

                order.CustomerName = userDetails.Name;
                order.CustomerSurname = userDetails.Surname;
                order.PhoneNumber = userDetails.PhoneNumber;
                city = userDetails.City;
                postalCode = userDetails.PostalCode;
                address = userDetails.Address;

                UpdateShippingAddress();
            }

            order.OrderItems = cartItems.Select(item =>
            {
                var orderItem = new OrderItem
                {
                    Quantity = item.Quantity,
                    Price = (decimal)item.Product.Price,
                    Order = order
                };

                if (item.Product is Replica replica)
                {
                    orderItem.ReplicaId = replica.Id;
                }
                else if (item.Product is Part part)
                {
                    orderItem.PartId = part.Id;
                }
                else if (item.Product is Accessory accessory)
                {
                    orderItem.AccessoryId = accessory.Id;
                }

                return orderItem;
            }).ToList();
        }

        private void UpdateShippingAddress()
        {
            order.ShippingAddress = $"{postalCode} {city} {address}".Trim();
        }

        private async Task HandleValidSubmit()
        {
            var createdOrder = await OrderService.CreateOrderAsync(
                order.UserId,
                order.CustomerName,
                order.CustomerSurname,
                order.PhoneNumber,
                cartItems.ToList(),
                order.ShippingAddress,
                order.CustomerComment,
                order.PaymentMethod
            );

            if (order.UserId != null)
            {
                Navigation.NavigateTo($"/Account/Manage/Orders");
            }
            else
            {
                Navigation.NavigateTo($"/Replicas");
            }
        }
    }
}
