using AirsoftShop.Data;

namespace AirsoftShop.Components.Admin.Pages
{
    public partial class ServiceRequests
    {
        public required List<PostWarranty> RequestsList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RequestsList = await PostWarrantyService.GetPostWarrantiesAsync();
        }
    }
}