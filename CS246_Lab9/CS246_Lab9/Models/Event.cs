namespace CS246_Lab9.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public string? ExternalLink { get; set; }
        public DateTime EventDate { get; set; }
        public bool IsRecurring { get; set; }
    }
}
