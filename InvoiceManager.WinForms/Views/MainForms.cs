using InvoiceManager.WinForms.Services;
using InvoiceManager.WinForms.Views;

namespace InvoiceManager.WinForms
{
    public partial class initForm : Form
    {
        private readonly ApiService apiService;
        private string selectedCUF;
        private int selectedNroFactura;

        public initForm()
        {
            InitializeComponent();
            apiService = new ApiService();
        }

        private async void btnGetInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                var facturas = await apiService.GetInvoicesAsync();

                if (facturas == null || facturas.Count == 0)
                {
                    MessageBox.Show("No se encontraron facturas en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.DataSource = facturas;

                int totalFacturas = facturas.Count;
                for (int i = 0; i < facturas.Count; i++)
                {
                    // Asigna el número de factura en la columna NroFactura (en orden descendente)
                    dataGridView1.Rows[i].Cells["NroFactura"].Value = totalFacturas - i;

                    var status = dataGridView1.Rows[i].Cells["Status"].Value;

                    if (status != null && int.TryParse(status.ToString(), out int statusValue))
                    {
                        // Si el estado es 0, muestra "Pendiente"; si es 1, muestra "Aceptado"
                        dataGridView1.Rows[i].Cells["Status"].Value = statusValue == 0 ? "Pendiente" : "Aceptado";
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                // Mostrar un mensaje de error si no se puede conectar con la API
                MessageBox.Show("Error al conectar con la API. Asegúrese de que el backend esté en ejecución.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegisterInvoice_Click(object sender, EventArgs e)
        {
            using (var createInvoiceForm = new CreateInvoiceForm())
            {
                var dialogResult = createInvoiceForm.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {    
            if (dataGridView1.Rows.Count == 0 || e.RowIndex < 0)
            {
                MessageBox.Show("No seleccionó ninguna factura correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica que la columna "CUF" no sea nula
            if (dataGridView1.Rows[e.RowIndex].Cells["CUF"].Value != null)
            {
                // Obtener el CUF de la fila seleccionada
                selectedCUF = dataGridView1.Rows[e.RowIndex].Cells["CUF"].Value.ToString();
                selectedNroFactura = (int)dataGridView1.Rows[e.RowIndex].Cells["NroFactura"].Value;

                MessageBox.Show($"Id seleccionado: {selectedNroFactura}");

                // Abre el formulario para descargar la factura
                DownloadInvoiceForm downloadForm = new DownloadInvoiceForm(selectedNroFactura, selectedCUF); // Pasa el CUF al formulario
                downloadForm.Show();
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna factura correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name == "CUF")
            {
                // Obtener el valor de la celda seleccionada
                string valorCelda = dataGridView1.CurrentCell.Value.ToString();

                // Copiar el valor al portapapeles
                Clipboard.SetText(valorCelda);
                MessageBox.Show("CUF copiado al portapapeles: " + valorCelda);
            }
        }

    }
}
