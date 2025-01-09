namespace AirsoftShop.Components.Admin.Pages
{
    public partial class Complaints
    {
        public required List<Data.Complaint> ComplaintList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ComplaintList = await ComplaintService.GetComplaintsAsync();
        }
    }
}