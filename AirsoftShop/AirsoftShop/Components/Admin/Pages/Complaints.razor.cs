using AirsoftShop.Services;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class Complaints
    {
        public required List<Data.Complaint> ComplaintList { get; set; }

        private Dictionary<string, string> UserEmails = new();

        protected override async Task OnInitializedAsync()
        {
            ComplaintList = await ComplaintService.GetComplaintsAsync();

            var allUsers = await UserService.GetAllUsersAsync();

            UserEmails = allUsers.ToDictionary(u => u.Id, u => u.Email);
        }
    }
}