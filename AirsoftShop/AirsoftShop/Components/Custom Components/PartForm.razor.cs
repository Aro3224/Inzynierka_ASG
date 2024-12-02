using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class PartForm
    {
        [Parameter]
        public Part Part { get; set; } = new Part();

        [Parameter]
        public EventCallback<Product> OnSave { get; set; }

        private void ToggleMaterial(ItemMaterial itemMaterial, bool isChecked)
        {
            if (isChecked)
            {
                Part.ItemMaterial |= itemMaterial;
            }
            else
            {
                Part.ItemMaterial &= ~itemMaterial;
            }
        }

        private async Task HandleValidSubmit()
        {
            await OnSave.InvokeAsync(Part);
        }
    }
}
