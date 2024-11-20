using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly? DateOfBirth { get; set; }

        public string? City { get; set; }

        public string? PostalCode { get; set; }

        public string? Street { get; set; }

        public string? HouseNumber { get; set; }
    }

}
