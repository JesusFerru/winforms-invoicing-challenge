using InvoiceManager.WinForms.Services;

namespace InvoiceManager.WinForms
{
    public partial class initForm : Form
    {
        private readonly ApiService apiService;

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
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
