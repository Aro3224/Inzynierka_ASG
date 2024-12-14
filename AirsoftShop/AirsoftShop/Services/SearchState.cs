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
    }
}
