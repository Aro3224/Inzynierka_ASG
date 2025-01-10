using AirsoftShop.Data;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ServiceRequests
    {
        public required List<PostWarranty> RequestsList { get; set; }

        private Dictionary<string, string> UserEmails = new();

        protected override async Task OnInitializedAsync()
        {
            RequestsList = await PostWarrantyService.GetPostWarrantiesAsync();

            var allUsers = await UserService.GetAllUsersAsync();

            UserEmails = allUsers.ToDictionary(u => u.Id, u => u.Email);
        }
    }
}