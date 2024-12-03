using AirsoftShop.Data;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Product>> FilterProductsAsync(string searchTerm)
        {
            var result = await GetAllProductsAsync();

            var filteredResult = result.Where(product => product.Name.ToLower().Contains(searchTerm.ToLower())).ToList();

            return filteredResult;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var replicas = await _context.Replicas.ToListAsync();
            var parts = await _context.Parts.ToListAsync();
            var accessories = await _context.Accessories.ToListAsync();

            var allProducts = replicas.Cast<Product>()
                .Concat(parts.Cast<Product>())
                .Concat(accessories.Cast<Product>())
                .ToList();

            return allProducts;
        }

        public async Task<Product> GetProductDetailsAsync(int productId, ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Replica:
                    return await _context.Replicas
                        .FirstOrDefaultAsync(r => r.Id == productId);

                case ProductType.Part:
                    return await _context.Parts
                        .FirstOrDefaultAsync(p => p.Id == productId);

                case ProductType.Accessory:
                    return await _context.Accessories
                        .FirstOrDefaultAsync(a => a.Id == productId);

                //case ProductType.Equipment:
                //    return await _context.Equipment
                //        .FirstOrDefaultAsync(e => e.Id == productId);

                default:
                    return null;
            }
        }

        public Task<int> TotalProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
