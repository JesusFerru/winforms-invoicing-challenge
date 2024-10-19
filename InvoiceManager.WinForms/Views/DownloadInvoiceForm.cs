using InvoiceManager.WinForms.Services;
using System.Text;

namespace InvoiceManager.WinForms
{
    public partial class DownloadInvoiceForm : Form
    {
        private int idInvoice;
        private string cuf;
        private readonly ApiService apiService;
        private readonly PdfService pdfService;
        public DownloadInvoiceForm(int selectedNroFactura, string selectedCUF)
        {
            InitializeComponent();
            idInvoice = selectedNroFactura;
            cuf = selectedCUF;
            apiService = new ApiService();
            pdfService = new PdfService();
            DownloadInvoiceForm_Load();
        }

        private async void DownloadInvoiceForm_Load()
        {
            var invoice = await apiService.GetInvoiceByCUFAsync(cuf);

            if (invoice != null)
            {
                txtShowInvoice.Clear();

                AppendFormattedText($"Factura # {idInvoice}\n", FontStyle.Bold, 14);
                AppendFormattedText($"Empresa ABC COMPANY\n\n\n\n", FontStyle.Bold, 10);
                AppendFormattedText($"NIT: {invoice.NIT}\n", FontStyle.Regular, 10);
                AppendFormattedText($"Cliente: {invoice.CustomerName}\n", FontStyle.Regular, 10);
                AppendFormattedText($"Fecha de Emisión: {invoice.CreatedAt}\n\n", FontStyle.Regular, 10);

                AppendFormattedText("Detalles de la factura:\n", FontStyle.Bold, 12);

                foreach (var item in invoice.LineItems)
                {
                    AppendFormattedText($" - {item.Description}: {item.Quantity} x {item.UnitPrice:C} = Bs. {item.Subtotal:C}\n", FontStyle.Regular, 10);
                }

                AppendFormattedText($"\nTotal: {invoice.TotalAmount:C}\n", FontStyle.Bold, 12);

            }
            else
            {
                MessageBox.Show("No se encontró la factura.");
                this.Close();
            }
        }

        private void AppendFormattedText(string text, FontStyle style, int fontSize)
        {
            // Guardar la longitud actual del texto en el RichTextBox
            int start = txtShowInvoice.TextLength;

            // Añadir el texto sin formato
            txtShowInvoice.AppendText(text);

            // Aplicar el formato
            txtShowInvoice.Select(start, text.Length);
            txtShowInvoice.SelectionFont = new Font(txtShowInvoice.Font.FontFamily, fontSize, style);
            txtShowInvoice.SelectionLength = 0; // Desseleccionar el texto
        }

        private async void btnSavePdf_Click(object sender, EventArgs e)
        {
            var pdfBytes = await pdfService.DownloadInvoicePdfAsync(cuf);

            if (pdfBytes != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar factura como PDF";
                    saveFileDialog.FileName = $"Factura_{cuf}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo en el directorio seleccionado por el usuario
                        File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);

                        // Mostrar mensaje con un enlace para abrir el archivo guardado
                        var filePath = saveFileDialog.FileName;
                        MessageBox.Show($"PDF guardado correctamente en: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Opción para abrir el archivo guardado directamente
                        var result = MessageBox.Show("¿Deseas abrir el PDF ahora?", "Abrir PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Abre el archivo PDF guardado
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo descargar el PDF. Verifica que la factura esté en estado 'Aceptada'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
