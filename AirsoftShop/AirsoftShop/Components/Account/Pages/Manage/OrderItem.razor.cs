using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class OrderItem
    {
        [Parameter]
        public required Order Order { get; set; }

        public void NavigateToDetails(int OrderId)
        {
            Navigation.NavigateTo($"/Account/Manage/Orders/{OrderId}");
        }
    }
}