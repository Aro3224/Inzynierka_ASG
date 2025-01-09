using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ComplaintDetails
    {
        [Parameter]
        public int ComplaintId { get; set; }

        public required Data.Complaint Complaint { get; set; }

        private Dictionary<int, object> ProductDetails { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Complaint = await ComplaintService.GetComplaintByIdAsync(ComplaintId);

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