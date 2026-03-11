namespace CS246_Lab9.Models
{
    public class ProductListing
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public string? Description { get; set; }
        public List<string>? Tags { get; set; }
        public List<string> ImageURLs { get; set; } = new List<string>();
        public List<string> Materials { get; set; } = new List<string>();
        public int Quantity { get; set; }
    }
}
