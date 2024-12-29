using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Data
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public required Order Order { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int? ReplicaId { get; set; }
        public Replica Replica { get; set; }

        public int? PartId { get; set; }
        public Part Part { get; set; }

        public int? AccessoryId { get; set; }
        public Accessory Accessory { get; set; }
    }
}
