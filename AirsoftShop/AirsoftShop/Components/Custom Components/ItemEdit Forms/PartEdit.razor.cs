using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components.ItemEdit_Forms
{
    public partial class PartEdit
    {
        [Parameter]
        public Part Part { get; set; } = new();

        private void ToggleMaterial(ItemMaterial material, bool isChecked)
        {
            if (isChecked)
            {
                Part.ItemMaterial |= material;
            }
            else
            {

                Part.ItemMaterial &= ~material;
            }
        }
    }
}