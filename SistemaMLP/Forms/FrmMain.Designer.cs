namespace SistemaMLP.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblCredito = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUsername,
            this.LblCredito});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblUsername
            // 
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(106, 17);
            this.LblUsername.Text = "Usuario: Username";
            // 
            // LblCredito
            // 
            this.LblCredito.Name = "LblCredito";
            this.LblCredito.Size = new System.Drawing.Size(100, 17);
            this.LblCredito.Text = "Total en crédito: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.créditosToolStripMenuItem,
            this.notificacionesToolStripMenuItem,
            this.bitácoraToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeProductoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // entradaDeProductoToolStripMenuItem
            // 
            this.entradaDeProductoToolStripMenuItem.Name = "entradaDeProductoToolStripMenuItem";
            this.entradaDeProductoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.entradaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.entradaDeProductoToolStripMenuItem.Text = "Entrada de producto";
            this.entradaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProductoToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem,
            this.verFacturasToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.facturarToolStripMenuItem.Text = "Facturar";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.verFacturasToolStripMenuItem.Text = "Ver facturas";
            this.verFacturasToolStripMenuItem.Click += new System.EventHandler(this.verFacturasToolStripMenuItem_Click);
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            this.notificacionesToolStripMenuItem.Click += new System.EventHandler(this.notificacionesToolStripMenuItem_Click);
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            this.bitácoraToolStripMenuItem.Click += new System.EventHandler(this.bitácoraToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click_1);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mariscos La Puebla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel LblCredito;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsername;
    }
}