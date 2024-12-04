using AirsoftShop.Data;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class AddItem
    {
        private ProductType selectedProductType;
        private string resultMessage;

        private Part Part = new();

        private Accessory Accessory { get; set; } = new Accessory();

        private ProductType SelectedProductType
        {
            get => selectedProductType;
            set
            {
                if (selectedProductType != value)
                {
                    selectedProductType = value;
                    ResetFormState();
                }
            }
        }

        private PartType? partType
        {
            get => Part.PartType;
            set
            {
                Part = new Part();

                Part.PartType = value;
            }
        }

        private AccessoryType? AccessoryType
        {
            get => Accessory.AccessoryType;
            set
            {
                Accessory = new Accessory();

                Accessory.AccessoryType = value;
            }
        }

        private InternalPartType? InternalPartType
        {
            get => Part.InternalPartType;
            set
            {
                Part = new Part();

                Part.PartType = PartType.Internal;

                Part.InternalPartType = value;
            }
        }

        private ExternalPartType? ExternalPartType
        {
            get => Part.ExternalPartType;
            set
            {
                Part = new Part();

                Part.PartType = PartType.External;

                Part.ExternalPartType = value;
            }
        }

        private void ResetFormState()
        {
            Part = new Part();
            Accessory = new Accessory();
        }

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
