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

        public static bool IsValidQuantity(object quantityValue)
        {
            if (quantityValue == null) return false;
            return int.TryParse(quantityValue.ToString(), out int _); // Verifica que sea un número entero
        }

        public static bool IsValidUnitPrice(object unitPriceValue)
        {
            if (unitPriceValue == null) return false;
            return double.TryParse(unitPriceValue.ToString(), out double _); // Verifica que sea un número decimal
        }

        public static bool IsValidInvoiceLineItem(DataGridViewRow row)
        {
            if (row.Cells["Description"].Value == null || string.IsNullOrEmpty(row.Cells["Description"].Value.ToString()))
            {
                return false;
            }

            if (row.Cells["Quantity"].Value == null || !int.TryParse(row.Cells["Quantity"].Value.ToString(), out int quantity) || quantity <= 0)
            {
                return false; // mayor a 0
            }

            if (row.Cells["UnitPrice"].Value == null || !decimal.TryParse(row.Cells["UnitPrice"].Value.ToString(), out decimal unitPrice) || unitPrice <= 0)
            {
                return false; // mayor a 0
            }

            return true; 
        }

        public static bool IsValidLineItems(DataGridView dataGridView)
        {
            bool hasValidItems = false;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (IsValidInvoiceLineItem(row))
                {
                    hasValidItems = true;
                }
            }
            return hasValidItems;
        }
    }
}
