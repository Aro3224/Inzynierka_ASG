using AirsoftShop.Data;
using AirsoftShop.Services;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ItemManage
    {
        List<Product> products = [];
        List<Product> PagedProducts => products.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
        private int CurrentPage { get; set; } = 1;
        private int PageSize { get; set; } = 10;

        private bool CanGoToPreviousPage => CurrentPage > 1;
        private bool CanGoToNextPage => CurrentPage < TotalPages;
        private int TotalPages => (int)Math.Ceiling(products.Count / (double)PageSize);

        private bool isAscending = false;

        private string? searchTerm { get; set; }

        private void SortBy(string column)
        {
            switch (column)
            {
                case "Name":
                    {
                        products = isAscending ? products.OrderBy(p => p.Name).ToList() : products.OrderByDescending(p => p.Name).ToList();
                        break;
                    }
                case "Count":
                    {
                        products = isAscending ? products.OrderBy(p => p.Count).ToList() : products.OrderByDescending(p => p.Count).ToList();
                        break;
                    }
                case "Price":
                    {
                        products = isAscending ? products.OrderBy(p => p.Price).ToList() : products.OrderByDescending(p => p.Price).ToList();
                        break;
                    }
                case "ProductId":
                    {
                        products = isAscending ? products.OrderBy(p => p.ProductId).ToList() : products.OrderByDescending(p => p.ProductId).ToList();
                        break;
                    }
                case "ProductType":
                    {
                        products = isAscending ? products.OrderBy(p => p.ProductType).ToList() : products.OrderByDescending(p => p.ProductType).ToList();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There's no such column!");
                        break;
                    }
            }

            isAscending = !isAscending;
            StateHasChanged();
        }

        private void PreviousPage()
        {
            if (CanGoToPreviousPage)
            {
                CurrentPage--;
                StateHasChanged();
            }
        }

        private void NextPage()
        {
            if (CanGoToNextPage)
            {
                CurrentPage++;
                StateHasChanged();
            }
        }

        private void GoToPage()
        {
            switch (CurrentPage)
            {
                case var x when x > 0 && x <= TotalPages:
                    {
                        break;
                    }
                case var x when x <= 0:
                    {
                        CurrentPage = 1;
                        break;
                    }
                case var x when x >= TotalPages:
                    {
                        CurrentPage = TotalPages;
                        break;
                    }
            }
        }

        private async Task Search()
        {
            products = await ProductService.FilterProductsAsync(searchTerm);
        }
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);

            Console.WriteLine("Initializing products list...");
            products = await ProductService.GetAllProductsAsync();
            products = products.OrderBy(p => p.Name).ToList();
        }
    }
}
