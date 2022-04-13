
namespace SistemaMLP.Forms.CutTypesForms
{
    partial class FrmCutTypesInputDialog
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TxtCutName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(7, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(220, 16);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Escriba el nombre del corte a crear:";
            // 
            // BtnOk
            // 
            this.BtnOk.Enabled = false;
            this.BtnOk.Location = new System.Drawing.Point(83, 55);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 33);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "Agregar";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtCutName
            // 
            this.TxtCutName.Location = new System.Drawing.Point(15, 28);
            this.TxtCutName.MaxLength = 255;
            this.TxtCutName.Name = "TxtCutName";
            this.TxtCutName.Size = new System.Drawing.Size(212, 21);
            this.TxtCutName.TabIndex = 2;
            this.TxtCutName.TextChanged += new System.EventHandler(this.TxtCutName_TextChanged);
            // 
            // FrmCutTypesInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 97);
            this.Controls.Add(this.TxtCutName);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCutTypesInputDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear corte";
            this.Load += new System.EventHandler(this.FrmCutTypesInputDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCutName;
        public System.Windows.Forms.Label LblTitle;
        public System.Windows.Forms.Button BtnOk;
    }
}