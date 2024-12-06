using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class DeleteItem
    {
        [Parameter] public string Id { get; set; }
        [Parameter] public string ProdType { get; set; }

        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; } = default!;

        private async Task Close() => await BlazoredModal.CloseAsync();

        private async void Delete()
        {
            await Task.Delay(200);

            await ProductService.DeleteProductAsync(Id, ProdType);

            NavManager.NavigateTo("/Admin/ItemManage");
        }
    }
}
