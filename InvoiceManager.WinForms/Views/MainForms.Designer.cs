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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(initForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            invoiceTitle = new Label();
            companyLogo = new PictureBox();
            btnRegisterInvoice = new Button();
            btnGetInvoices = new Button();
            NroFactura = new DataGridViewTextBoxColumn();
            CUF = new DataGridViewTextBoxColumn();
            nit = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            totalAmount = new DataGridViewTextBoxColumn();
            createdAt = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NroFactura, CUF, nit, customerName, totalAmount, createdAt, Status });
            dataGridView1.ContextMenuStrip = contextMenuStrip2;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(28, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(744, 267);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, pegarToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(110, 48);
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(109, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(109, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            // 
            // invoiceTitle
            // 
            invoiceTitle.AutoSize = true;
            invoiceTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceTitle.Location = new Point(28, 27);
            invoiceTitle.Name = "invoiceTitle";
            invoiceTitle.Size = new Size(216, 30);
            invoiceTitle.TabIndex = 1;
            invoiceTitle.Text = "Registro de Facturas ";
            // 
            // companyLogo
            // 
            companyLogo.Image = (Image)resources.GetObject("companyLogo.Image");
            companyLogo.Location = new Point(685, 1);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(110, 83);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 2;
            companyLogo.TabStop = false;
            // 
            // btnRegisterInvoice
            // 
            btnRegisterInvoice.Cursor = Cursors.Hand;
            btnRegisterInvoice.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnRegisterInvoice.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnRegisterInvoice.FlatStyle = FlatStyle.Flat;
            btnRegisterInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterInvoice.Location = new Point(653, 407);
            btnRegisterInvoice.Name = "btnRegisterInvoice";
            btnRegisterInvoice.Size = new Size(119, 50);
            btnRegisterInvoice.TabIndex = 3;
            btnRegisterInvoice.Text = "Nueva Factura";
            btnRegisterInvoice.UseVisualStyleBackColor = true;
            btnRegisterInvoice.Click += btnRegisterInvoice_Click;
            // 
            // btnGetInvoices
            // 
            btnGetInvoices.Location = new Point(28, 407);
            btnGetInvoices.Name = "btnGetInvoices";
            btnGetInvoices.Size = new Size(119, 50);
            btnGetInvoices.TabIndex = 4;
            btnGetInvoices.Text = "Consultar Facturas";
            btnGetInvoices.UseVisualStyleBackColor = true;
            btnGetInvoices.Click += btnGetInvoices_Click;
            // 
            // NroFactura
            // 
            NroFactura.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NroFactura.DefaultCellStyle = dataGridViewCellStyle2;
            NroFactura.HeaderText = "NroFactura";
            NroFactura.Name = "NroFactura";
            NroFactura.ReadOnly = true;
            // 
            // CUF
            // 
            CUF.DataPropertyName = "CUF";
            CUF.HeaderText = "CUF";
            CUF.Name = "CUF";
            CUF.ReadOnly = true;
            // 
            // nit
            // 
            nit.DataPropertyName = "NIT";
            nit.HeaderText = "NIT Cliente";
            nit.Name = "nit";
            nit.ReadOnly = true;
            // 
            // customerName
            // 
            customerName.DataPropertyName = "CustomerName";
            customerName.HeaderText = "Nombre Cliente";
            customerName.Name = "customerName";
            customerName.ReadOnly = true;
            // 
            // totalAmount
            // 
            totalAmount.DataPropertyName = "TotalAmount";
            totalAmount.HeaderText = "Total";
            totalAmount.Name = "totalAmount";
            totalAmount.ReadOnly = true;
            // 
            // createdAt
            // 
            createdAt.DataPropertyName = "CreatedAt";
            createdAt.HeaderText = "Fecha";
            createdAt.Name = "createdAt";
            createdAt.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Estado Actual";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // initForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 469);
            Controls.Add(btnGetInvoices);
            Controls.Add(btnRegisterInvoice);
            Controls.Add(companyLogo);
            Controls.Add(invoiceTitle);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "initForm";
            Text = "Menu Facturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label invoiceTitle;
        private PictureBox companyLogo;
        private Button btnRegisterInvoice;
        private Button btnGetInvoices;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private DataGridViewTextBoxColumn NroFactura;
        private DataGridViewTextBoxColumn CUF;
        private DataGridViewTextBoxColumn nit;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn totalAmount;
        private DataGridViewTextBoxColumn createdAt;
        private DataGridViewTextBoxColumn Status;
    }
}
