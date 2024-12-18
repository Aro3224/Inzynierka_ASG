using AirsoftShop.Enums;

namespace AirsoftShop.Services
{
    public class SortingState
    {
        public SortingOption CurrentSortingOption { get; private set; } = SortingOption.None;

        public event Action? OnSortingChanged;

        public void SetSortingOption(SortingOption sortingOption)
        {
            CurrentSortingOption = sortingOption;
            OnSortingChanged?.Invoke();
        }

        public void SetSortingOptionFromUrl(Uri uri)
        {
            var sorting = System.Web.HttpUtility.ParseQueryString(uri.Query).Get("sortBy") ?? string.Empty;

            if (Enum.TryParse(sorting, true, out SortingOption parsedOption))
            {
                CurrentSortingOption = parsedOption;
            }
            else
            {
                CurrentSortingOption = SortingOption.None;
            }

            OnSortingChanged?.Invoke();
        }
    }
}
