using AirsoftShop.Components.Account.Pages.Manage;
using AirsoftShop.Data;
using Microsoft.EntityFrameworkCore;

namespace AirsoftShop.Services
{
    public class PostWarrantyService : IPostWarrantyService
    {
        private readonly ApplicationDbContext _context;

        public PostWarrantyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreatePostWarrantyAsync(PostWarranty postWarranty)
        {
            _context.PostWarranties.Add(postWarranty);
            await _context.SaveChangesAsync();
            Console.WriteLine("Utworzono zgłoszenie serwisowe.");
        }

        public async Task<List<PostWarranty>> GetPostWarrantiesAsync()
        {
            Console.WriteLine("Pobrano zgłoszenia serwisowe.");
            return await _context.PostWarranties.ToListAsync();
        }

        public async Task<List<PostWarranty>> GetPostWarrantiesByUserIdAsync(string userId)
        {
            Console.WriteLine("Pobrano zgłoszenia serwisowe po ID użytkownika.");
            return await _context.PostWarranties
                 .Where(c => c.UserId == userId)
                 .ToListAsync();
        }

        public async Task<PostWarranty> GetPostWarrantyByIdAsync(int requestId)
        {
            return await _context.PostWarranties
                 .FirstOrDefaultAsync(c => c.Id == requestId)
           ?? throw new KeyNotFoundException("Nie znaleziono zgłoszenia serwisowego.");
        }

        public async Task RemovePostWarrantyAsync(int requestId)
        {
            var request = await _context.PostWarranties.FindAsync(requestId);
            if (request != null)
            {
                _context.PostWarranties.Remove(request);
                await _context.SaveChangesAsync();
                Console.WriteLine("Usunięto zgłoszenie serwisowe.");
            }
        }

        public async Task UpdatePostWarrantyAsync(PostWarranty postWarranty)
        {
            postWarranty.UpdatedAt = DateTime.Now;
            Console.WriteLine("Zapisano zmiany w bazie");

            _context.PostWarranties.Update(postWarranty);
            await _context.SaveChangesAsync();
        }
    }
}
