namespace InvoiceManager.WinForms.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public required string CUF { get; set; }
        public required string NIT { get; set; }
        public required string CustomerName { get; set; }
        public required List<InvoiceLineItem> LineItems { get; set; }
        public decimal TotalAmount { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
