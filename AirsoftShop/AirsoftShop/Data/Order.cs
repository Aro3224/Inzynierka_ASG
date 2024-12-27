using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Data
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string ShippingAddress { get; set; } = "";

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        public PaymentStatus PaymentStatus { get; set; }

        public string CustomerComment { get; set; } = "";

        [Required]
        public List<OrderItem> OrderItems { get; set; } = [];
    }

    public enum OrderStatus
    {
        [Display(Name = "Utworzono")]
        Created,

        [Display(Name = "Przyjęto")]
        Accepted,

        [Display(Name = "Wysłano")]
        Sent,

        [Display(Name = "Dostarczono")]
        Completed,

        [Display(Name = "Anulowano")]
        Canceled
    }

    public enum PaymentMethod
    {
        [Display(Name = "Karta debetowa")]
        Card,

        Blik,
        GooglePay,
        PayPal,
        PayU,

        [Display(Name = "Za pobraniem")]
        OnDelivery,

        [Display(Name = "Przelew")]
        Transfer
    }

    public enum PaymentStatus
    {
        [Display(Name = "Oczekująca")]
        Pending,

        [Display(Name = "Zapłacono")]
        Paid,

        [Display(Name = "Nieudana")]
        Failed,

        [Display(Name = "Zwrócona")]
        Refunded,

        [Display(Name = "Anulowana")]
        Cancelled
    }
}
