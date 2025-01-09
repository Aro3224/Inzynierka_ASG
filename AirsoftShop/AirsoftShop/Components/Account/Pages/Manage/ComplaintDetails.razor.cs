using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class ComplaintDetails
    {
        [Parameter]
        public int complaintId { get; set; }

        public required Data.Complaint Complaint { get; set; }

        private bool IsAuthorized { get; set; }

        private Dictionary<int, object> ProductDetails { get; set; } = new();

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

            Complaint = await ComplaintService.GetComplaintByIdAsync(complaintId);
            if (Complaint is not null && Complaint.UserId == currentUser.Id)
            {
                IsAuthorized = true;
            }
            else
            {
                IsAuthorized = false;
                Complaint = null;
            }

            foreach (var item in Complaint.ComplaintItems)
            {
                var productDetails = await ProductService.GetProductDetailsAsync(item.ProductId, item.ProductType);
                if (productDetails is not null)
                {
                    ProductDetails[item.ProductId] = productDetails;
                }
            }
        }
    }
}