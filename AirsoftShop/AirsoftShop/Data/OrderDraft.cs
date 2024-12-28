using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Data
{
    public class OrderDraft
    {
        [Required]
        public string? CustomerName { get; set; }

        [Required]
        public string? CustomerSurname { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? PostalCode { get; set; }

        [Required]
        public string? Address { get; set; }

        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.OnDelivery;

        public string? CustomerComment { get; set; }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
