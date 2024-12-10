using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components.ItemEdit_Forms
{
    public partial class AccessoryEdit
    {
        [Parameter]
        public Accessory Accessory { get; set; } = new();
    }
}