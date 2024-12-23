using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Menu.Pages
{
    public partial class ProductDetails
    {
        [Parameter]
        public required string ProductType { get; set; }

        [Parameter]
        public required string Id { get; set; }

        public required Product Product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);

            Console.WriteLine("Initializing product details...");

            int productId = int.Parse(Id);

            if (!Enum.TryParse<ProductType>(ProductType, true, out var productType))
            {
                Console.WriteLine($"Invalid product type: {ProductType}");
                return;
            }

            Product = await ProductService.GetProductDetailsAsync(productId, productType);
            if (Product != null)
            {
                Console.WriteLine($"Initialized product with id: {Product.Id}");
            }
            else
            {
                Console.WriteLine("There's no product with given Id!");
            }
        }
    }
}