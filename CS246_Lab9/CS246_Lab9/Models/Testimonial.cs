namespace CS246_Lab9.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public required AppUser User { get; set; }
        public required string Feedback { get; set; }
        public bool IsApproved { get; set; }
    }
}
