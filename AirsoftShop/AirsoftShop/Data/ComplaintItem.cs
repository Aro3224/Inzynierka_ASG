namespace AirsoftShop.Data
{
    public class ComplaintItem
    {
        public int Id { get; set; }
        public int ComplaintId { get; set; }
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; }
        public int Quantity { get; set; }

        public required Complaint Complaint { get; set; }
    }
}
