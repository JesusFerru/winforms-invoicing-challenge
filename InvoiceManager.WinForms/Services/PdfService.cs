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
            try
            {
                var response = await client.GetAsync($"/api/invoices/{cuf}/pdf");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsByteArrayAsync();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al descargar el PDF de la factura con CUF {cuf}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            // En caso de error, devuelve null
            return null;
        }
    }
}
