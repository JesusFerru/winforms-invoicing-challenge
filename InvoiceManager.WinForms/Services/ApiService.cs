using InvoiceManager.WinForms.Models;
using Newtonsoft.Json;
using System.Text;

namespace InvoiceManager.WinForms.Services
{
    public class ApiService
    {
        private readonly HttpClient client;

        public ApiService()
        {
            client = new HttpClient { BaseAddress = new Uri("http://localhost:5050") };
        }

        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            var response = await client.GetAsync("/api/invoices");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Invoice>>(json);
            }
            return new List<Invoice>();
        }

        public async Task<bool> CreateInvoiceAsync(Invoice invoice)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/invoices", jsonContent);

            return response.IsSuccessStatusCode;
        }
    }
}
