using AirsoftShop.Components.Custom_Components;
using AirsoftShop.Data;
using Blazored.Modal.Services;
using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class DetailsUser
    {
        [Parameter]
        public string Id { get; set; }

        public UserWithData User { get; set; }

        [CascadingParameter]
        public IModalService Modal { get; set; } = default!;

        private async void Delete(string Id)
        {
            var parameters = new ModalParameters()
                .Add(nameof(DeleteUser.Id), Id);

            Modal.Show<DeleteUser>("Usuñ u¿ytkownika", parameters);
        }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);

            Console.WriteLine("Wczytywanie danych u¿ytkownika...");
            User = await UserService.Details(Id);
            if (User != null)
            {
                Console.WriteLine($"Wczytano u¿ytkownika z ID: {User.Id}");
            }
            else
            {
                Console.WriteLine("Nie ma u¿ytkownika z podanym ID!");
            }
        }
    }
}