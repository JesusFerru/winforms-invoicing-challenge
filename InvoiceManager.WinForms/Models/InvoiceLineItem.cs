namespace InvoiceManager.WinForms.Models
{
    public class InvoiceLineItem
    {
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal => Quantity * UnitPrice;
    }
}
