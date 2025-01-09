using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Data
{
    public class Complaint
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public int OrderId { get; set; }
        public required string ComplaintDescription { get; set; }
        public required string ComplaintAnswer { get; set; }
        public ComplaintType ComplaintType { get; set; }
        public ComplaintStatus ComplaintStatus { get; set; }
        public CustomerComplaintChoice CustomerComplaintChoice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<ComplaintItem> ComplaintItems { get; set; } = new List<ComplaintItem>();
    }

    public enum ComplaintStatus
    {
        [Display(Name = "Utworzono")]
        Created,

        [Display(Name = "Zwrócono pieniądze")]
        Refunded,

        [Display(Name = "Naprawiono")]
        Repaired,

        [Display(Name = "Wymieniono na nowy")]
        Replaced,

        [Display(Name = "Odesłano")]
        Returned
    }

    public enum ComplaintType
    {
        [Display(Name = "Reklamacja")]
        Complaint,

        [Display(Name = "Zwrot")]
        Return,

        [Display(Name = "Serwis")]
        Service
    }

    public enum CustomerComplaintChoice
    {
        [Display(Name = "Zwrot pieniędzy")]
        MoneyReturn,

        [Display(Name = "Naprawa produktu")]
        ProductFix,

        [Display(Name = "Wymiana produktu na nowy")]
        ProductReplacement
    }
}
