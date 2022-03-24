namespace SistemaMLP.Forms.CreditForms
{
    partial class FrmCreditReceipts
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
            this.label2 = new System.Windows.Forms.Label();
            this.DGVCredits = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCreditPayment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // DGVCredits
            // 
            this.DGVCredits.AllowUserToAddRows = false;
            this.DGVCredits.AllowUserToDeleteRows = false;
            this.DGVCredits.AllowUserToOrderColumns = true;
            this.DGVCredits.AllowUserToResizeColumns = false;
            this.DGVCredits.AllowUserToResizeRows = false;
            this.DGVCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCredits.Location = new System.Drawing.Point(16, 91);
            this.DGVCredits.MultiSelect = false;
            this.DGVCredits.Name = "DGVCredits";
            this.DGVCredits.ReadOnly = true;
            this.DGVCredits.RowHeadersVisible = false;
            this.DGVCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCredits.Size = new System.Drawing.Size(816, 344);
            this.DGVCredits.TabIndex = 2;
            this.DGVCredits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCredits_CellClick);
            this.DGVCredits.DoubleClick += new System.EventHandler(this.DGVCredits_DoubleClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(72, 54);
            this.TxtSearch.MaxLength = 50;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(511, 22);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(750, 45);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 40);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCreditPayment
            // 
            this.BtnCreditPayment.Enabled = false;
            this.BtnCreditPayment.Location = new System.Drawing.Point(662, 45);
            this.BtnCreditPayment.Name = "BtnCreditPayment";
            this.BtnCreditPayment.Size = new System.Drawing.Size(82, 40);
            this.BtnCreditPayment.TabIndex = 5;
            this.BtnCreditPayment.Text = "Abonar";
            this.BtnCreditPayment.UseVisualStyleBackColor = true;
            this.BtnCreditPayment.Click += new System.EventHandler(this.BtnCreditPayment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMLP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCreditReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCreditPayment);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVCredits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCreditReceipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos";
            this.Load += new System.EventHandler(this.FrmCreditReceipts_Load);
            this.Click += new System.EventHandler(this.FrmCreditReceipts_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVCredits;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCreditPayment;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}