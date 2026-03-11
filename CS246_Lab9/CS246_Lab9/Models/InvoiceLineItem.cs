using System.ComponentModel.DataAnnotations.Schema;

namespace CS246_Lab9.Models
{
    public class InvoiceLineItem
    {
        public int Id { get; set; }
        public required int InvoiceId { get; set; }
        public required int ProductId { get; set; }
        public required decimal PurchasedPrice { get; set; }
        public required int Quantity { get; set; }
        public decimal? ItemTotal { get; set; }
    }
}
