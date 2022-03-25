namespace SistemaMLP.Forms.UserForms
{
    partial class FrmUsersCU
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
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPin = new System.Windows.Forms.TextBox();
            this.LblPin = new System.Windows.Forms.Label();
            this.LblPin2 = new System.Windows.Forms.Label();
            this.TxtPin2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 159);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 39);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(191, 159);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(82, 39);
            this.BtnRegister.TabIndex = 1;
            this.BtnRegister.Text = "Registrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(52, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(173, 24);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Registro de usuario";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(2, 51);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(106, 16);
            this.LblUsername.TabIndex = 3;
            this.LblUsername.Text = "Nombre usuario:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(114, 50);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(139, 20);
            this.TxtUsername.TabIndex = 4;
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(114, 89);
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.Size = new System.Drawing.Size(139, 20);
            this.TxtPin.TabIndex = 5;
            // 
            // LblPin
            // 
            this.LblPin.AutoSize = true;
            this.LblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPin.Location = new System.Drawing.Point(42, 91);
            this.LblPin.Name = "LblPin";
            this.LblPin.Size = new System.Drawing.Size(29, 16);
            this.LblPin.TabIndex = 6;
            this.LblPin.Text = "Pin:";
            this.LblPin.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblPin2
            // 
            this.LblPin2.AutoSize = true;
            this.LblPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPin2.Location = new System.Drawing.Point(20, 126);
            this.LblPin2.Name = "LblPin2";
            this.LblPin2.Size = new System.Drawing.Size(88, 16);
            this.LblPin2.TabIndex = 8;
            this.LblPin2.Text = "Confirmar pin:";
            // 
            // TxtPin2
            // 
            this.TxtPin2.Location = new System.Drawing.Point(114, 125);
            this.TxtPin2.Name = "TxtPin2";
            this.TxtPin2.Size = new System.Drawing.Size(139, 20);
            this.TxtPin2.TabIndex = 7;
            // 
            // FrmUsersCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(285, 210);
            this.Controls.Add(this.LblPin2);
            this.Controls.Add(this.TxtPin2);
            this.Controls.Add(this.LblPin);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUsersCU";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.FrmUsersCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.Label LblPin;
        private System.Windows.Forms.Label LblPin2;
        private System.Windows.Forms.TextBox TxtPin2;
    }
}