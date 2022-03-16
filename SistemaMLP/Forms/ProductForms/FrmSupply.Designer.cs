namespace SistemaMLP.Forms.ProductForms
{
    partial class FrmSupply
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDetail = new System.Windows.Forms.Button();
            this.RbSum = new System.Windows.Forms.RadioButton();
            this.GbActions = new System.Windows.Forms.GroupBox();
            this.RbCh = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            this.GbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(67, 51);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(274, 20);
            this.TxtSearch.TabIndex = 11;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVProduct
            // 
            this.DGVProduct.AllowUserToAddRows = false;
            this.DGVProduct.AllowUserToDeleteRows = false;
            this.DGVProduct.AllowUserToResizeColumns = false;
            this.DGVProduct.AllowUserToResizeRows = false;
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Location = new System.Drawing.Point(12, 77);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.ReadOnly = true;
            this.DGVProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProduct.Size = new System.Drawing.Size(329, 300);
            this.DGVProduct.TabIndex = 10;
            this.DGVProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProduct_CellClick);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.Location = new System.Drawing.Point(250, 472);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(91, 39);
            this.BtnAccept.TabIndex = 13;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 472);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(86, 39);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDetail
            // 
            this.BtnDetail.Enabled = false;
            this.BtnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetail.Location = new System.Drawing.Point(12, 435);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(75, 23);
            this.BtnDetail.TabIndex = 37;
            this.BtnDetail.Text = "Detallar";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // RbSum
            // 
            this.RbSum.AutoSize = true;
            this.RbSum.Checked = true;
            this.RbSum.Location = new System.Drawing.Point(6, 19);
            this.RbSum.Name = "RbSum";
            this.RbSum.Size = new System.Drawing.Size(139, 20);
            this.RbSum.TabIndex = 38;
            this.RbSum.TabStop = true;
            this.RbSum.Text = "Sumar al inventario";
            this.RbSum.UseVisualStyleBackColor = true;
            // 
            // GbActions
            // 
            this.GbActions.Controls.Add(this.RbCh);
            this.GbActions.Controls.Add(this.RbSum);
            this.GbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbActions.Location = new System.Drawing.Point(185, 390);
            this.GbActions.Name = "GbActions";
            this.GbActions.Size = new System.Drawing.Size(156, 66);
            this.GbActions.TabIndex = 39;
            this.GbActions.TabStop = false;
            this.GbActions.Text = "Acciones";
            // 
            // RbCh
            // 
            this.RbCh.AutoSize = true;
            this.RbCh.Location = new System.Drawing.Point(6, 42);
            this.RbCh.Name = "RbCh";
            this.RbCh.Size = new System.Drawing.Size(146, 20);
            this.RbCh.TabIndex = 39;
            this.RbCh.Text = "Sustituir el inventario";
            this.RbCh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Entrada de producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Entrada de:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(12, 409);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(135, 20);
            this.TxtStock.TabIndex = 42;
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // FrmSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 518);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GbActions);
            this.Controls.Add(this.BtnDetail);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSupply";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de producto";
            this.Load += new System.EventHandler(this.FrmSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            this.GbActions.ResumeLayout(false);
            this.GbActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGVProduct;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDetail;
        private System.Windows.Forms.RadioButton RbSum;
        private System.Windows.Forms.GroupBox GbActions;
        private System.Windows.Forms.RadioButton RbCh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStock;
    }
}