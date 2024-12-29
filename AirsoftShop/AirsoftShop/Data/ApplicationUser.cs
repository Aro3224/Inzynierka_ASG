using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? City { get; set; }

        public string? PostalCode { get; set; }

        public string? Address { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }
    }

}
