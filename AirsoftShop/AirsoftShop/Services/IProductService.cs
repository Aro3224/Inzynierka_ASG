using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IProductService
    {
        Task<List<T>> GetAllProductsAsync<T>() where T : Product;

        Task<int> TotalProductsAsync();

        Task<T> GetProductDetailsAsync<T>(string id) where T : Product;

        Task CreateProductAsync<T>(T product) where T : Product;

        Task EditProductAsync<T>(T product) where T : Product;

        Task DeleteProductAsync(string id);

        Task<List<T>> FilterProductsAsync<T>(string searchTerm) where T : Product;
    }
}
