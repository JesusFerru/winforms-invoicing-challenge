using InvoiceManager.WinForms.Models;

namespace InvoiceManager.WinForms.Helpers
{
    public static class Validations
    {
        public static bool IsValidNIT(string nit)
        {
            return !string.IsNullOrEmpty(nit) && nit.All(char.IsDigit);
        }

        public static bool IsValidCustomerName(string customerName)
        {
            return !string.IsNullOrEmpty(customerName);
        }

        public static bool IsValidLineItems(List<InvoiceLineItem> items)
        {
            return items != null && items.Count > 0 && items.All(item => !string.IsNullOrEmpty(item.Description) && item.Quantity > 0 && item.UnitPrice > 0);
        }
    }
}
