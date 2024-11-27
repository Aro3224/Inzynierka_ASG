using System.ComponentModel.DataAnnotations;
using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class ReplicaForm
    {
        private Replica Replica = new();

        [Parameter]
        public EventCallback<Product> OnSave { get; set; }

        private void ToggleFireType(WeaponFireType fireType, bool isChecked)
        {
            if (isChecked)
            {
                Replica.WeaponFireType |= fireType;
            }
            else
            {
                Replica.WeaponFireType &= ~fireType;
            }
        }

        private void ToggleMaterial(ItemMaterial itemMaterial, bool isChecked)
        {
            if (isChecked)
            {
                Replica.ItemMaterial |= itemMaterial;
            }
            else
            {
                Replica.ItemMaterial &= ~itemMaterial;
            }
        }

        private async Task HandleValidSubmit()
        {
            await OnSave.InvokeAsync(Replica);
        }
    }
}