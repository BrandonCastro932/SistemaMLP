namespace SistemaMLP.Forms.CreditForms
{
    partial class FrmCreditPayment
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblReceiptCode = new System.Windows.Forms.Label();
            this.LblFullname = new System.Windows.Forms.Label();
            this.LblRegDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblNextAmount = new System.Windows.Forms.Label();
            this.LblPreviousAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblActualAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPayAll = new System.Windows.Forms.Button();
            this.DGVPayments = new System.Windows.Forms.DataGridView();
            this.LblPayments = new System.Windows.Forms.Label();
            this.LblReceiptTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(13, 421);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 37);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(278, 421);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(110, 37);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Abonar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abonar crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "# Factura:";
            // 
            // LblReceiptCode
            // 
            this.LblReceiptCode.AutoSize = true;
            this.LblReceiptCode.Location = new System.Drawing.Point(91, 50);
            this.LblReceiptCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblReceiptCode.Name = "LblReceiptCode";
            this.LblReceiptCode.Size = new System.Drawing.Size(133, 16);
            this.LblReceiptCode.TabIndex = 4;
            this.LblReceiptCode.Text = "##################";
            // 
            // LblFullname
            // 
            this.LblFullname.AutoSize = true;
            this.LblFullname.Location = new System.Drawing.Point(75, 80);
            this.LblFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFullname.Name = "LblFullname";
            this.LblFullname.Size = new System.Drawing.Size(157, 16);
            this.LblFullname.TabIndex = 5;
            this.LblFullname.Text = "Nombre completo cliente";
            // 
            // LblRegDate
            // 
            this.LblRegDate.AutoSize = true;
            this.LblRegDate.Location = new System.Drawing.Point(148, 112);
            this.LblRegDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegDate.Name = "LblRegDate";
            this.LblRegDate.Size = new System.Drawing.Size(94, 16);
            this.LblRegDate.TabIndex = 6;
            this.LblRegDate.Text = "Fecha compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha de compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Monto siguiente estimado:";
            this.label8.Visible = false;
            // 
            // LblNextAmount
            // 
            this.LblNextAmount.AutoSize = true;
            this.LblNextAmount.Location = new System.Drawing.Point(205, 217);
            this.LblNextAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNextAmount.Name = "LblNextAmount";
            this.LblNextAmount.Size = new System.Drawing.Size(101, 16);
            this.LblNextAmount.TabIndex = 10;
            this.LblNextAmount.Text = "Monto siguiente";
            this.LblNextAmount.Visible = false;
            // 
            // LblPreviousAmount
            // 
            this.LblPreviousAmount.AutoSize = true;
            this.LblPreviousAmount.Location = new System.Drawing.Point(225, 171);
            this.LblPreviousAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPreviousAmount.Name = "LblPreviousAmount";
            this.LblPreviousAmount.Size = new System.Drawing.Size(85, 16);
            this.LblPreviousAmount.TabIndex = 11;
            this.LblPreviousAmount.Text = "Monto previo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Monto previo al último abono:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // LblActualAmount
            // 
            this.LblActualAmount.AutoSize = true;
            this.LblActualAmount.Location = new System.Drawing.Point(175, 200);
            this.LblActualAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblActualAmount.Name = "LblActualAmount";
            this.LblActualAmount.Size = new System.Drawing.Size(83, 16);
            this.LblActualAmount.TabIndex = 13;
            this.LblActualAmount.Text = "Monto actual";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 200);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Monto actual a pagar:";
            // 
            // TxtPayment
            // 
            this.TxtPayment.Location = new System.Drawing.Point(62, 374);
            this.TxtPayment.MaxLength = 18;
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(135, 22);
            this.TxtPayment.TabIndex = 15;
            this.TxtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPayment_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Abono:";
            // 
            // BtnPayAll
            // 
            this.BtnPayAll.Location = new System.Drawing.Point(208, 369);
            this.BtnPayAll.Name = "BtnPayAll";
            this.BtnPayAll.Size = new System.Drawing.Size(98, 32);
            this.BtnPayAll.TabIndex = 17;
            this.BtnPayAll.Text = "Pagar todo";
            this.BtnPayAll.UseVisualStyleBackColor = true;
            // 
            // DGVPayments
            // 
            this.DGVPayments.AllowUserToAddRows = false;
            this.DGVPayments.AllowUserToDeleteRows = false;
            this.DGVPayments.AllowUserToResizeColumns = false;
            this.DGVPayments.AllowUserToResizeRows = false;
            this.DGVPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPayments.Location = new System.Drawing.Point(12, 254);
            this.DGVPayments.Name = "DGVPayments";
            this.DGVPayments.RowHeadersVisible = false;
            this.DGVPayments.Size = new System.Drawing.Size(377, 102);
            this.DGVPayments.TabIndex = 18;
            // 
            // LblPayments
            // 
            this.LblPayments.AutoSize = true;
            this.LblPayments.Location = new System.Drawing.Point(9, 235);
            this.LblPayments.Name = "LblPayments";
            this.LblPayments.Size = new System.Drawing.Size(116, 16);
            this.LblPayments.TabIndex = 19;
            this.LblPayments.Text = "Pagos realizados:";
            // 
            // LblReceiptTotal
            // 
            this.LblReceiptTotal.AutoSize = true;
            this.LblReceiptTotal.Location = new System.Drawing.Point(166, 142);
            this.LblReceiptTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblReceiptTotal.Name = "LblReceiptTotal";
            this.LblReceiptTotal.Size = new System.Drawing.Size(95, 16);
            this.LblReceiptTotal.TabIndex = 6;
            this.LblReceiptTotal.Text = "Precio compra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Precio de la compra:";
            // 
            // FrmCreditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(401, 476);
            this.Controls.Add(this.LblPayments);
            this.Controls.Add(this.DGVPayments);
            this.Controls.Add(this.BtnPayAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LblActualAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblPreviousAmount);
            this.Controls.Add(this.LblNextAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblReceiptTotal);
            this.Controls.Add(this.LblRegDate);
            this.Controls.Add(this.LblFullname);
            this.Controls.Add(this.LblReceiptCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCreditPayment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonar";
            this.Load += new System.EventHandler(this.FrmCreditPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblReceiptCode;
        private System.Windows.Forms.Label LblFullname;
        private System.Windows.Forms.Label LblRegDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblNextAmount;
        private System.Windows.Forms.Label LblPreviousAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblActualAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPayAll;
        private System.Windows.Forms.DataGridView DGVPayments;
        private System.Windows.Forms.Label LblPayments;
        private System.Windows.Forms.Label LblReceiptTotal;
        private System.Windows.Forms.Label label10;
    }
}