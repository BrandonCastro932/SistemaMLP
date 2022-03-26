namespace SistemaMLP.Forms.CustomerForms
{
    partial class FrmProduct
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
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.Cbx_Deleted = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProduct
            // 
            this.DGVProduct.AllowUserToAddRows = false;
            this.DGVProduct.AllowUserToDeleteRows = false;
            this.DGVProduct.AllowUserToResizeColumns = false;
            this.DGVProduct.AllowUserToResizeRows = false;
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Location = new System.Drawing.Point(12, 62);
            this.DGVProduct.MultiSelect = false;
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.ReadOnly = true;
            this.DGVProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProduct.Size = new System.Drawing.Size(1048, 300);
            this.DGVProduct.TabIndex = 0;
            this.DGVProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProduct_CellClick);
            this.DGVProduct.DoubleClick += new System.EventHandler(this.DGVProduct_DoubleClick);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Image = global::SistemaMLP.Properties.Resources.add_icon;
            this.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreate.Location = new System.Drawing.Point(1066, 62);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(112, 46);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Registrar producto";
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = global::SistemaMLP.Properties.Resources.trash_icon;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(1066, 219);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 46);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Eliminar producto";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Image = global::SistemaMLP.Properties.Resources.edit_icon;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(1066, 140);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(112, 46);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Modificar producto";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Cbx_Deleted
            // 
            this.Cbx_Deleted.AutoSize = true;
            this.Cbx_Deleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Deleted.Location = new System.Drawing.Point(788, 22);
            this.Cbx_Deleted.Name = "Cbx_Deleted";
            this.Cbx_Deleted.Size = new System.Drawing.Size(180, 20);
            this.Cbx_Deleted.TabIndex = 11;
            this.Cbx_Deleted.Text = "Ver productos eliminados";
            this.Cbx_Deleted.UseVisualStyleBackColor = true;
            this.Cbx_Deleted.CheckedChanged += new System.EventHandler(this.Cbx_Deleted_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registro de productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(362, 22);
            this.TxtSearch.MaxLength = 50;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(420, 20);
            this.TxtSearch.TabIndex = 8;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMLP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1068, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cbx_Deleted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.DGVProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.Click += new System.EventHandler(this.FrmProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProduct;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.CheckBox Cbx_Deleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}