using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Pages
{
    public partial class ProductDetails
    {
        [Parameter]
        public required string ProductType { get; set; }

        [Parameter]
        public required string Id { get; set; }

        public required Product Product { get; set; }

        private List<string> excludedProperties;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(200);

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
                excludedProperties = GetExcludedProperties(Product);
            }
            else
            {
                Console.WriteLine("There's no product with given Id!");
            }
        }

        private List<string> GetExcludedProperties(Product product)
        {
            var excluded = new List<string>
            {
            nameof(Product.Id),
            nameof(Product.Name),
            nameof(Product.Price),
            nameof(Product.Count),
            nameof(Product.Description),
            nameof(Product.ProductType)
            };

            if (product is Accessory)
            {
                excluded.Add(nameof(Accessory.AccessoryType));
            }
            else if (product is Part)
            {
                excluded.Add(nameof(Part.PartType));
                excluded.Add(nameof(Part.InternalPartType));
                excluded.Add(nameof(Part.ExternalPartType));
            }

            return excluded;
        }
    }
}