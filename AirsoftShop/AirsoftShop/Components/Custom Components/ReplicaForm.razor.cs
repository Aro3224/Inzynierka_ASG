using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class ReplicaForm
    {
        private Replica Replica = new();

        [Parameter]
        public EventCallback<Product> OnSave { get; set; }

        private async Task HandleValidSubmit()
        {
            await OnSave.InvokeAsync(Replica);
        }
    }
}