using AirsoftShop.Data;
using AirsoftShop.Services;

namespace AirsoftShop.Components.Shopping_Cart.Pages
{
    public partial class ShippingPayment
    {
        private OrderDraft order = new OrderDraft();

        protected override void OnInitialized()
        {
            order = OrderDraftService.CurrentOrderDraft;
        }

        private async Task HandleValidSubmit()
        {
            OrderDraftService.UpdatePaymentDetails(
            order.PaymentMethod,
            order.CourierCompany,
            order.CustomerComment
        );

            Navigation.NavigateTo("/Cart/Summary");
        }
    }
}