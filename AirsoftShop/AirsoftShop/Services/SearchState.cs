namespace AirsoftShop.Services
{
    public class SearchState
    {
        public string Query { get; private set; } = string.Empty;

        public event Action? OnSearchChanged;

        public void SetSearchQuery(string query)
        {
            Query = query;
            OnSearchChanged?.Invoke();
        }

        public void SetSearchQueryFromUrl(Uri uri)
        {
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query).Get("query") ?? string.Empty;
            Query = query;
            OnSearchChanged?.Invoke();
        }
    }
}
