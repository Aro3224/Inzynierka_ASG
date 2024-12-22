using AirsoftShop.Data;
using AirsoftShop.Enums;
using AirsoftShop.Services;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Menu.Pages
{
    public partial class ReplicasMenu
    {
        [Parameter]
        public string? Category { get; set; }

        private List<Replica> AllReplicas { get; set; } = [];
        private List<Replica> Replicas { get; set; } = [];

        protected override async Task OnParametersSetAsync()
        {
            var allProducts = await ProductService.GetAllProductsAsync();
            AllReplicas = allProducts.OfType<Replica>().ToList();

            ApplyCategoryFilter();

            var currentUri = new Uri(NavigationManager.Uri);
            SortingState.SetSortingOptionFromUrl(currentUri);

            SortingState.OnSortingChanged += ApplySorting;

            ApplySorting();
        }

        private void ApplyCategoryFilter()
        {
            if (!string.IsNullOrEmpty(Category))
            {
                Replicas = AllReplicas
                    .Where(r => r.WeaponCategory.ToString().Equals(Category, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            else
            {
                Replicas = AllReplicas.ToList();
            }
        }

        private void ApplySorting()
        {
            Replicas = SortingState.CurrentSortingOption switch
            {
                SortingOption.PriceAsc => Replicas.OrderBy(r => r.Price).ToList(),
                SortingOption.PriceDesc => Replicas.OrderByDescending(r => r.Price).ToList(),
                SortingOption.NameAsc => Replicas.OrderBy(r => r.Name).ToList(),
                SortingOption.NameDesc => Replicas.OrderByDescending(r => r.Name).ToList(),
                SortingOption.None => Replicas.OrderByDescending(r => r.Id).ToList(),
                _ => Replicas
            };

            InvokeAsync(StateHasChanged);
        }

        private async Task HandleFilterChanged(IEnumerable<Product> filteredProducts)
        {
            Replicas = filteredProducts.OfType<Replica>().ToList();

            ApplySorting();

            await InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SortingState.OnSortingChanged -= ApplySorting;
        }
    }
}