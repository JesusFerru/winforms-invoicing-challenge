namespace InvoiceManager.WinForms
{
    partial class DownloadInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSavePdf = new Button();
            txtShowInvoice = new RichTextBox();
            SuspendLayout();
            // 
            // btnSavePdf
            // 
            btnSavePdf.Location = new Point(364, 383);
            btnSavePdf.Name = "btnSavePdf";
            btnSavePdf.Size = new Size(75, 42);
            btnSavePdf.TabIndex = 1;
            btnSavePdf.Text = "Guardar en PDF";
            btnSavePdf.UseVisualStyleBackColor = true;
            btnSavePdf.Click += btnSavePdf_Click;
            // 
            // txtShowInvoice
            // 
            txtShowInvoice.Cursor = Cursors.IBeam;
            txtShowInvoice.Location = new Point(25, 36);
            txtShowInvoice.Name = "txtShowInvoice";
            txtShowInvoice.ReadOnly = true;
            txtShowInvoice.Size = new Size(346, 325);
            txtShowInvoice.TabIndex = 2;
            txtShowInvoice.Text = "";
            // 
            // DownloadInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 428);
            Controls.Add(txtShowInvoice);
            Controls.Add(btnSavePdf);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DownloadInvoiceForm";
            Text = "Descargar Factura";
            ResumeLayout(false);
        }

        #endregion
        private Button btnSavePdf;
        private RichTextBox txtShowInvoice;
    }
}