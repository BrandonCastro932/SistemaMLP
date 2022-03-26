namespace SistemaMLP.Forms.NotificationForms
{
    partial class FrmNotification
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
            this.DGVNotifications = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSeen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificaciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGVNotifications
            // 
            this.DGVNotifications.AllowUserToAddRows = false;
            this.DGVNotifications.AllowUserToDeleteRows = false;
            this.DGVNotifications.AllowUserToResizeColumns = false;
            this.DGVNotifications.AllowUserToResizeRows = false;
            this.DGVNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNotifications.Location = new System.Drawing.Point(13, 53);
            this.DGVNotifications.Margin = new System.Windows.Forms.Padding(4);
            this.DGVNotifications.MultiSelect = false;
            this.DGVNotifications.Name = "DGVNotifications";
            this.DGVNotifications.ReadOnly = true;
            this.DGVNotifications.RowHeadersVisible = false;
            this.DGVNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVNotifications.ShowEditingIcon = false;
            this.DGVNotifications.Size = new System.Drawing.Size(554, 185);
            this.DGVNotifications.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(13, 246);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 28);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSeen
            // 
            this.BtnSeen.Location = new System.Drawing.Point(467, 246);
            this.BtnSeen.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSeen.Name = "BtnSeen";
            this.BtnSeen.Size = new System.Drawing.Size(100, 28);
            this.BtnSeen.TabIndex = 4;
            this.BtnSeen.Text = "Leído";
            this.BtnSeen.UseVisualStyleBackColor = true;
            this.BtnSeen.Click += new System.EventHandler(this.BtnSeen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMLP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(580, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSeen);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DGVNotifications);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNotification";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.FrmNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVNotifications;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSeen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}