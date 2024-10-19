using InvoiceManager.WinForms.Services;
using InvoiceManager.WinForms.Views;

namespace InvoiceManager.WinForms
{
    public partial class initForm : Form
    {
        private readonly ApiService apiService;
        private string selectedCUF;

        public initForm()
        {
            InitializeComponent();
            apiService = new ApiService();
        }


        private void invoiceTitle_Click(object sender, EventArgs e)
        {

        }

        private async void btnGetInvoices_Click(object sender, EventArgs e)
        {
            var facturas = await apiService.GetInvoicesAsync();

            // Asigna la lista de facturas al DataGridView
            dataGridView1.DataSource = facturas;

            int totalFacturas = facturas.Count;
            for (int i = 0; i < facturas.Count; i++)
            {
                // Asigna el número de factura en la columna NroFactura (en orden descendente)
                dataGridView1.Rows[i].Cells["NroFactura"].Value = totalFacturas - i;
            }
        }

        private void btnRegisterInvoice_Click(object sender, EventArgs e)
        {
            using (var createInvoiceForm = new CreateInvoiceForm())
            {
                var dialogResult = createInvoiceForm.ShowDialog();

               
                if (dialogResult == DialogResult.OK)
                {
 
                }
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

                MessageBox.Show($"CUF seleccionado: {selectedCUF}");

                // Abre el formulario para descargar la factura
                DownloadInvoiceForm downloadForm = new DownloadInvoiceForm(selectedCUF); // Pasa el CUF al formulario
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
