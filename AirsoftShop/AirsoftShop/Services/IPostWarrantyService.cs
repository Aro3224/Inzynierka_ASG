using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IPostWarrantyService
    {
        Task CreatePostWarrantyAsync(PostWarranty postWarranty);
        Task<List<PostWarranty>> GetPostWarrantiesAsync();
        Task<List<PostWarranty>> GetPostWarrantiesByUserIdAsync(string userId);
        Task<PostWarranty> GetPostWarrantyByIdAsync(int requestId);
        Task UpdatePostWarrantyAsync(PostWarranty postWarranty);
        Task RemovePostWarrantyAsync(int requestId);
    }
}
