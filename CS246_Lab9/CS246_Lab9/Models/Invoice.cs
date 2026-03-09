namespace CS246_Lab9.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public required string ShippingAddress { get; set; }
        public required List<Product> Products { get; set; } = [];
        public string? SpecialInstructions { get; set; }
    }
}
