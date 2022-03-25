namespace SistemaMLP.Forms.ReceiptForms
{
    partial class FrmReceiptDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPaymentConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTitleReceipt = new System.Windows.Forms.Label();
            this.LblTitlePersonalID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPaymentMethod = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblTitleFullname = new System.Windows.Forms.Label();
            this.LblFullname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblPersonalID = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblReceiptCode = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LblTotalTax = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DGVReceiptDetails = new System.Windows.Forms.DataGridView();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCancel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(523, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPaymentConfirm
            // 
            this.BtnPaymentConfirm.Location = new System.Drawing.Point(317, 165);
            this.BtnPaymentConfirm.Name = "BtnPaymentConfirm";
            this.BtnPaymentConfirm.Size = new System.Drawing.Size(114, 27);
            this.BtnPaymentConfirm.TabIndex = 1;
            this.BtnPaymentConfirm.Text = "Confirmar pago";
            this.BtnPaymentConfirm.UseVisualStyleBackColor = true;
            this.BtnPaymentConfirm.Click += new System.EventHandler(this.BtnPaymentConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factura";
            // 
            // LblTitleReceipt
            // 
            this.LblTitleReceipt.AutoSize = true;
            this.LblTitleReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleReceipt.Location = new System.Drawing.Point(37, 69);
            this.LblTitleReceipt.Name = "LblTitleReceipt";
            this.LblTitleReceipt.Size = new System.Drawing.Size(84, 18);
            this.LblTitleReceipt.TabIndex = 3;
            this.LblTitleReceipt.Text = "# Factura:";
            // 
            // LblTitlePersonalID
            // 
            this.LblTitlePersonalID.AutoSize = true;
            this.LblTitlePersonalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlePersonalID.Location = new System.Drawing.Point(38, 144);
            this.LblTitlePersonalID.Name = "LblTitlePersonalID";
            this.LblTitlePersonalID.Size = new System.Drawing.Size(146, 18);
            this.LblTitlePersonalID.TabIndex = 4;
            this.LblTitlePersonalID.Text = "Cédula del cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Método de pago:";
            // 
            // LblPaymentMethod
            // 
            this.LblPaymentMethod.AutoSize = true;
            this.LblPaymentMethod.Location = new System.Drawing.Point(444, 146);
            this.LblPaymentMethod.Name = "LblPaymentMethod";
            this.LblPaymentMethod.Size = new System.Drawing.Size(105, 16);
            this.LblPaymentMethod.TabIndex = 6;
            this.LblPaymentMethod.Text = "PaymentMethod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha de la compra:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(472, 111);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(36, 16);
            this.LblDate.TabIndex = 8;
            this.LblDate.Text = "Date";
            // 
            // LblTitleFullname
            // 
            this.LblTitleFullname.AutoSize = true;
            this.LblTitleFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleFullname.Location = new System.Drawing.Point(38, 107);
            this.LblTitleFullname.Name = "LblTitleFullname";
            this.LblTitleFullname.Size = new System.Drawing.Size(65, 18);
            this.LblTitleFullname.TabIndex = 9;
            this.LblTitleFullname.Text = "Cliente:";
            // 
            // LblFullname
            // 
            this.LblFullname.AutoSize = true;
            this.LblFullname.Location = new System.Drawing.Point(100, 109);
            this.LblFullname.Name = "LblFullname";
            this.LblFullname.Size = new System.Drawing.Size(48, 16);
            this.LblFullname.TabIndex = 10;
            this.LblFullname.Text = "Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(314, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total sin impuestos:";
            // 
            // LblPersonalID
            // 
            this.LblPersonalID.AutoSize = true;
            this.LblPersonalID.Location = new System.Drawing.Point(178, 146);
            this.LblPersonalID.Name = "LblPersonalID";
            this.LblPersonalID.Size = new System.Drawing.Size(74, 16);
            this.LblPersonalID.TabIndex = 13;
            this.LblPersonalID.Text = "PersonalID";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(380, 71);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(70, 16);
            this.LblUsername.TabIndex = 15;
            this.LblUsername.Text = "Username";
            // 
            // LblReceiptCode
            // 
            this.LblReceiptCode.AutoSize = true;
            this.LblReceiptCode.Location = new System.Drawing.Point(117, 72);
            this.LblReceiptCode.Name = "LblReceiptCode";
            this.LblReceiptCode.Size = new System.Drawing.Size(112, 16);
            this.LblReceiptCode.TabIndex = 16;
            this.LblReceiptCode.Text = "###############";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Detalles de la factura:";
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Location = new System.Drawing.Point(87, 485);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(83, 16);
            this.LblTotalAmount.TabIndex = 18;
            this.LblTotalAmount.Text = "TotalAmount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 483);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "Subtotal:";
            // 
            // LblTotalTax
            // 
            this.LblTotalTax.AutoSize = true;
            this.LblTotalTax.Location = new System.Drawing.Point(102, 445);
            this.LblTotalTax.Name = "LblTotalTax";
            this.LblTotalTax.Size = new System.Drawing.Size(61, 16);
            this.LblTotalTax.TabIndex = 20;
            this.LblTotalTax.Text = "TotalTax";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(172, 405);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(38, 16);
            this.LblTotal.TabIndex = 21;
            this.LblTotal.Text = "Total";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 443);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 18);
            this.label21.TabIndex = 22;
            this.label21.Text = "Impuestos:";
            // 
            // DGVReceiptDetails
            // 
            this.DGVReceiptDetails.AllowUserToAddRows = false;
            this.DGVReceiptDetails.AllowUserToDeleteRows = false;
            this.DGVReceiptDetails.AllowUserToResizeColumns = false;
            this.DGVReceiptDetails.AllowUserToResizeRows = false;
            this.DGVReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReceiptDetails.Location = new System.Drawing.Point(12, 202);
            this.DGVReceiptDetails.MultiSelect = false;
            this.DGVReceiptDetails.Name = "DGVReceiptDetails";
            this.DGVReceiptDetails.ReadOnly = true;
            this.DGVReceiptDetails.RowHeadersVisible = false;
            this.DGVReceiptDetails.Size = new System.Drawing.Size(601, 182);
            this.DGVReceiptDetails.TabIndex = 23;
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(338, 422);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.Size = new System.Drawing.Size(275, 79);
            this.TxtNotes.TabIndex = 24;
            this.TxtNotes.TextChanged += new System.EventHandler(this.TxtNotes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Notas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblCancel
            // 
            this.LblCancel.AutoSize = true;
            this.LblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCancel.ForeColor = System.Drawing.Color.Red;
            this.LblCancel.Location = new System.Drawing.Point(12, 516);
            this.LblCancel.Name = "LblCancel";
            this.LblCancel.Size = new System.Drawing.Size(124, 25);
            this.LblCancel.TabIndex = 26;
            this.LblCancel.Text = "Cancelada";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMLP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReceiptDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.DGVReceiptDetails);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblTotalTax);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.LblTotalAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.LblReceiptCode);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblPersonalID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblFullname);
            this.Controls.Add(this.LblTitleFullname);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPaymentMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTitlePersonalID);
            this.Controls.Add(this.LblTitleReceipt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPaymentConfirm);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceiptDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de factura";
            this.Load += new System.EventHandler(this.FrmReceiptDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPaymentConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTitleReceipt;
        private System.Windows.Forms.Label LblTitlePersonalID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPaymentMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblTitleFullname;
        private System.Windows.Forms.Label LblFullname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblPersonalID;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblReceiptCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LblTotalTax;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView DGVReceiptDetails;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}