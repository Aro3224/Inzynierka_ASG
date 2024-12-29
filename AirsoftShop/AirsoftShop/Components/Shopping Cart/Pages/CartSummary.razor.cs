using AirsoftShop.Data;
using AirsoftShop.Services;

namespace AirsoftShop.Components.Shopping_Cart.Pages
{
    public partial class CartSummary
    {
        private Order order = new Order();

        private OrderDraft orderDraft = new OrderDraft();

        private IEnumerable<CartItem> cartItems = new List<CartItem>();

        protected override async Task OnInitializedAsync()
        {
            cartItems = CartService.GetCartItems();

            orderDraft = OrderDraftService.CurrentOrderDraft;

            order.OrderDate = DateTime.Now;
            order.Status = OrderStatus.Created;
            order.PaymentStatus = PaymentStatus.Pending;

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

        private async Task SubmitOrder()
        {
            var userID = await UserService.GetCurrentUserIdAsync();

            var createdOrder = await OrderService.CreateOrderAsync(
                userId: userID,
                customerName: orderDraft.CustomerName,
                customerSurname: orderDraft.CustomerSurname,
                phoneNumber: orderDraft.PhoneNumber,
                cartItems: orderDraft.CartItems,
                shippingAddress: $"{orderDraft.PostalCode} {orderDraft.City} {orderDraft.Address}",
                customerComment: orderDraft.CustomerComment,
                courierCompany: orderDraft.CourierCompany,
                paymentMethod: orderDraft.PaymentMethod
            );

            OrderDraftService.ResetOrderDraft();

            if (userID != null)
            {
                Navigation.NavigateTo("/Account/Manage/Orders");
            }
            else
            {
                Navigation.NavigateTo("/Replicas");
            }
        }
    }
}