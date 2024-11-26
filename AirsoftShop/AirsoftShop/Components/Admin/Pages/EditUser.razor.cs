using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class EditUser
    {
        [Parameter]
        public string Id { get; set; }

        public UserWithData User { get; set; } = new();

        public List<IdentityRole> roles = [];

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("Initializing user details...");
            User = await UserService.Details(Id);
            if (User != null)
            {
                Console.WriteLine($"Initialized user with id: {User.Id}");
            }
            else
            {
                Console.WriteLine("There's no user with given Id!");
            }

            Console.WriteLine("Initializing roles list...");
            roles = await UserService.GetAllRolesAsync();
            if (roles != null)
            {
                Console.WriteLine($"Initialized roles list");
            }
            else
            {
                Console.WriteLine("Role list is empty!");
            }
        }

        private async Task HandleSubmit()
        {
            await UserService.Edit(User, Id);
            NavManager.NavigateTo($"/Admin/UserDetails/{Id}");
        }
    }
}