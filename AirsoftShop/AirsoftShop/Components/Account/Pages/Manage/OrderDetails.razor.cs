using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class OrderDetails
    {
        [Parameter]
        public required int OrderId { get; set; }

        public required Order Order { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Order = await OrderService.GetOrderByIdAsync(OrderId);

            Console.WriteLine(Order.OrderItems.Count);
        }

        private async Task PayForOrderAsync()
        {
            var paidOrder = Order;

            paidOrder.PaymentStatus = PaymentStatus.Paid;

            await OrderService.UpdateOrderAsync(paidOrder);

            Console.WriteLine("User has paid for order.");

            StateHasChanged();
        }
    }
}