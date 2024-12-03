using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class AccessoryForm
    {
        [Parameter]
        public Accessory Accessory { get; set; } = new Accessory();

        [Parameter]
        public EventCallback<Product> OnSave { get; set; }

        private async Task HandleValidSubmit()
        {
            await OnSave.InvokeAsync(Accessory);
        }
    }
}