﻿namespace SistemaMLP.Forms.BillingForms
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
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GbStockType = new System.Windows.Forms.GroupBox();
            this.RBtnChopped = new System.Windows.Forms.RadioButton();
            this.RBtnFilet = new System.Windows.Forms.RadioButton();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.UDQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnAddLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CkbConfirmed = new System.Windows.Forms.CheckBox();
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
            this.CBTax = new System.Windows.Forms.CheckBox();
            this.BtnSelectCustomer = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GbStockType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLines)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProducts
            // 
            this.DGVProducts.AllowUserToAddRows = false;
            this.DGVProducts.AllowUserToDeleteRows = false;
            this.DGVProducts.AllowUserToResizeColumns = false;
            this.DGVProducts.AllowUserToResizeRows = false;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(24, 55);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProducts.Size = new System.Drawing.Size(733, 150);
            this.DGVProducts.TabIndex = 0;
            this.DGVProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProducts_CellClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(70, 29);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(234, 20);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GbStockType);
            this.groupBox1.Controls.Add(this.LblQuantity);
            this.groupBox1.Controls.Add(this.UDQuantity);
            this.groupBox1.Controls.Add(this.BtnAddLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DGVProducts);
            this.groupBox1.Controls.Add(this.TxtSearch);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // GbStockType
            // 
            this.GbStockType.Controls.Add(this.RBtnChopped);
            this.GbStockType.Controls.Add(this.RBtnFilet);
            this.GbStockType.Location = new System.Drawing.Point(772, 55);
            this.GbStockType.Name = "GbStockType";
            this.GbStockType.Size = new System.Drawing.Size(133, 63);
            this.GbStockType.TabIndex = 7;
            this.GbStockType.TabStop = false;
            this.GbStockType.Text = "Tipo de corte";
            this.GbStockType.Visible = false;
            // 
            // RBtnChopped
            // 
            this.RBtnChopped.AutoSize = true;
            this.RBtnChopped.Location = new System.Drawing.Point(9, 42);
            this.RBtnChopped.Name = "RBtnChopped";
            this.RBtnChopped.Size = new System.Drawing.Size(58, 17);
            this.RBtnChopped.TabIndex = 7;
            this.RBtnChopped.TabStop = true;
            this.RBtnChopped.Text = "Picado";
            this.RBtnChopped.UseVisualStyleBackColor = true;
            // 
            // RBtnFilet
            // 
            this.RBtnFilet.AutoSize = true;
            this.RBtnFilet.Location = new System.Drawing.Point(9, 19);
            this.RBtnFilet.Name = "RBtnFilet";
            this.RBtnFilet.Size = new System.Drawing.Size(44, 17);
            this.RBtnFilet.TabIndex = 6;
            this.RBtnFilet.TabStop = true;
            this.RBtnFilet.Text = "Filet";
            this.RBtnFilet.UseVisualStyleBackColor = true;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(772, 121);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(52, 13);
            this.LblQuantity.TabIndex = 5;
            this.LblQuantity.Text = "Cantidad:";
            // 
            // UDQuantity
            // 
            this.UDQuantity.Location = new System.Drawing.Point(775, 137);
            this.UDQuantity.Name = "UDQuantity";
            this.UDQuantity.Size = new System.Drawing.Size(124, 20);
            this.UDQuantity.TabIndex = 4;
            this.UDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnAddLine
            // 
            this.BtnAddLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddLine.Location = new System.Drawing.Point(775, 163);
            this.BtnAddLine.Name = "BtnAddLine";
            this.BtnAddLine.Size = new System.Drawing.Size(124, 42);
            this.BtnAddLine.TabIndex = 3;
            this.BtnAddLine.Text = "Agregar a factura";
            this.BtnAddLine.UseVisualStyleBackColor = true;
            this.BtnAddLine.Click += new System.EventHandler(this.BtnAddLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CkbConfirmed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CbPaymentMethod);
            this.groupBox2.Controls.Add(this.BtnBilling);
            this.groupBox2.Controls.Add(this.LblAmount);
            this.groupBox2.Controls.Add(this.LblTax);
            this.groupBox2.Controls.Add(this.LblTotal);
            this.groupBox2.Controls.Add(this.BtnDelLine);
            this.groupBox2.Controls.Add(this.DGVLines);
            this.groupBox2.Location = new System.Drawing.Point(13, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(911, 247);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura actual";
            // 
            // CkbConfirmed
            // 
            this.CkbConfirmed.AutoSize = true;
            this.CkbConfirmed.Location = new System.Drawing.Point(781, 77);
            this.CkbConfirmed.Name = "CkbConfirmed";
            this.CkbConfirmed.Size = new System.Drawing.Size(107, 17);
            this.CkbConfirmed.TabIndex = 8;
            this.CkbConfirmed.Text = "Pago Confirmado";
            this.CkbConfirmed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Método de pago:";
            // 
            // CbPaymentMethod
            // 
            this.CbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPaymentMethod.FormattingEnabled = true;
            this.CbPaymentMethod.Location = new System.Drawing.Point(772, 39);
            this.CbPaymentMethod.Name = "CbPaymentMethod";
            this.CbPaymentMethod.Size = new System.Drawing.Size(124, 21);
            this.CbPaymentMethod.TabIndex = 6;
            this.CbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.CbPaymentMethod_SelectedIndexChanged);
            // 
            // BtnBilling
            // 
            this.BtnBilling.Location = new System.Drawing.Point(772, 192);
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
            this.LblAmount.Location = new System.Drawing.Point(408, 195);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(155, 29);
            this.LblAmount.TabIndex = 4;
            this.LblAmount.Text = "Subtotal: ₡0";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTax.Location = new System.Drawing.Point(180, 195);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(179, 29);
            this.LblTax.TabIndex = 3;
            this.LblTax.Text = "Impuestos: ₡0";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(19, 195);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(119, 29);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total: ₡0";
            // 
            // BtnDelLine
            // 
            this.BtnDelLine.Location = new System.Drawing.Point(772, 115);
            this.BtnDelLine.Name = "BtnDelLine";
            this.BtnDelLine.Size = new System.Drawing.Size(124, 42);
            this.BtnDelLine.TabIndex = 1;
            this.BtnDelLine.Text = "Eliminar línea";
            this.BtnDelLine.UseVisualStyleBackColor = true;
            // 
            // DGVLines
            // 
            this.DGVLines.AllowUserToAddRows = false;
            this.DGVLines.AllowUserToDeleteRows = false;
            this.DGVLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLines.Location = new System.Drawing.Point(24, 19);
            this.DGVLines.Name = "DGVLines";
            this.DGVLines.ReadOnly = true;
            this.DGVLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLines.Size = new System.Drawing.Size(733, 150);
            this.DGVLines.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(90, 15);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(145, 20);
            this.LblCustomerName.TabIndex = 5;
            this.LblCustomerName.Text = "Cliente particular";
            // 
            // CBTax
            // 
            this.CBTax.AutoSize = true;
            this.CBTax.Checked = true;
            this.CBTax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBTax.Location = new System.Drawing.Point(822, 25);
            this.CBTax.Name = "CBTax";
            this.CBTax.Size = new System.Drawing.Size(102, 17);
            this.CBTax.TabIndex = 6;
            this.CBTax.Text = "Cobrar impuesto";
            this.CBTax.UseVisualStyleBackColor = true;
            // 
            // BtnSelectCustomer
            // 
            this.BtnSelectCustomer.Location = new System.Drawing.Point(94, 38);
            this.BtnSelectCustomer.Name = "BtnSelectCustomer";
            this.BtnSelectCustomer.Size = new System.Drawing.Size(130, 23);
            this.BtnSelectCustomer.TabIndex = 7;
            this.BtnSelectCustomer.Text = "Seleccionar cliente";
            this.BtnSelectCustomer.UseVisualStyleBackColor = true;
            this.BtnSelectCustomer.Click += new System.EventHandler(this.BtnSelectCustomer_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(633, 12);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(170, 46);
            this.TxtNotes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Notas de venta:";
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.BtnSelectCustomer);
            this.Controls.Add(this.CBTax);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBilling";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.Shown += new System.EventHandler(this.FrmBilling_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbStockType.ResumeLayout(false);
            this.GbStockType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox GbStockType;
        private System.Windows.Forms.RadioButton RBtnChopped;
        private System.Windows.Forms.RadioButton RBtnFilet;
    }
}