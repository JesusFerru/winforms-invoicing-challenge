using System.Text.Json.Serialization;

public class InvoiceLineItem
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Subtotal => Quantity * UnitPrice;

    [JsonIgnore]
    public int InvoiceId { get; set; }
    [JsonIgnore]
    public Invoice? Invoice { get; set; }
}
