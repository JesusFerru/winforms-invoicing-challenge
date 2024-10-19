﻿using InvoiceManager.WinForms.Models;
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
            var response = await client.GetAsync("/api/invoices");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Invoice>>(json);
            }
            return new List<Invoice>();
        }

        public async Task<bool> CreateInvoiceAsync(CreateInvoiceDto createInvoiceDto)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(createInvoiceDto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/invoices", jsonContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<Invoice> GetInvoiceByCUFAsync(string cuf)
        {
            var response = await client.GetAsync($"/api/invoices/{cuf}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Invoice>(json);
            }
            return null;
        }
    }
}
