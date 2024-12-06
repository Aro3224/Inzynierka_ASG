using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<int> TotalProductsAsync();

        Task<Product> GetProductDetailsAsync(int productId, ProductType productType);

        Task CreateProductAsync(Product product);

        Task EditProductAsync(Product product, string id);

        Task DeleteProductAsync(string id);

        Task<List<Product>> FilterProductsAsync(string searchTerm);
    }
}
