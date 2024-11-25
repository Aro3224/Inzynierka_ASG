using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Data.Services
{
    public interface IUserService
    {
        Task<List<UserWithRole>> GetAllUsersAsync();

        Task<List<IdentityRole>> GetAllRolesAsync();

        Task<UserWithRole> Details(string id);

        Task Edit(UserWithRole user, string id);

        Task Delete(string id);

        Task<List<UserWithRole>> FilterUsersAsync(string searchTerm);
    }
}
