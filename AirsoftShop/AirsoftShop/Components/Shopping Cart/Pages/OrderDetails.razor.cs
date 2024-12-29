using System.ComponentModel.DataAnnotations;
using AirsoftShop.Data;
using AirsoftShop.Services;

namespace AirsoftShop.Components.Shopping_Cart.Pages
{
    public partial class OrderDetails
    {
        private OrderDraft order = new OrderDraft();

        protected override async Task OnInitializedAsync()
        {
            var userId = await UserService.GetCurrentUserIdAsync();

            order = OrderDraftService.CurrentOrderDraft;

            if (!string.IsNullOrEmpty(userId))
            {
                var userDetails = await UserService.Details(userId);

                order.CustomerName = userDetails.Name;
                order.CustomerSurname = userDetails.Surname;
                order.PhoneNumber = userDetails.PhoneNumber;
                order.City = userDetails.City;
                order.PostalCode = userDetails.PostalCode;
                order.Address = userDetails.Address;
            }
        }

        private async Task HandleValidSubmit()
        {
            OrderDraftService.UpdateCustomerDetails(
            order.CustomerName,
            order.CustomerSurname,
            order.PhoneNumber,
            order.City,
            order.PostalCode,
            order.Address
            );

            Navigation.NavigateTo("/Cart/Shipping-Payment");
        }
    }
}
