using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Orders
    {
        public required List<Order> OrdersList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var userID = await UserService.GetCurrentUserIdAsync();

            OrdersList = await OrderService.GetOrdersByUserIdAsync(userID);
        }
    }
}