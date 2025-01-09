using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IComplaintService
    {
        Task CreateComplaintAsync(Complaint complaint);
        Task AddComplaintItemAsync(int complaintId, ComplaintItem item);
        Task<List<Complaint>> GetComplaintsAsync();
        Task<List<Complaint>> GetComplaintsByUserIdAsync(string userId);
        Task<Complaint> GetComplaintByIdAsync(int complaintId);
        Task UpdateComplaintAsync(Complaint complaint);
        Task RemoveComplaintAsync(int complaintId);
        Task<bool> IsProductReturnableAsync(int orderItemId);
    }
}
