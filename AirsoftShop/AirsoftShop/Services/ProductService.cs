using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateProductAsync(Product product)
        {
            switch (product.ProductType)
            {
                case ProductType.Replica:
                    var replica = (Replica)product;
                    _context.Add(replica);
                    break;
                case ProductType.Part:
                    var part = (Part)product;
                    _context.Add(part);
                    break;
                case ProductType.Accessory:
                    var accessory = (Accessory)product;
                    _context.Add(accessory);
                    break;
                case ProductType.Equipment:
                    var equipment = (Equipment)product;
                    _context.Add(equipment);
                    break;
                default:
                    throw new ArgumentException("Nieobsługiwany typ produktu.");
            }

            await _context.SaveChangesAsync();
        }

        public Task DeleteProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task EditProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> FilterProductsAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetProductDetailsAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<int> TotalProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
