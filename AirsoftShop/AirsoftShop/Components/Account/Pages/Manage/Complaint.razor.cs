using AirsoftShop.Data;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Complaint
    {
        [Parameter]
        public required int OrderId { get; set; }

        public required Order Order { get; set; }

        private bool IsAuthorized { get; set; }

        public required Data.Complaint complaint { get; set; }

        private List<Data.OrderItem> SelectedItems { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity?.IsAuthenticated != true)
            {
                IsAuthorized = false;
                return;
            }

            var currentUser = await UserManager.GetUserAsync(user);
            if (currentUser is null)
            {
                IsAuthorized = false;
                return;
            }

            Order = await OrderService.GetOrderByIdAsync(OrderId);
            if (Order is not null && Order.UserId == currentUser.Id)
            {
                IsAuthorized = true;
            }
            else
            {
                IsAuthorized = false;
                Order = null;
            }

            complaint = new Data.Complaint
            {
                UserId = currentUser.Id,
                ComplaintDescription = ""
            };
        }

        private void ToggleItemSelection(ChangeEventArgs e, Data.OrderItem item)
        {
            bool isChecked = (bool)e.Value;
            if (isChecked)
            {
                if (!SelectedItems.Contains(item))
                    SelectedItems.Add(item);
            }
            else
            {
                SelectedItems.Remove(item);
            }
        }

        private async Task SubmitComplaint()
        {
            if (SelectedItems.Any())
            {
                complaint.OrderId = OrderId;
                complaint.ComplaintStatus = ComplaintStatus.Created;
                complaint.ComplaintType = ComplaintType.Complaint;
                complaint.ComplaintItems = new List<ComplaintItem>();

                complaint.ComplaintItems = SelectedItems.Select(item => new ComplaintItem
                {
                    ProductId = item.ReplicaId ?? item.PartId ?? item.AccessoryId ?? 0,
                    ProductType = item.ReplicaId.HasValue ? ProductType.Replica :
                                  item.PartId.HasValue ? ProductType.Part : ProductType.Accessory,
                    Quantity = item.Quantity,
                    Complaint = complaint
                }).ToList();

                await ComplaintService.CreateComplaintAsync(complaint);

                NavManager.NavigateTo("/Account/Manage/Complaints", forceLoad: true);
            }
        }
    }
}