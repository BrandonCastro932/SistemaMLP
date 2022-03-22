namespace SistemaMLP.Forms.ProductForms
{
    partial class FrmProductCU
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
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.TxtBarCode = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbStockType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnDetail = new System.Windows.Forms.Button();
            this.TxtStockTypeDetail = new System.Windows.Forms.TextBox();
            this.LblStockTypeDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(19, 185);
            this.TxtUnitPrice.MaxLength = 255;
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.ShortcutsEnabled = false;
            this.TxtUnitPrice.Size = new System.Drawing.Size(111, 20);
            this.TxtUnitPrice.TabIndex = 27;
            this.TxtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnitPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Precio Unitario:";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(49, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(207, 25);
            this.LblTitle.TabIndex = 25;
            this.LblTitle.Text = "Registrar producto";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(19, 318);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 36);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.Location = new System.Drawing.Point(186, 318);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(94, 36);
            this.BtnAccept.TabIndex = 23;
            this.BtnAccept.Text = "Registrar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // TxtBarCode
            // 
            this.TxtBarCode.Location = new System.Drawing.Point(19, 131);
            this.TxtBarCode.MaxLength = 255;
            this.TxtBarCode.Name = "TxtBarCode";
            this.TxtBarCode.Size = new System.Drawing.Size(261, 20);
            this.TxtBarCode.TabIndex = 20;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(19, 79);
            this.TxtProductName.MaxLength = 255;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(261, 20);
            this.TxtProductName.TabIndex = 19;
            this.TxtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProductName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo de barras (Opcional):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre del producto:";
            // 
            // TxtTax
            // 
            this.TxtTax.Location = new System.Drawing.Point(169, 185);
            this.TxtTax.MaxLength = 255;
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.ShortcutsEnabled = false;
            this.TxtTax.Size = new System.Drawing.Size(111, 20);
            this.TxtTax.TabIndex = 31;
            this.TxtTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTax_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Impuesto:";
            // 
            // CbStockType
            // 
            this.CbStockType.FormattingEnabled = true;
            this.CbStockType.Location = new System.Drawing.Point(19, 240);
            this.CbStockType.Name = "CbStockType";
            this.CbStockType.Size = new System.Drawing.Size(111, 21);
            this.CbStockType.TabIndex = 32;
            this.CbStockType.SelectedIndexChanged += new System.EventHandler(this.CbStockType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tipo de stock:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(169, 240);
            this.TxtStock.MaxLength = 255;
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ShortcutsEnabled = false;
            this.TxtStock.Size = new System.Drawing.Size(111, 20);
            this.TxtStock.TabIndex = 35;
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(166, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Existencias:";
            // 
            // BtnDetail
            // 
            this.BtnDetail.Location = new System.Drawing.Point(186, 266);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(75, 23);
            this.BtnDetail.TabIndex = 36;
            this.BtnDetail.Text = "Detallar";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // TxtStockTypeDetail
            // 
            this.TxtStockTypeDetail.Location = new System.Drawing.Point(19, 283);
            this.TxtStockTypeDetail.Name = "TxtStockTypeDetail";
            this.TxtStockTypeDetail.Size = new System.Drawing.Size(111, 20);
            this.TxtStockTypeDetail.TabIndex = 38;
            this.TxtStockTypeDetail.Visible = false;
            this.TxtStockTypeDetail.TextChanged += new System.EventHandler(this.TxtStockTypeDetail_TextChanged);
            this.TxtStockTypeDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockTypeDetail_KeyPress);
            // 
            // LblStockTypeDetail
            // 
            this.LblStockTypeDetail.AutoSize = true;
            this.LblStockTypeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStockTypeDetail.Location = new System.Drawing.Point(16, 264);
            this.LblStockTypeDetail.Name = "LblStockTypeDetail";
            this.LblStockTypeDetail.Size = new System.Drawing.Size(69, 16);
            this.LblStockTypeDetail.TabIndex = 39;
            this.LblStockTypeDetail.Text = "Peso de:";
            this.LblStockTypeDetail.Visible = false;
            // 
            // FrmProductCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 370);
            this.Controls.Add(this.LblStockTypeDetail);
            this.Controls.Add(this.TxtStockTypeDetail);
            this.Controls.Add(this.BtnDetail);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbStockType);
            this.Controls.Add(this.TxtTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.TxtBarCode);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de producto";
            this.Load += new System.EventHandler(this.FrmProductCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.TextBox TxtBarCode;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbStockType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnDetail;
        private System.Windows.Forms.TextBox TxtStockTypeDetail;
        private System.Windows.Forms.Label LblStockTypeDetail;
    }
}