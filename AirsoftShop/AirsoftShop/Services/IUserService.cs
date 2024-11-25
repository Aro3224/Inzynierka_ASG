using AirsoftShop.Data;
using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Services
{
    public interface IUserService
    {
        Task<List<UserWithData>> GetAllUsersAsync();

        Task<List<IdentityRole>> GetAllRolesAsync();

        Task<UserWithData> Details(string id);

        Task Edit(UserWithData user, string id);

        Task Delete(string id);

        Task<List<UserWithData>> FilterUsersAsync(string searchTerm);
    }
}
