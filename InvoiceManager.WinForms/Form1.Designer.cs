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
            dataGridView1 = new DataGridView();
            NroFactura = new DataGridViewTextBoxColumn();
            CUF = new DataGridViewTextBoxColumn();
            nit = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            totalAmount = new DataGridViewTextBoxColumn();
            createdAt = new DataGridViewTextBoxColumn();
            invoiceTitle = new Label();
            companyLogo = new PictureBox();
            btnSaveInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NroFactura, CUF, nit, customerName, totalAmount, createdAt });
            dataGridView1.Location = new Point(79, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.UseWaitCursor = true;
            // 
            // NroFactura
            // 
            NroFactura.HeaderText = "NroFactura";
            NroFactura.Name = "NroFactura";
            // 
            // CUF
            // 
            CUF.HeaderText = "CUF";
            CUF.Name = "CUF";
            // 
            // nit
            // 
            nit.HeaderText = "NIT Cliente";
            nit.Name = "nit";
            // 
            // customerName
            // 
            customerName.HeaderText = "Nombre Cliente";
            customerName.Name = "customerName";
            // 
            // totalAmount
            // 
            totalAmount.HeaderText = "Total";
            totalAmount.Name = "totalAmount";
            // 
            // createdAt
            // 
            createdAt.HeaderText = "Fecha";
            createdAt.Name = "createdAt";
            // 
            // invoiceTitle
            // 
            invoiceTitle.AutoSize = true;
            invoiceTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceTitle.Location = new Point(79, 34);
            invoiceTitle.Name = "invoiceTitle";
            invoiceTitle.Size = new Size(216, 30);
            invoiceTitle.TabIndex = 1;
            invoiceTitle.Text = "Registro de Facturas ";
            invoiceTitle.UseWaitCursor = true;
            invoiceTitle.Click += label1_Click;
            // 
            // companyLogo
            // 
            companyLogo.Image = (Image)resources.GetObject("companyLogo.Image");
            companyLogo.Location = new Point(688, 12);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(100, 67);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 2;
            companyLogo.TabStop = false;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Location = new Point(79, 302);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(119, 50);
            btnSaveInvoice.TabIndex = 3;
            btnSaveInvoice.Text = "Nueva Factura";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            // 
            // initForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveInvoice);
            Controls.Add(companyLogo);
            Controls.Add(invoiceTitle);
            Controls.Add(dataGridView1);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "initForm";
            Text = "Form1";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NroFactura;
        private DataGridViewTextBoxColumn CUF;
        private DataGridViewTextBoxColumn nit;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn totalAmount;
        private DataGridViewTextBoxColumn createdAt;
        private Label invoiceTitle;
        private PictureBox companyLogo;
        private Button btnSaveInvoice;
    }
}
