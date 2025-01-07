using AirsoftShop.Data;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class OrderManage
    {
        public required List<Order> OrdersList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            OrdersList = await OrderService.GetAllOrdersAsync();
        }

        private void NavigateToDetails(int orderId)
        {
            Navigation.NavigateTo($"/Admin/Orders/{orderId}");
        }
    }
}