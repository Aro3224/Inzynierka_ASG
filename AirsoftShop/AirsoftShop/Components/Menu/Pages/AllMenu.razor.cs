using AirsoftShop.Data;
using AirsoftShop.Enums;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Menu.Pages
{
    public partial class AllMenu
    {
        private List<Product> AllProducts { get; set; } = [];
        private List<Product>? FilteredProducts { get; set; } = null;

        protected override async Task OnInitializedAsync()
        {
            AllProducts = await ProductService.GetAllProductsAsync();

            var currentUri = new Uri(NavigationManager.Uri);
            SearchState.SetSearchQueryFromUrl(currentUri);
            SortingState.SetSortingOptionFromUrl(currentUri);

            SortingState.OnSortingChanged += ApplySorting;

            ApplySearchFilter();
            ApplySorting();

            SearchState.OnSearchChanged += ApplySearchFilter;
        }

        private void ApplySearchFilter()
        {
            var query = SearchState.Query;

            if (string.IsNullOrWhiteSpace(query))
            {
                FilteredProducts = null;
            }
            else
            {
                FilteredProducts = AllProducts
                    .Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            InvokeAsync(StateHasChanged);
        }

        private void ApplySorting()
        {
            FilteredProducts = SortingState.CurrentSortingOption switch
            {
                SortingOption.PriceAsc => FilteredProducts.OrderBy(r => r.Price).ToList(),
                SortingOption.PriceDesc => FilteredProducts.OrderByDescending(r => r.Price).ToList(),
                SortingOption.NameAsc => FilteredProducts.OrderBy(r => r.Name).ToList(),
                SortingOption.NameDesc => FilteredProducts.OrderByDescending(r => r.Name).ToList(),
                SortingOption.None => FilteredProducts.OrderByDescending(r => r.Id).ToList(),
                _ => FilteredProducts
            };

            InvokeAsync(StateHasChanged);
        }

        private async Task HandleFilterChanged(IEnumerable<Product> filteredProducts)
        {
            FilteredProducts = filteredProducts.OfType<Product>().ToList();

            ApplySorting();

            await InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SearchState.OnSearchChanged -= ApplySearchFilter;
            SortingState.OnSortingChanged -= ApplySorting;
        }
    }
}