using AirsoftShop.Data;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ItemDetails
    {
        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string ProductType { get; set; }

        public Product Product { get; set; }

        [CascadingParameter]
        public IModalService Modal { get; set; } = default!;

        private async void Delete(string Id)
        {
            //var parameters = new ModalParameters()
            //    .Add(nameof(DeleteProduct.Id), Id);

            //Modal.Show<DeleteProduct>("Usuñ przedmiot", parameters);
        }

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