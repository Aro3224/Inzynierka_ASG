using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Data
{
    public class PostWarranty
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public required string DamageDescription { get; set; }
        public string? ServiceAnswer { get; set; }
        public string? ServiceAnswerAfterRepair { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal Cost { get; set; }
        public ServiceStatus ServiceStatus { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }

    public enum ServiceStatus
    {
        [Display(Name = "Utworzono")]
        Created,

        [Display(Name = "Przyjęto na serwis")]
        Confirmed,

        [Display(Name = "Anulowano")]
        Canceled,

        [Display(Name = "Naprawiono")]
        Repaired,

        [Display(Name = "Odesłano")]
        Returned
    }
}
