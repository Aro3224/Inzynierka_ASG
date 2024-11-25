using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class DeleteUser
    {
        [Parameter]
        public string Id { get; set; }

        [CascadingParameter]
        BlazoredModalInstance BlazoredModal { get; set; } = default!;

        private async Task Close() => await BlazoredModal.CloseAsync();

        private async void Delete()
        {
            await Task.Delay(200);

            await UserService.Delete(Id);

            NavManager.NavigateTo("/Admin/Manage");
        }
    }
}