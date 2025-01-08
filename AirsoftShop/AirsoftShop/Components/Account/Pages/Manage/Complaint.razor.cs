using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Complaint
    {
        [Parameter]
        public required int OrderId { get; set; }
    }
}