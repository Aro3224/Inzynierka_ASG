using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ItemEdit
    {
        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string ProductType { get; set; }

        public Product Product { get; set; }

        public List<IdentityRole> roles = [];

        protected override async Task OnInitializedAsync()
        {
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

        private async Task HandleSubmit()
        {
            await ProductService.EditProductAsync(Product, Id);
            NavManager.NavigateTo($"/Admin/ProductDetails/{ProductType}/{Id}");
        }
    }
}
