namespace CS246_Lab9.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public required string ShippingAddress { get; set; }
        public required DateTime OrderDate { get; set; }
        public required decimal TotalSpent { get; set; }
        public required List<InvoiceLineItem> LineItems { get; set; }
        public string? SpecialInstructions { get; set; }
        public string? Status { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
