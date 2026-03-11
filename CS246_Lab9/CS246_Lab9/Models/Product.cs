namespace CS246_Lab9.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public string? Description { get; set; }
        public required List<ImageURL> ImageURLs { get; set; }
        public required int Quantity { get; set; }
    }
}