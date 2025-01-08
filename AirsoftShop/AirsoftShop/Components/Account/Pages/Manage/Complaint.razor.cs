using AirsoftShop.Data;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Complaint
    {
        [Parameter]
        public required int OrderId { get; set; }

        public required Order Order { get; set; }

        private bool IsAuthorized { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity?.IsAuthenticated != true)
            {
                IsAuthorized = false;
                return;
            }

            var currentUser = await UserManager.GetUserAsync(user);
            if (currentUser is null)
            {
                IsAuthorized = false;
                return;
            }

            Order = await OrderService.GetOrderByIdAsync(OrderId);
            if (Order is not null && Order.UserId == currentUser.Id)
            {
                IsAuthorized = true;
            }
            else
            {
                IsAuthorized = false;
                Order = null;
            }
        }


    }
}