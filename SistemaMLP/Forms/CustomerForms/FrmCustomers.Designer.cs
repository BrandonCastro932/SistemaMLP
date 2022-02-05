namespace SistemaMLP.Forms.CustomerForms
{
    partial class FrmCustomers
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
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.AllowUserToAddRows = false;
            this.DGVCustomers.AllowUserToDeleteRows = false;
            this.DGVCustomers.AllowUserToResizeColumns = false;
            this.DGVCustomers.AllowUserToResizeRows = false;
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Location = new System.Drawing.Point(12, 52);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.ReadOnly = true;
            this.DGVCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustomers.Size = new System.Drawing.Size(1018, 341);
            this.DGVCustomers.TabIndex = 0;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellClick);
            this.DGVCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(348, 22);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(420, 20);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(108, 399);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(126, 46);
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "Crear cliente";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(478, 399);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(126, 46);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Modificar cliente";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(838, 399);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(126, 46);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Eliminar cliente";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Registro de clientes";
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.Shown += new System.EventHandler(this.FrmCustomers_Shown);
            this.Click += new System.EventHandler(this.FrmCustomers_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
    }
}