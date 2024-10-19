namespace InvoiceManager.WinForms.Services
{
    public class PdfService
    {
        private readonly HttpClient client;

        public PdfService()
        {
            client = new HttpClient { BaseAddress = new Uri("http://localhost:5050") };
        }
        public async Task<byte[]> DownloadInvoicePdfAsync(string cuf)
        {
            var response = await client.GetAsync($"/api/invoices/{cuf}/pdf");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();
            }
            return null;
        }

    }
}
