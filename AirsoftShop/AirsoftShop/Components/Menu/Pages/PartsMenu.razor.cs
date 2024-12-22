using AirsoftShop.Data;
using AirsoftShop.Enums;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Menu.Pages
{
    public partial class PartsMenu
    {
        [Parameter]
        public string PType { get; set; }

        [Parameter]
        public string? DetPType { get; set; }

        private List<Part> AllParts { get; set; } = [];
        private List<Part> Parts { get; set; } = [];

        protected override async Task OnParametersSetAsync()
        {
            var allProducts = await ProductService.GetAllProductsAsync();
            AllParts = allProducts.OfType<Part>().ToList();

            ApplyCategoryFilter();

            var currentUri = new Uri(NavigationManager.Uri);
            SortingState.SetSortingOptionFromUrl(currentUri);

            SortingState.OnSortingChanged += ApplySorting;

            ApplySorting();
        }

        private void ApplyCategoryFilter()
        {
            if (Enum.TryParse<PartType>(PType, true, out var parsedPartType))
            {
                if (parsedPartType == PartType.Internal)
                {
                    if (!string.IsNullOrEmpty(DetPType))
                    {
                        Parts = AllParts
                            .Where(r => r.InternalPartType.ToString().Equals(DetPType, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                    else
                    {
                        Parts = AllParts
                            .Where(r => r.PartType.ToString().Equals(PType, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                }
                else if (parsedPartType == PartType.External)
                {
                    if (!string.IsNullOrEmpty(DetPType))
                    {
                        Parts = AllParts
                            .Where(r => r.ExternalPartType.ToString().Equals(DetPType, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                    else
                    {
                        Parts = AllParts
                            .Where(r => r.PartType.ToString().Equals(PType, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                }
            }
            else
            {
                Console.WriteLine("Could not parse Ptype to enum PartType");
            }
        }

        private void ApplySorting()
        {
            Parts = SortingState.CurrentSortingOption switch
            {
                SortingOption.PriceAsc => Parts.OrderBy(r => r.Price).ToList(),
                SortingOption.PriceDesc => Parts.OrderByDescending(r => r.Price).ToList(),
                SortingOption.NameAsc => Parts.OrderBy(r => r.Name).ToList(),
                SortingOption.NameDesc => Parts.OrderByDescending(r => r.Name).ToList(),
                SortingOption.None => Parts.OrderByDescending(r => r.Id).ToList(),
                _ => Parts
            };

            InvokeAsync(StateHasChanged);
        }

        private async Task HandleFilterChanged(IEnumerable<Product> filteredProducts)
        {
            Parts = filteredProducts.OfType<Part>().ToList();

            ApplySorting();

            await InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SortingState.OnSortingChanged -= ApplySorting;
        }
    }
}