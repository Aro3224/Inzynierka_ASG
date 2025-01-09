using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components
{
    public partial class GoToPrevPage
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
            if (Id == null && ProductType == "")
            {
                NavManager.NavigateTo($"/{Page}", forceLoad: true);
            }
            else if (ProductType == "")
            {
                NavManager.NavigateTo($"/{Page}/{Id}", forceLoad: true);
            }
            else if (ProductType != "" && Id != null)
            {
                NavManager.NavigateTo($"/{Page}/{ProductType}/{Id}", forceLoad: true);
            }
        }
    }
}