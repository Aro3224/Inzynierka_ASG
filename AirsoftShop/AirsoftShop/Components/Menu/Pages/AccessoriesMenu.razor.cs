using AirsoftShop.Data;
using AirsoftShop.Enums;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Menu.Pages
{
    public partial class AccessoriesMenu
    {
        [Parameter]
        public string? AccType { get; set; }

        private List<Accessory> AllAccessories { get; set; } = [];
        private List<Accessory> Accessories { get; set; } = [];

        protected override async Task OnParametersSetAsync()
        {
            var allProducts = await ProductService.GetAllProductsAsync();
            AllAccessories = allProducts.OfType<Accessory>().ToList();

            ApplyCategoryFilter();

            var currentUri = new Uri(NavigationManager.Uri);
            SortingState.SetSortingOptionFromUrl(currentUri);

            SortingState.OnSortingChanged += ApplySorting;

            ApplySorting();
        }

        private void ApplyCategoryFilter()
        {
            if (!string.IsNullOrEmpty(AccType))
            {
                Accessories = AllAccessories
                    .Where(r => r.AccessoryType.ToString().Equals(AccType, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            else
            {
                Accessories = AllAccessories.ToList();
            }
        }

        private void ApplySorting()
        {
            Accessories = SortingState.CurrentSortingOption switch
            {
                SortingOption.PriceAsc => Accessories.OrderBy(r => r.Price).ToList(),
                SortingOption.PriceDesc => Accessories.OrderByDescending(r => r.Price).ToList(),
                SortingOption.NameAsc => Accessories.OrderBy(r => r.Name).ToList(),
                SortingOption.NameDesc => Accessories.OrderByDescending(r => r.Name).ToList(),
                SortingOption.None => Accessories.OrderByDescending(r => r.Id).ToList(),
                _ => Accessories
            };

            InvokeAsync(StateHasChanged);
        }

        private async Task HandleFilterChanged(IEnumerable<Product> filteredProducts)
        {
            Accessories = filteredProducts.OfType<Accessory>().ToList();

            ApplySorting();

            await InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SortingState.OnSortingChanged -= ApplySorting;
        }
    }
}