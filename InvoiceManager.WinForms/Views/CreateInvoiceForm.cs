using InvoiceManager.WinForms.Helpers;
using InvoiceManager.WinForms.Models.Dtos;
using InvoiceManager.WinForms.Services;

namespace InvoiceManager.WinForms.Views
{
    public partial class CreateInvoiceForm : Form
    {
        private readonly ApiService apiService;
        private bool isCancellationConfirmed = false;

        public CreateInvoiceForm()
        {
            InitializeComponent();
            apiService = new ApiService();

            txtNit.KeyDown += HandleEnterKeyPress;
            txtCustomerName.KeyDown += HandleEnterKeyPress;
            dataGridView1.KeyDown += HandleEnterKeyPress;
            cbProduct.KeyDown += HandleEnterKeyPress;
            numQuantity.KeyDown += HandleEnterKeyPress;
            txtUnitPrice.KeyDown += HandleEnterKeyPress;
            btnSaveInvoice.KeyDown += HandleEnterKeyPress;
            btnAddItemInvoice.KeyDown += btnAddItemInvoice_KeyDown;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateInvoiceForm_FormClosing);

        }
        private void HandleEnterKeyPress(object sender, KeyEventArgs e)
        {
            // Si el usuario presiona Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // Evita el sonido 'ding'
                                            // Enfoca el siguiente control en el orden del tab
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnAddItemInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbProduct.Text))
            {
                MessageBox.Show("Debe seleccionar un producto.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbProduct.Focus();
                return;
            }

            // Validar que el campo de cantidad (numQuantity) sea mayor que 0
            if (numQuantity.Value == 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numQuantity.Focus();
                return;
            }

            if (!Validations.IsValidQuantity(numQuantity.Value))
            {
                MessageBox.Show("Ingrese un valor entero para la cantidad del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numQuantity.Focus();
                return;
            }

            // Validar que el precio unitario (txtUnitPrice) sea un número decimal válido y mayor que 0
            if (!Validations.IsValidUnitPrice(txtUnitPrice.Text))
            {
                MessageBox.Show("El precio unitario debe ser un número válido mayor que 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitPrice.Focus();
                return;
            }

            // Si todas las validaciones pasan, añadir el producto a la grilla
            dataGridView1.Rows.Add(
                dataGridView1.Rows.Count + 1, //Id
                cbProduct.Text,               // Producto seleccionado
                numQuantity.Value,            // Cantidad
                txtUnitPrice.Text,            // Precio por unidad
                (numQuantity.Value * decimal.Parse(txtUnitPrice.Text))  // Subtotal
            );

            // Actualizar el total de la factura
            UpdateTotalAmount();

            // Enfocar de nuevo en el ComboBox para continuar añadiendo productos
            cbProduct.Focus();
        }

        private void btnAddItemInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cbProduct.Focus();
            }
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

            if (!Validations.IsValidLineItems(dataGridView1))
            {
                MessageBox.Show("Debe haber al menos un ítem de factura válido (descripción, cantidad y precio deben estar completos y correctos).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar los ítems desde el DataGridView
            var lineItems = new List<CreateInvoiceLineItemDto>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Validations.IsValidInvoiceLineItem(row))
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

        private void btnCancelInvoice_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Desea cancelar el registro de la factura?",
                "Cancelar Registro",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                isCancellationConfirmed = true;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void CreateInvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCancellationConfirmed)
            {
                var result = MessageBox.Show(
                    "¿Desea cancelar el registro de la factura?",
                    "Confirmar cancelación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.OK)
                {
                    e.Cancel = true; // Cancelar el cierre si el usuario selecciona "Cancelar"
                }
            }
        }
    }
}
