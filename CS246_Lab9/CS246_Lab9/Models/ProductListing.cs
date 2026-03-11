namespace CS246_Lab9.Models
{
    public class ProductListing
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public string? Details { get; set; }
        public string? Category { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public List<string> ImageURLs { get; set; } = new List<string>();
        public List<string> Materials { get; set; } = new List<string>();
        public int Quantity { get; set; }
        public bool IsVisible => Quantity > 0;
    }
}
