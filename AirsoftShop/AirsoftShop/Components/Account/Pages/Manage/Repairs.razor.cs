using AirsoftShop.Data;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Repairs
    {
        public required List<PostWarranty> RequestsList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var userID = await UserService.GetCurrentUserIdAsync();

            RequestsList = await PostWarrantyService.GetPostWarrantiesByUserIdAsync(userID);
        }
    }
}