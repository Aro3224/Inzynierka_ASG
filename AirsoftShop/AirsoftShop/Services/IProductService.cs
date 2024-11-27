using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<int> TotalProductsAsync();

        Task GetProductDetailsAsync(string id);

        Task CreateProductAsync(Product product);

        Task EditProductAsync(Product product);

        Task DeleteProductAsync(string id);

        Task<List<Product>> FilterProductsAsync(string searchTerm);
    }
}
