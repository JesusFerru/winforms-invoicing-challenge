using InvoiceManager.WinForms.Models;
using InvoiceManager.WinForms.Models.Dtos;
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
            try
            {
                var response = await client.GetAsync("/api/invoices");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Invoice>>(json);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al obtener las facturas: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            // En caso de error, devuelve una lista vacía
            return new List<Invoice>();
        }

        public async Task<bool> CreateInvoiceAsync(CreateInvoiceDto createInvoiceDto)
        {
            try
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(createInvoiceDto), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("/api/invoices", jsonContent);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al crear la factura: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            // En caso de error se devuelve false
            return false;
        }

        public async Task<Invoice> GetInvoiceByCUFAsync(string cuf)
        {
            try
            {
                var response = await client.GetAsync($"/api/invoices/{cuf}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Invoice>(json);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al obtener la factura con CUF {cuf}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            // En caso de error se devuelve null
            return null;
        }
    }
}
