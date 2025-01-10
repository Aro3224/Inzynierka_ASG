using AirsoftShop.Data;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ServiceRequestDetails
    {
        [Parameter]
        public int RequestId { get; set; }

        public required PostWarranty PostWarranty { get; set; }

        private string? errorMessage;

        protected override async Task OnInitializedAsync()
        {
            PostWarranty = await WarrantyService.GetPostWarrantyByIdAsync(RequestId);
        }

        private async Task HandleSubmit()
        {
            if (PostWarranty.ServiceAnswer == "")
            {
                errorMessage = "Wpisz odpowiedü!";
            }
            else
            {
                try
                {
                    await WarrantyService.UpdatePostWarrantyAsync(PostWarranty);
                    Console.WriteLine("Zg≥oszenie zosta≥o zaktualizowane.");
                    errorMessage = null;
                    NavManager.NavigateTo("/Admin/ServiceRequests", forceLoad: true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystπpi≥ b≥πd: {ex.Message}");
                }
            }
        }

        private void CancelUpdate()
        {
            NavManager.NavigateTo("/Admin/ServiceRequests", forceLoad: true);
        }

        private async Task DeleteOrder()
        {
            await WarrantyService.RemovePostWarrantyAsync(PostWarranty.Id);
            NavManager.NavigateTo("/Admin/ServiceRequests", forceLoad: true);
        }
    }
}