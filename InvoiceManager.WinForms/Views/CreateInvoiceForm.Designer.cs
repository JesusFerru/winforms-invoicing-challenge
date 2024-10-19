namespace InvoiceManager.WinForms.Views
{
    partial class CreateInvoiceForm
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
            txtNit = new TextBox();
            txtCustomerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUnitPrice = new TextBox();
            cbProduct = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            numQuantity = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label6 = new Label();
            btnAddItemInvoice = new Button();
            labelTotalAmount = new Label();
            btnSaveInvoice = new Button();
            btnCancelInvoice = new Button();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNit
            // 
            txtNit.Location = new Point(433, 25);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(173, 21);
            txtNit.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(433, 52);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(173, 21);
            txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 31);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "NIT: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 130);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Producto:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(327, 124);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(86, 21);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += textBox3_TextChanged;
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(80, 122);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(143, 23);
            cbProduct.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 130);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 9;
            label4.Text = "Precio/Unidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 130);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "Cantidad:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(496, 126);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(56, 21);
            numQuantity.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Description, Quantity, UnitPrice, Subtotal });
            dataGridView1.Location = new Point(62, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(583, 178);
            dataGridView1.TabIndex = 12;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Description
            // 
            Description.DataPropertyName = "description";
            Description.HeaderText = "Descripcion";
            Description.Name = "Description";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "quantity";
            Quantity.HeaderText = "Cantidad";
            Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "unitPrice";
            UnitPrice.HeaderText = "Precio/Unidad";
            UnitPrice.Name = "UnitPrice";
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "subtotal";
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(390, 363);
            label6.Name = "label6";
            label6.Size = new Size(162, 31);
            label6.TabIndex = 13;
            label6.Text = "Total:     Bs. ";
            // 
            // btnAddItemInvoice
            // 
            btnAddItemInvoice.Location = new Point(589, 111);
            btnAddItemInvoice.Name = "btnAddItemInvoice";
            btnAddItemInvoice.Size = new Size(93, 47);
            btnAddItemInvoice.TabIndex = 14;
            btnAddItemInvoice.Text = "Añadir Producto";
            btnAddItemInvoice.UseVisualStyleBackColor = true;
            btnAddItemInvoice.Click += btnAddItemInvoice_Click;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelTotalAmount.Location = new Point(571, 367);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(24, 26);
            labelTotalAmount.TabIndex = 15;
            labelTotalAmount.Text = "0";
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Font = new Font("Segoe UI Symbol", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveInvoice.Location = new Point(25, 372);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(103, 32);
            btnSaveInvoice.TabIndex = 16;
            btnSaveInvoice.Text = "Guardar";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // btnCancelInvoice
            // 
            btnCancelInvoice.Cursor = Cursors.Hand;
            btnCancelInvoice.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnCancelInvoice.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnCancelInvoice.FlatStyle = FlatStyle.Flat;
            btnCancelInvoice.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelInvoice.Location = new Point(157, 372);
            btnCancelInvoice.Name = "btnCancelInvoice";
            btnCancelInvoice.Size = new Size(103, 32);
            btnCancelInvoice.TabIndex = 17;
            btnCancelInvoice.Text = "Cancelar";
            btnCancelInvoice.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelTitle.Location = new Point(25, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(198, 26);
            labelTitle.TabIndex = 18;
            labelTitle.Text = "Registrar Factura";
            // 
            // CreateInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(705, 416);
            Controls.Add(labelTitle);
            Controls.Add(btnCancelInvoice);
            Controls.Add(btnSaveInvoice);
            Controls.Add(labelTotalAmount);
            Controls.Add(btnAddItemInvoice);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(numQuantity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbProduct);
            Controls.Add(label3);
            Controls.Add(txtUnitPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            Controls.Add(txtNit);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateInvoiceForm";
            Text = "Nueva Factura";
            Load += CreateInvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNit;
        private TextBox txtCustomerName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUnitPrice;
        private ComboBox cbProduct;
        private Label label4;
        private Label label5;
        private NumericUpDown numQuantity;
        private DataGridView dataGridView1;
        private Label label6;
        private Button btnAddItemInvoice;
        private Label labelTotalAmount;
        private Button btnSaveInvoice;
        private Button btnCancelInvoice;
        private Label labelTitle;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Subtotal;
    }
}