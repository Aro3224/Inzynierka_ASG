using System.ComponentModel.DataAnnotations;
using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ItemEdit
    {
        [Parameter] public string Id { get; set; }
        [Parameter] public string ProdType { get; set; }

        public Product Product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("Initializing product details for edit...");

            int productId = int.Parse(Id);

            if (!Enum.TryParse<ProductType>(ProdType, true, out var productType))
            {
                Console.WriteLine($"Invalid product type: {ProdType}");
                return;
            }

            switch (productType)
            {
                case ProductType.Replica:
                    Product = new Replica();
                    break;
                case ProductType.Part:
                    Product = new Part();
                    break;
                case ProductType.Accessory:
                    Product = new Accessory();
                    break;
                case ProductType.Equipment:
                    Product = new Equipment();
                    break;
                default:
                    Console.WriteLine("Unknown product type.");
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
            NavManager.NavigateTo($"/Admin/ProductDetails/{ProdType}/{Id}");
        }

        private void ParseToBool(object args, Action<bool> setProperty)
        {
            if (string.IsNullOrEmpty(args?.ToString()))
            {
                return;
            }

            if (bool.TryParse(args.ToString(), out var result))
            {
                setProperty(result);
            }
        }

        private void ToggleMaterial(ItemMaterial material, bool isChecked)
        {
            if (Product is Replica replica)
            {
                if (isChecked)
                {
                    replica.ItemMaterial |= material;
                }
                else
                {
  
                    replica.ItemMaterial &= ~material;
                }
            }
        }

        private void ToggleFireType(WeaponFireType fireType, bool isChecked)
        {
            if (Product is Replica replica)
            {
                if (isChecked)
                {
                    replica.WeaponFireType |= fireType;
                }
                else
                {

                    replica.WeaponFireType &= ~fireType;
                }
            }
        }
    }
}
