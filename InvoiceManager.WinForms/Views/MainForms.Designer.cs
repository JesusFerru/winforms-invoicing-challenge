namespace InvoiceManager.WinForms
{
    partial class initForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(initForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            invoiceTitle = new Label();
            companyLogo = new PictureBox();
            btnSaveInvoice = new Button();
            btnGetInvoices = new Button();
            btnDowloadInvoices = new Button();
            NroFactura = new DataGridViewTextBoxColumn();
            CUF = new DataGridViewTextBoxColumn();
            nit = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            totalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            createdAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NroFactura, CUF, nit, customerName, totalAmount, Status, createdAt });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(51, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 267);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // invoiceTitle
            // 
            invoiceTitle.AutoSize = true;
            invoiceTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceTitle.Location = new Point(51, 31);
            invoiceTitle.Name = "invoiceTitle";
            invoiceTitle.Size = new Size(216, 30);
            invoiceTitle.TabIndex = 1;
            invoiceTitle.Text = "Registro de Facturas ";
            invoiceTitle.Click += invoiceTitle_Click;
            // 
            // companyLogo
            // 
            companyLogo.Image = (Image)resources.GetObject("companyLogo.Image");
            companyLogo.Location = new Point(792, 1);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(110, 83);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 2;
            companyLogo.TabStop = false;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Location = new Point(176, 404);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(119, 50);
            btnSaveInvoice.TabIndex = 3;
            btnSaveInvoice.Text = "Nueva Factura";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            // 
            // btnGetInvoices
            // 
            btnGetInvoices.Location = new Point(51, 404);
            btnGetInvoices.Name = "btnGetInvoices";
            btnGetInvoices.Size = new Size(119, 50);
            btnGetInvoices.TabIndex = 4;
            btnGetInvoices.Text = "Consultar Facturas";
            btnGetInvoices.UseVisualStyleBackColor = true;
            btnGetInvoices.Click += btnGetInvoices_Click;
            // 
            // btnDowloadInvoices
            // 
            btnDowloadInvoices.Location = new Point(751, 404);
            btnDowloadInvoices.Name = "btnDowloadInvoices";
            btnDowloadInvoices.Size = new Size(119, 50);
            btnDowloadInvoices.TabIndex = 5;
            btnDowloadInvoices.Text = "Descargar Facturas";
            btnDowloadInvoices.UseVisualStyleBackColor = true;
            btnDowloadInvoices.Click += btnSaveInvoice_Click;
            // 
            // NroFactura
            // 
            NroFactura.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NroFactura.DefaultCellStyle = dataGridViewCellStyle1;
            NroFactura.HeaderText = "NroFactura";
            NroFactura.Name = "NroFactura";
            // 
            // CUF
            // 
            CUF.DataPropertyName = "CUF";
            CUF.HeaderText = "CUF";
            CUF.Name = "CUF";
            // 
            // nit
            // 
            nit.DataPropertyName = "NIT";
            nit.HeaderText = "NIT Cliente";
            nit.Name = "nit";
            // 
            // customerName
            // 
            customerName.DataPropertyName = "CustomerName";
            customerName.HeaderText = "Nombre Cliente";
            customerName.Name = "customerName";
            // 
            // totalAmount
            // 
            totalAmount.DataPropertyName = "TotalAmount";
            totalAmount.HeaderText = "Total";
            totalAmount.Name = "totalAmount";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Estado Actual";
            Status.Name = "Status";
            // 
            // createdAt
            // 
            createdAt.DataPropertyName = "CreatedAt";
            createdAt.HeaderText = "Fecha";
            createdAt.Name = "createdAt";
            // 
            // initForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 479);
            Controls.Add(btnDowloadInvoices);
            Controls.Add(btnGetInvoices);
            Controls.Add(btnSaveInvoice);
            Controls.Add(companyLogo);
            Controls.Add(invoiceTitle);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "initForm";
            Text = "Menu Facturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label invoiceTitle;
        private PictureBox companyLogo;
        private Button btnSaveInvoice;
        private Button btnGetInvoices;
        private Button btnDowloadInvoices;
        private DataGridViewTextBoxColumn NroFactura;
        private DataGridViewTextBoxColumn CUF;
        private DataGridViewTextBoxColumn nit;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn totalAmount;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn createdAt;
    }
}
