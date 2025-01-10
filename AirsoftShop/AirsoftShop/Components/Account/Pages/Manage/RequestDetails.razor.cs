using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class RequestDetails
    {
        [Parameter]
        public int RequestId { get; set; }

        public required PostWarranty PostWarranty { get; set; }

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

            PostWarranty = await WarrantyService.GetPostWarrantyByIdAsync(RequestId);
            if (PostWarranty is not null && PostWarranty.UserId == currentUser.Id)
            {
                IsAuthorized = true;
            }
            else
            {
                IsAuthorized = false;
                PostWarranty = null;
            }
        }

        private async Task PayForRepair()
        {
            PostWarranty.ServiceStatus = ServiceStatus.Payed;

            await WarrantyService.UpdatePostWarrantyAsync(PostWarranty);
        }
    }
}