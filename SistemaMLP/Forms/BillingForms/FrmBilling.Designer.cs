namespace SistemaMLP.Forms.BillingForms
{
    partial class FrmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilling));
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.Gb_Products = new System.Windows.Forms.GroupBox();
            this.LblCuts = new System.Windows.Forms.Label();
            this.CbCuts = new System.Windows.Forms.ComboBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.UDQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnAddLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBTax = new System.Windows.Forms.CheckBox();
            this.CkbConfirmed = new System.Windows.Forms.CheckBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.BtnBilling = new System.Windows.Forms.Button();
            this.LblAmount = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnDelLine = new System.Windows.Forms.Button();
            this.DGVLines = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.BtnSelectCustomer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.Gb_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProducts
            // 
            this.DGVProducts.AllowUserToAddRows = false;
            this.DGVProducts.AllowUserToDeleteRows = false;
            this.DGVProducts.AllowUserToResizeColumns = false;
            this.DGVProducts.AllowUserToResizeRows = false;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(24, 49);
            this.DGVProducts.MultiSelect = false;
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProducts.Size = new System.Drawing.Size(800, 156);
            this.DGVProducts.TabIndex = 0;
            this.DGVProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProducts_CellClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(79, 21);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(234, 22);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // Gb_Products
            // 
            this.Gb_Products.Controls.Add(this.LblCuts);
            this.Gb_Products.Controls.Add(this.CbCuts);
            this.Gb_Products.Controls.Add(this.LblQuantity);
            this.Gb_Products.Controls.Add(this.UDQuantity);
            this.Gb_Products.Controls.Add(this.BtnAddLine);
            this.Gb_Products.Controls.Add(this.label1);
            this.Gb_Products.Controls.Add(this.DGVProducts);
            this.Gb_Products.Controls.Add(this.TxtSearch);
            this.Gb_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Products.Location = new System.Drawing.Point(13, 67);
            this.Gb_Products.Name = "Gb_Products";
            this.Gb_Products.Size = new System.Drawing.Size(988, 222);
            this.Gb_Products.TabIndex = 2;
            this.Gb_Products.TabStop = false;
            this.Gb_Products.Text = "Productos";
            // 
            // LblCuts
            // 
            this.LblCuts.AutoSize = true;
            this.LblCuts.Location = new System.Drawing.Point(830, 49);
            this.LblCuts.Name = "LblCuts";
            this.LblCuts.Size = new System.Drawing.Size(123, 16);
            this.LblCuts.TabIndex = 7;
            this.LblCuts.Text = "Cortes disponibles:";
            this.LblCuts.Visible = false;
            // 
            // CbCuts
            // 
            this.CbCuts.FormattingEnabled = true;
            this.CbCuts.Location = new System.Drawing.Point(830, 68);
            this.CbCuts.Name = "CbCuts";
            this.CbCuts.Size = new System.Drawing.Size(145, 24);
            this.CbCuts.TabIndex = 6;
            this.CbCuts.Visible = false;
            this.CbCuts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbCuts_KeyPress);
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(830, 108);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(130, 16);
            this.LblQuantity.TabIndex = 5;
            this.LblQuantity.Text = "Cantidad comprada:";
            this.LblQuantity.Click += new System.EventHandler(this.LblQuantity_Click);
            // 
            // UDQuantity
            // 
            this.UDQuantity.Location = new System.Drawing.Point(830, 127);
            this.UDQuantity.Name = "UDQuantity";
            this.UDQuantity.Size = new System.Drawing.Size(145, 22);
            this.UDQuantity.TabIndex = 4;
            this.UDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDQuantity.ValueChanged += new System.EventHandler(this.UDQuantity_ValueChanged);
            // 
            // BtnAddLine
            // 
            this.BtnAddLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddLine.Image = global::SistemaMLP.Properties.Resources.Add_Cart_icon;
            this.BtnAddLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddLine.Location = new System.Drawing.Point(830, 165);
            this.BtnAddLine.Name = "BtnAddLine";
            this.BtnAddLine.Size = new System.Drawing.Size(145, 42);
            this.BtnAddLine.TabIndex = 3;
            this.BtnAddLine.Text = "Agregar a factura";
            this.BtnAddLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddLine.UseVisualStyleBackColor = true;
            this.BtnAddLine.Click += new System.EventHandler(this.BtnAddLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CBTax);
            this.groupBox2.Controls.Add(this.CkbConfirmed);
            this.groupBox2.Controls.Add(this.TxtNotes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CbPaymentMethod);
            this.groupBox2.Controls.Add(this.BtnBilling);
            this.groupBox2.Controls.Add(this.LblAmount);
            this.groupBox2.Controls.Add(this.LblTax);
            this.groupBox2.Controls.Add(this.LblTotal);
            this.groupBox2.Controls.Add(this.BtnDelLine);
            this.groupBox2.Controls.Add(this.DGVLines);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 310);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Notas de venta:";
            // 
            // CBTax
            // 
            this.CBTax.AutoSize = true;
            this.CBTax.Checked = true;
            this.CBTax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBTax.Location = new System.Drawing.Point(538, 279);
            this.CBTax.Name = "CBTax";
            this.CBTax.Size = new System.Drawing.Size(126, 20);
            this.CBTax.TabIndex = 6;
            this.CBTax.Text = "Cobrar impuesto";
            this.CBTax.UseVisualStyleBackColor = true;
            this.CBTax.CheckedChanged += new System.EventHandler(this.CBTax_CheckedChanged);
            // 
            // CkbConfirmed
            // 
            this.CkbConfirmed.AutoSize = true;
            this.CkbConfirmed.Location = new System.Drawing.Point(848, 78);
            this.CkbConfirmed.Name = "CkbConfirmed";
            this.CkbConfirmed.Size = new System.Drawing.Size(132, 20);
            this.CkbConfirmed.TabIndex = 8;
            this.CkbConfirmed.Text = "Pago Confirmado";
            this.CkbConfirmed.UseVisualStyleBackColor = true;
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(538, 178);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(286, 95);
            this.TxtNotes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Método de pago:";
            // 
            // CbPaymentMethod
            // 
            this.CbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPaymentMethod.FormattingEnabled = true;
            this.CbPaymentMethod.Location = new System.Drawing.Point(848, 38);
            this.CbPaymentMethod.Name = "CbPaymentMethod";
            this.CbPaymentMethod.Size = new System.Drawing.Size(124, 24);
            this.CbPaymentMethod.TabIndex = 6;
            this.CbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.CbPaymentMethod_SelectedIndexChanged);
            // 
            // BtnBilling
            // 
            this.BtnBilling.Enabled = false;
            this.BtnBilling.Image = global::SistemaMLP.Properties.Resources.Ecommerce_Cash_Register_icon;
            this.BtnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBilling.Location = new System.Drawing.Point(848, 206);
            this.BtnBilling.Name = "BtnBilling";
            this.BtnBilling.Size = new System.Drawing.Size(124, 42);
            this.BtnBilling.TabIndex = 5;
            this.BtnBilling.Text = "Facturar";
            this.BtnBilling.UseVisualStyleBackColor = true;
            this.BtnBilling.Click += new System.EventHandler(this.BtnBilling_Click);
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.Location = new System.Drawing.Point(19, 265);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(155, 29);
            this.LblAmount.TabIndex = 4;
            this.LblAmount.Text = "Subtotal: ₡0";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTax.Location = new System.Drawing.Point(19, 219);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(179, 29);
            this.LblTax.TabIndex = 3;
            this.LblTax.Text = "Impuestos: ₡0";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(19, 178);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(119, 29);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total: ₡0";
            // 
            // BtnDelLine
            // 
            this.BtnDelLine.Image = global::SistemaMLP.Properties.Resources.trash_icon;
            this.BtnDelLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelLine.Location = new System.Drawing.Point(848, 114);
            this.BtnDelLine.Name = "BtnDelLine";
            this.BtnDelLine.Size = new System.Drawing.Size(124, 42);
            this.BtnDelLine.TabIndex = 1;
            this.BtnDelLine.Text = "Eliminar línea";
            this.BtnDelLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelLine.UseVisualStyleBackColor = true;
            this.BtnDelLine.Click += new System.EventHandler(this.BtnDelLine_Click);
            // 
            // DGVLines
            // 
            this.DGVLines.AllowUserToAddRows = false;
            this.DGVLines.AllowUserToDeleteRows = false;
            this.DGVLines.AllowUserToResizeColumns = false;
            this.DGVLines.AllowUserToResizeRows = false;
            this.DGVLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLines.Location = new System.Drawing.Point(24, 19);
            this.DGVLines.MultiSelect = false;
            this.DGVLines.Name = "DGVLines";
            this.DGVLines.ReadOnly = true;
            this.DGVLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLines.Size = new System.Drawing.Size(800, 150);
            this.DGVLines.TabIndex = 0;
            this.DGVLines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLines_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(88, 18);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(145, 20);
            this.LblCustomerName.TabIndex = 5;
            this.LblCustomerName.Text = "Cliente particular";
            // 
            // BtnSelectCustomer
            // 
            this.BtnSelectCustomer.Location = new System.Drawing.Point(92, 41);
            this.BtnSelectCustomer.Name = "BtnSelectCustomer";
            this.BtnSelectCustomer.Size = new System.Drawing.Size(130, 23);
            this.BtnSelectCustomer.TabIndex = 7;
            this.BtnSelectCustomer.Text = "Seleccionar cliente";
            this.BtnSelectCustomer.UseVisualStyleBackColor = true;
            this.BtnSelectCustomer.Click += new System.EventHandler(this.BtnSelectCustomer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMLP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(891, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSelectCustomer);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Gb_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBilling";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.Shown += new System.EventHandler(this.FrmBilling_Shown);
            this.Click += new System.EventHandler(this.FrmBilling_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.Gb_Products.ResumeLayout(false);
            this.Gb_Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.GroupBox Gb_Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGVLines;
        private System.Windows.Forms.NumericUpDown UDQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Button BtnBilling;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnDelLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.CheckBox CBTax;
        private System.Windows.Forms.Button BtnSelectCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbPaymentMethod;
        private System.Windows.Forms.CheckBox CkbConfirmed;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbCuts;
        private System.Windows.Forms.Label LblCuts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}