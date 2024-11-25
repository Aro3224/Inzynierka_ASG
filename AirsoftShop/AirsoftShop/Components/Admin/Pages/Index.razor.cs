using AirsoftShop.Data;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class Index
    {
        List<UserWithData> users = [];
        List<UserWithData> PagedUsers => users.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
        private int CurrentPage { get; set; } = 1;
        private int PageSize { get; set; } = 10;

        private bool CanGoToPreviousPage => CurrentPage > 1;
        private bool CanGoToNextPage => CurrentPage < TotalPages;
        private int TotalPages => (int)Math.Ceiling(users.Count / (double)PageSize);

        private bool isAscending = false;

        private string? searchTerm { get; set; }

        private void SortBy(string column)
        {
            switch (column)
            {
                case "Name":
                    {
                        users = isAscending ? users.OrderBy(u => u.Name).ToList() : users.OrderByDescending(u => u.Name).ToList();
                        break;
                    }
                case "Role":
                    {
                        users = isAscending ? users.OrderBy(u => u.Role).ToList() : users.OrderByDescending(u => u.Role).ToList();
                        break;
                    }
                case "Email":
                    {
                        users = isAscending ? users.OrderBy(u => u.Email).ToList() : users.OrderByDescending(u => u.Email).ToList();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There's no such column!");
                        break;
                    }
            }

            isAscending = !isAscending;
            StateHasChanged();
        }

        private void PreviousPage()
        {
            if (CanGoToPreviousPage)
            {
                CurrentPage--;
                StateHasChanged();
            }
        }

        private void NextPage()
        {
            if (CanGoToNextPage)
            {
                CurrentPage++;
                StateHasChanged();
            }
        }

        private void GoToPage()
        {
            switch (CurrentPage)
            {
                case var x when x > 0 && x <= TotalPages:
                    {
                        break;
                    }
                case var x when x <= 0:
                    {
                        CurrentPage = 1;
                        break;
                    }
                case var x when x >= TotalPages:
                    {
                        CurrentPage = TotalPages;
                        break;
                    }
            }
        }

        private async Task Search()
        {
            users = await UserService.FilterUsersAsync(searchTerm);
        }
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);

            Console.WriteLine("Initializing users list...");
            users = await UserService.GetAllUsersAsync();
            users = users.OrderBy(u => u.Name).ToList();
        }
    }
}