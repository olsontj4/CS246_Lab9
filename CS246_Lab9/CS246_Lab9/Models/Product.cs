namespace CS246_Lab9.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; } = 0;
        public decimal CurrentPrice { get; set; } = 0m;//Product can be created and price added later.
    }
}