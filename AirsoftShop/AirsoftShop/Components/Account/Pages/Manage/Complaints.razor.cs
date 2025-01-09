using AirsoftShop.Data;
using AirsoftShop.Services;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Complaints
    {
        public required List<Data.Complaint> ComplaintList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var userID = await UserService.GetCurrentUserIdAsync();

            ComplaintList = await ComplaintService.GetComplaintsByUserIdAsync(userID);
        }
    }
}