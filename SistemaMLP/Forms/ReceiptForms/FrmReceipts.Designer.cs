namespace SistemaMLP.Forms.ReceiptForms
{
    partial class FrmReceipts
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
            this.components = new System.ComponentModel.Container();
            this.DGVReceipts = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TtSearch = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReceipts
            // 
            this.DGVReceipts.AllowUserToAddRows = false;
            this.DGVReceipts.AllowUserToDeleteRows = false;
            this.DGVReceipts.AllowUserToResizeColumns = false;
            this.DGVReceipts.AllowUserToResizeRows = false;
            this.DGVReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReceipts.Location = new System.Drawing.Point(13, 79);
            this.DGVReceipts.Margin = new System.Windows.Forms.Padding(4);
            this.DGVReceipts.MultiSelect = false;
            this.DGVReceipts.Name = "DGVReceipts";
            this.DGVReceipts.ReadOnly = true;
            this.DGVReceipts.RowHeadersVisible = false;
            this.DGVReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVReceipts.Size = new System.Drawing.Size(845, 316);
            this.DGVReceipts.TabIndex = 0;
            this.DGVReceipts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVReceipts_CellClick);
            this.DGVReceipts.DoubleClick += new System.EventHandler(this.DGVReceipts_DoubleClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(13, 403);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(109, 47);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Enabled = false;
            this.BtnAccept.Location = new System.Drawing.Point(130, 403);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(109, 47);
            this.BtnAccept.TabIndex = 2;
            this.BtnAccept.Text = "Ver factura";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(68, 52);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(790, 22);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.MouseHover += new System.EventHandler(this.TxtSearch_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMLP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(765, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DGVReceipts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceipts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FrmReceipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVReceipts;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ToolTip TtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}