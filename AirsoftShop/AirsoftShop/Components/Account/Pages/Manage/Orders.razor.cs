using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Orders
    {
        [CascadingParameter]
        private HttpContext? HttpContext { get; set; } = default!;

        private ApplicationUser user = default!;

        public required List<Order> OrdersList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            user = await UserAccessor.GetRequiredUserAsync(HttpContext);

            var userID = await UserService.GetCurrentUserIdAsync();

            OrdersList = await OrderService.GetOrdersByUserIdAsync(userID);
        }

        private void NavigateToDetails(int OrderId)
        {
            Console.WriteLine($"Test: {OrderId}");
            //Navigation.NavigateTo($"/Replicas");
            //RedirectManager.RedirectTo("/Account/Manage/Orders/{OrderId}");
        }
    }
}