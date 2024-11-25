using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AirsoftShop.Data.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            _userManager.DeleteAsync(user);
        }

        public async Task<UserWithRole> Details(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userRole = await _userManager.GetRolesAsync(user);

            var userWithRole = new UserWithRole
            {
                Id = user.Id,
                Name = user.UserName,
                Email = user.Email,
                Role = userRole.FirstOrDefault()
            };

            return userWithRole;
        }

        public async Task Edit(UserWithRole user, string id)
        {
            var dbUser = await _userManager.FindByIdAsync(id);
            var dbUserRoles = await _userManager.GetRolesAsync(dbUser);
            var currentRole = dbUserRoles.FirstOrDefault();

            dbUser.UserName = user.Name;
            dbUser.Email = user.Email;

            await _userManager.UpdateAsync(dbUser);

            if (currentRole != user.Role)
            {
                if (currentRole != null)
                {
                    await _userManager.RemoveFromRoleAsync(dbUser, currentRole);
                }

                await _userManager.AddToRoleAsync(dbUser, user.Role);
            }
        }

        public async Task<List<UserWithRole>> GetAllUsersAsync()
        {
            var users = _userManager.Users.ToList();
            var userWithRoles = new List<UserWithRole>();

            foreach (var user in users)
            {
                var role = await _userManager.GetRolesAsync(user);
                userWithRoles.Add(new UserWithRole
                {
                    Id = user.Id,
                    Name = user.UserName,
                    Email = user.Email,
                    Role = role.FirstOrDefault()
                });
            }

            Console.WriteLine($"Users loaded: {userWithRoles.Count}");

            return userWithRoles;
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();

            return roles;
        }

        public async Task<List<UserWithRole>> FilterUsersAsync(string searchTerm)
        {
            var result = await GetAllUsersAsync();

            var filteredResult = result.Where(user => user.Name.ToLower().Contains(searchTerm.ToLower())).ToList();

            return filteredResult;
        }
    }
}
