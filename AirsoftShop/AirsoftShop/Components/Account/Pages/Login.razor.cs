using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Components.Account.Pages
{
    public partial class Login
    {
        private string? errorMessage;

        [CascadingParameter]
        private HttpContext HttpContext { get; set; } = default!;

        [SupplyParameterFromForm]
        private InputModel Input { get; set; } = new();

        [SupplyParameterFromQuery]
        private string? ReturnUrl { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (HttpMethods.IsGet(HttpContext.Request.Method))
            {
                // Clear the existing external cookie to ensure a clean login process
                await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            }
        }

        public async Task LoginUser()
        {
            var user = await UserManager.FindByEmailAsync(Input.Email);

            if (user == null)
            {
                user = await UserManager.FindByNameAsync(Input.Email);
            }

            if (user == null)
            {
                errorMessage = "Nieprawid³owy login lub has³o.";
                return;
            }

            var result = await SignInManager.PasswordSignInAsync(user, Input.Password, Input.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                Logger.LogInformation("U¿ytkownik zalogowa³ siê.");
                RedirectManager.RedirectTo(ReturnUrl);
            }
            else if (result.RequiresTwoFactor)
            {
                RedirectManager.RedirectTo(
                    "Account/LoginWith2fa",
                    new() { ["returnUrl"] = ReturnUrl, ["rememberMe"] = Input.RememberMe });
            }
            else if (result.IsLockedOut)
            {
                Logger.LogWarning("Konto u¿ytkownika zosta³o zablokowane.");
                RedirectManager.RedirectTo("Account/Lockout");
            }
            else
            {
                errorMessage = "Nieprawid³owy login lub has³o.";
            }
        }

        private sealed class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; } = "";

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; } = "";

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }
    }
}