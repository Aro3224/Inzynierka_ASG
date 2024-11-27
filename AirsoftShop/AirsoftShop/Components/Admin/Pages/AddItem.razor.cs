using AirsoftShop.Data;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class AddItem
    {
        private ProductType selectedProductType;
        private string resultMessage;

        private async Task HandleSave(Product product)
        {
            try
            {
                await ProductService.CreateProductAsync(product);
                NavManager.NavigateTo("/Admin/ItemManage");
            }
            catch (Exception ex)
            {
                resultMessage = $"Wystąpił błąd: {ex.Message}";
            }
        }
    }
}
