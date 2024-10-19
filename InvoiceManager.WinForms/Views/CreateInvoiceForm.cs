using InvoiceManager.WinForms.Helpers;
using InvoiceManager.WinForms.Models.Dtos;
using InvoiceManager.WinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager.WinForms.Views
{
    public partial class CreateInvoiceForm : Form
    {
        private readonly ApiService apiService;
        public CreateInvoiceForm()
        {
            InitializeComponent();
            apiService = new ApiService();
        }

        private void CreateInvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItemInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbProduct.Text) || string.IsNullOrEmpty(txtUnitPrice.Text) || numQuantity.Value == 0)
            {
                MessageBox.Show("Todos los campos de producto deben estar completos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Mostrar lista de Productos
            dataGridView1.Rows.Add(
                dataGridView1.Rows.Count + 1, //Id
                cbProduct.Text, numQuantity.Value,  //cantidad 
                txtUnitPrice.Text, //precio unidad
                (numQuantity.Value * decimal.Parse(txtUnitPrice.Text)));    //subtotal

            // Actualizar el total general
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            labelTotalAmount.Text = $"{total}";
        }

        private async void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (!Validations.IsValidNIT(txtNit.Text) || !Validations.IsValidCustomerName(txtCustomerName.Text))
            {
                MessageBox.Show("El NIT y el Nombre del cliente son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recopilar los ítems desde el DataGridView
            var lineItems = new List<CreateInvoiceLineItemDto>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["Description"].Value != null && row.Cells["Quantity"].Value != null && row.Cells["UnitPrice"].Value != null)
                {
                    var lineItem = new CreateInvoiceLineItemDto
                    {
                        Description = row.Cells["Description"].Value.ToString(),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                        UnitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value)
                    };
                    lineItems.Add(lineItem);
                }
            }

            // Crear el DTO para la factura
            var createInvoiceDto = new CreateInvoiceDto
            {
                NIT = txtNit.Text,
                CustomerName = txtCustomerName.Text,
                LineItems = lineItems
            };

            // Llamar al servicio API para guardar la factura
            var result = await apiService.CreateInvoiceAsync(createInvoiceDto);
            if (result)
            {
                MessageBox.Show("Factura creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                // Cierra el formulario para volver al MainForms
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al crear la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
