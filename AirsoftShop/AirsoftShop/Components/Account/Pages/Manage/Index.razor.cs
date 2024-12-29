using System.ComponentModel.DataAnnotations;
using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Account.Pages.Manage
{
    public partial class Index
    {
        private ApplicationUser user = default!;
        private string? username;
        private string? phoneNumber;

        [CascadingParameter]
        private HttpContext HttpContext { get; set; } = default!;

        [SupplyParameterFromForm]
        private InputModel Input { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            user = await UserAccessor.GetRequiredUserAsync(HttpContext);
            username = await UserManager.GetUserNameAsync(user);
            phoneNumber = await UserManager.GetPhoneNumberAsync(user);

            Input.UserName ??= username;
            Input.Name ??= user.Name;
            Input.Surname ??= user.Surname;
            Input.PhoneNumber ??= phoneNumber;
            Input.City ??= user.City;
            Input.Address ??= user.Address;
            Input.PostalCode ??= user.PostalCode;
        }

        private async Task OnValidSubmitAsync()
        {
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await UserManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    RedirectManager.RedirectToCurrentPageWithStatus("Error: Failed to set phone number.", HttpContext);
                    return;
                }
            }

            if (Input.UserName != username)
            {
                var setUserNameResult = await UserManager.SetUserNameAsync(user, Input.UserName);
                if (!setUserNameResult.Succeeded)
                {
                    RedirectManager.RedirectToCurrentPageWithStatus("Error: Failed to update username.", HttpContext);
                    return;
                }
                username = Input.UserName;
            }

            user.Name = Input.Name;
            user.Surname = Input.Surname;
            user.PhoneNumber = Input.PhoneNumber;
            user.City = Input.City;
            user.Address = Input.Address;
            user.PostalCode = Input.PostalCode;


            var updateResult = await UserManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                RedirectManager.RedirectToCurrentPageWithStatus($"Error: {string.Join(", ", updateResult.Errors.Select(e => e.Description))}", HttpContext);
                return;
            }

            await SignInManager.RefreshSignInAsync(user);

            RedirectManager.RedirectToCurrentPageWithStatus("Zapisano zmiany", HttpContext);
        }

        private sealed class InputModel
        {
            [Required]
            [Display(Name = "Username")]
            public string? UserName { get; set; }

            [Display(Name = "Name")]
            public string? Name { get; set; }

            [Display(Name = "Surname")]
            public string? Surname { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string? PhoneNumber { get; set; }

            [Display(Name = "City")]
            public string? City { get; set; }

            [Display(Name = "Address")]
            public string? Address { get; set; }

            [Display(Name = "Postal Code")]
            public string? PostalCode { get; set; }
        }
    }
}