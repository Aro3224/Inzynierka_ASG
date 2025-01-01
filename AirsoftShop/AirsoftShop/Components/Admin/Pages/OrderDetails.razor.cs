using AirsoftShop.Data;
using AirsoftShop.Services;
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
    }
}