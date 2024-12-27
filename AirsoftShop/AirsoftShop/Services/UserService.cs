using System.Security.Claims;
using AirsoftShop.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AirsoftShop.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<string> GetCurrentUserIdAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                return user.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return null;
        }

        public async Task Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            _userManager.DeleteAsync(user);
        }

        public async Task<UserWithData> Details(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userRole = await _userManager.GetRolesAsync(user);

            var userWithRole = new UserWithData
            {
                Id = user.Id,
                Name = user.UserName,
                Email = user.Email,
                Role = userRole.FirstOrDefault(),
                IsEmailConfirmed = user.EmailConfirmed,
                PhoneNumber = user.PhoneNumber,
                IsPhoneConfirmed = user.PhoneNumberConfirmed,
                IsTwoFactorEnabled = user.TwoFactorEnabled,
                City = user.City,
                PostalCode = user.PostalCode,
                Address = user.Address
            };

            return userWithRole;
        }

        public async Task Edit(UserWithData user, string id)
        {
            var dbUser = await _userManager.FindByIdAsync(id);
            var dbUserRoles = await _userManager.GetRolesAsync(dbUser);
            var currentRole = dbUserRoles.FirstOrDefault();

            dbUser.UserName = user.Name;
            dbUser.Email = user.Email;
            dbUser.PhoneNumber = user.PhoneNumber;
            dbUser.City = user.City;
            dbUser.PostalCode = user.PostalCode;
            dbUser.Address = user.Address;
            dbUser.EmailConfirmed = user.IsEmailConfirmed;
            dbUser.PhoneNumberConfirmed = user.IsPhoneConfirmed;
            dbUser.TwoFactorEnabled = user.IsTwoFactorEnabled;

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

        public async Task<List<UserWithData>> GetAllUsersAsync()
        {
            var users = _userManager.Users.ToList();
            var userWithRoles = new List<UserWithData>();

            foreach (var user in users)
            {
                var role = await _userManager.GetRolesAsync(user);
                userWithRoles.Add(new UserWithData
                {
                    Id = user.Id,
                    Name = user.UserName,
                    Email = user.Email,
                    Role = role.FirstOrDefault()
                });
            }

            Console.WriteLine($"Liczba wczytanych użytkowników: {userWithRoles.Count}");

            return userWithRoles;
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();

            return roles;
        }

        public async Task<List<UserWithData>> FilterUsersAsync(string searchTerm)
        {
            var result = await GetAllUsersAsync();

            var filteredResult = result.Where(user => user.Email.ToLower().Contains(searchTerm.ToLower())).ToList();

            return filteredResult;
        }
    }
}
