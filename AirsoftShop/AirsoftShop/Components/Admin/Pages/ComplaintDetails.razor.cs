using AirsoftShop.Components.Account.Pages.Manage;
using AirsoftShop.Data;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ComplaintDetails
    {
        [Parameter]
        public int ComplaintId { get; set; }

        public required Data.Complaint Complaint { get; set; }

        public required Order Order { get; set; }

        private Dictionary<int, object> ProductDetails { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Complaint = await ComplaintService.GetComplaintByIdAsync(ComplaintId);

            Order = await OrderService.GetOrderByIdAsync(Complaint.OrderId);

            foreach (var item in Complaint.ComplaintItems)
            {
                var productDetails = await ProductService.GetProductDetailsAsync(item.ProductId, item.ProductType);
                if (productDetails is not null)
                {
                    ProductDetails[item.ProductId] = productDetails;
                }
            }
        }

        private async Task HandleSubmit()
        {
            try
            {
                await ComplaintService.UpdateComplaintAsync(Complaint);
                Order.IsDuringComplaint = false;
                await OrderService.UpdateOrderAsync(Order);
                Console.WriteLine("Zg³oszenie zosta³o zaktualizowane.");
                NavManager.NavigateTo("/Admin/Complaints", forceLoad: true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wyst¹pi³ b³¹d: {ex.Message}");
            }
        }

        private void CancelUpdate()
        {
            NavManager.NavigateTo("/Admin/Complaints", forceLoad: true);
        }

        private async Task DeleteOrder()
        {
            await ComplaintService.RemoveComplaintAsync(Complaint.Id);
            NavManager.NavigateTo("/Admin/Complaints", forceLoad: true);
        }
    }
}