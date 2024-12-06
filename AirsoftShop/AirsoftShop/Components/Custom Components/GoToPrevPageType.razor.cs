using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class GoToPrevPageType
    {
        [Parameter]
        public string Text { get; set; } = "";

        [Parameter]
        public string Page { get; set; } = "";

        [Parameter]
        public string ProductType { get; set; } = "";

        [Parameter]
        public string Id { get; set; }

        private void PreviousPage()
        {
            NavManager.NavigateTo($"/{Page}/{ProductType}/{Id}");
        }
    }
}
