namespace SistemaMLP.Forms.CustomerForms
{
    partial class FrmCustomersCU
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPersonalID = new System.Windows.Forms.TextBox();
            this.TxtFullname = new System.Windows.Forms.TextBox();
            this.TxtBusinessName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula (Obligatorio):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo (Obligatorio):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del negocio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo electrónico:";
            // 
            // TxtPersonalID
            // 
            this.TxtPersonalID.Location = new System.Drawing.Point(21, 101);
            this.TxtPersonalID.MaxLength = 255;
            this.TxtPersonalID.Name = "TxtPersonalID";
            this.TxtPersonalID.Size = new System.Drawing.Size(261, 20);
            this.TxtPersonalID.TabIndex = 4;
            this.TxtPersonalID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPersonalID_KeyDown);
            // 
            // TxtFullname
            // 
            this.TxtFullname.Location = new System.Drawing.Point(21, 161);
            this.TxtFullname.MaxLength = 255;
            this.TxtFullname.Name = "TxtFullname";
            this.TxtFullname.Size = new System.Drawing.Size(261, 20);
            this.TxtFullname.TabIndex = 5;
            this.TxtFullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFullname_KeyDown);
            // 
            // TxtBusinessName
            // 
            this.TxtBusinessName.Location = new System.Drawing.Point(21, 217);
            this.TxtBusinessName.MaxLength = 255;
            this.TxtBusinessName.Name = "TxtBusinessName";
            this.TxtBusinessName.Size = new System.Drawing.Size(261, 20);
            this.TxtBusinessName.TabIndex = 6;
            this.TxtBusinessName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusinessName_KeyDown);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(21, 270);
            this.TxtEmail.MaxLength = 255;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(261, 20);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.Location = new System.Drawing.Point(188, 331);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(94, 36);
            this.BtnAccept.TabIndex = 8;
            this.BtnAccept.Text = "Crear usuario";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            this.BtnAccept.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnAccept_KeyDown);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(21, 331);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 36);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.BtnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnCancel_KeyDown);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(73, 35);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(155, 25);
            this.LblTitle.TabIndex = 10;
            this.LblTitle.Text = "Crear usuario";
            // 
            // FrmCustomersCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 395);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtBusinessName);
            this.Controls.Add(this.TxtFullname);
            this.Controls.Add(this.TxtPersonalID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomersCU";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear usuario";
            this.Load += new System.EventHandler(this.FrmCustomersCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPersonalID;
        private System.Windows.Forms.TextBox TxtFullname;
        private System.Windows.Forms.TextBox TxtBusinessName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblTitle;
    }
}