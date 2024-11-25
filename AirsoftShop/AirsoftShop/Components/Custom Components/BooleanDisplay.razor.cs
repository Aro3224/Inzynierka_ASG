using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class BooleanDisplay
    {
        [Parameter]
        public bool Bool { get; set; }
    }
}