using AirsoftShop.Data;

namespace AirsoftShop.Services
{
    public interface IComplaintService
    {
        Task CreateComplaintAsync(Complaint complaint);
        Task AddComplaintItemAsync(int complaintId, ComplaintItem item);
        Task<List<Complaint>> GetComplaintsByUserIdAsync(string userId);
        Task<Complaint> GetComplaintByIdAsync(int complaintId);
        Task UpdateComplaintStatusAsync(int complaintId, ComplaintStatus newStatus);
        Task<bool> IsProductReturnableAsync(int orderItemId);
    }
}
