namespace CS246_Lab9.Models
{
    public class ProductListing
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public string? Details { get; set; }
        public required string Category { get; set; }
        public List<Tag> Tags { get; set; } = new();
        public List<ImageURL> ImageURLs { get; set; } = new();
        public List<Material> Materials { get; set; } = new();
        public bool IsVisible { get; set; } = false;
    }
}
