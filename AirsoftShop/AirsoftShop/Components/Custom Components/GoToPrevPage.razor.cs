using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class GoToPrevPage
    {
        [Parameter]
        public string Text { get; set; } = "";

        [Parameter]
        public string Page { get; set; } = "";

        private void PreviousPage()
        {
            NavManager.NavigateTo($"/{Page}");
        }
    }
}