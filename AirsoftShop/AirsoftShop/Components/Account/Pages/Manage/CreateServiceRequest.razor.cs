using AirsoftShop.Data;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class CreateServiceRequest
    {
        private PostWarranty Warranty = new()
        {
            UserId = null,
            WeaponName = null,
            DamageDescription = null
        };

        private async Task HandleValidSubmit()
        {
            var userId = await UserService.GetCurrentUserIdAsync();

            Warranty.UserId = userId;
            Warranty.ServiceStatus = ServiceStatus.Created;

            await PostWarrantyService.CreatePostWarrantyAsync(Warranty);

            NavigationManager.NavigateTo("/Account/Manage/Repairs");
        }
    }
}