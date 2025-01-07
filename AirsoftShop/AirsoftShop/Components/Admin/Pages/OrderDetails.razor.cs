using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class OrderDetails
    {
        [Parameter]
        public required int OrderId { get; set; }

        public required Order Order { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Order = await OrderService.GetOrderByIdAsync(OrderId);
        }

        private async Task HandleSubmit()
        {
            try
            {
                await OrderService.UpdateOrderAsync(Order);
                Console.WriteLine("Zamówienie zosta³o zaktualizowane.");
                NavManager.NavigateTo("/Admin/Orders");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wyst¹pi³ b³¹d: {ex.Message}");
            }
        }

        private void CancelUpdate()
        {
            NavManager.NavigateTo("/Admin/Orders", forceLoad: true);
        }

        private async Task DeleteOrder()
        {
            await OrderService.DeleteOrderAsync(Order.Id);
            NavManager.NavigateTo("/Admin/Orders", forceLoad: true);
        }
    }
}