using AirsoftShop.Data;
using Microsoft.EntityFrameworkCore;

namespace AirsoftShop.Services
{
    public class ComplaintService : IComplaintService
    {
        private readonly ApplicationDbContext _context;

        public ComplaintService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddComplaintItemAsync(int complaintId, ComplaintItem item)
        {
            var complaint = await _context.Complaints.Include(c => c.ComplaintItems)
                     .FirstOrDefaultAsync(c => c.Id == complaintId);

            if (complaint == null)
                throw new KeyNotFoundException("Nie znaleziono zgłoszenia.");

            complaint.ComplaintItems.Add(item);
            await _context.SaveChangesAsync();
            Console.WriteLine("Dodano przedmiot do zgłoszenia.");
        }

        public async Task CreateComplaintAsync(Complaint complaint)
        {
            _context.Complaints.Add(complaint);
            await _context.SaveChangesAsync();
            Console.WriteLine("Utworzono zgłoszenie.");
        }

        public async Task<Complaint> GetComplaintByIdAsync(int complaintId)
        {
            return await _context.Complaints
                 .Include(c => c.ComplaintItems)
                 .FirstOrDefaultAsync(c => c.Id == complaintId)
           ?? throw new KeyNotFoundException("Nie znaleziono zgłoszenia.");
        }

        public async Task<List<Complaint>> GetComplaintsAsync()
        {
            return await _context.Complaints
                 .Include(c => c.ComplaintItems)
                 .ToListAsync();
        }

        public async Task<List<Complaint>> GetComplaintsByUserIdAsync(string userId)
        {
            return await _context.Complaints
                 .Where(c => c.UserId == userId)
                 .Include(c => c.ComplaintItems)
                 .ToListAsync();
        }

        public async Task<bool> IsProductReturnableAsync(int orderItemId)
        {
            var orderItem = await _context.OrderItems
                      .Include(oi => oi.Order)
                      .FirstOrDefaultAsync(oi => oi.Id == orderItemId);

            if (orderItem == null)
                return false;

            var daysSinceOrder = (DateTime.Now - orderItem.Order.OrderDate).TotalDays;
            return daysSinceOrder <= 14;
        }

        public async Task RemoveComplaintAsync(int complaintId)
        {
            var complaint = await _context.Complaints.FindAsync(complaintId);
            if (complaint != null)
            {
                _context.Complaints.Remove(complaint);
                await _context.SaveChangesAsync();
                Console.WriteLine("Usunięto zgłoszenie.");
            }
        }

        public async Task UpdateComplaintAsync(Complaint complaint)
        {
            complaint.UpdatedAt = DateTime.Now;

            Console.WriteLine("Zapisano zmiany w bazie");

             _context.Complaints.Update(complaint);
            await _context.SaveChangesAsync();
        }
    }
}
