namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmfactura = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnotacredito = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnotacargo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnotaventa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegmovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmordencompra = new System.Windows.Forms.ToolStripMenuItem();
            this.genOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmreporteventas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmreporteproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.AutoSize = false;
            this.inicioToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSeguridad,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmSalir});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inicioToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.home_48x48_32;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(94, 40);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // tsmSeguridad
            // 
            this.tsmSeguridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSeguridad.Image = global::CapaPresentacion.Properties.Resources.Security_1_24x24_32;
            this.tsmSeguridad.Name = "tsmSeguridad";
            this.tsmSeguridad.Size = new System.Drawing.Size(131, 22);
            this.tsmSeguridad.Text = "Seguridad";
            this.tsmSeguridad.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.users_16x16_32;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.producto_16x16;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(131, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.tsmRegmovimientos,
            this.tsmordencompra});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ventasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.app_edit_32x32_32;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(107, 40);
            this.ventasToolStripMenuItem.Text = "Movimientos";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaToolStripMenuItem,
            this.tsmfactura,
            this.tsmnotacredito,
            this.tsmnotacargo,
            this.tsmnotaventa});
            this.ventasToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasToolStripMenuItem1.Image = global::CapaPresentacion.Properties.Resources.Shopping_cart_24x24;
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // boletaToolStripMenuItem
            // 
            this.boletaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boletaToolStripMenuItem.Name = "boletaToolStripMenuItem";
            this.boletaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.boletaToolStripMenuItem.Text = "Boleta";
            this.boletaToolStripMenuItem.Click += new System.EventHandler(this.boletaToolStripMenuItem_Click);
            // 
            // tsmfactura
            // 
            this.tsmfactura.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmfactura.Name = "tsmfactura";
            this.tsmfactura.Size = new System.Drawing.Size(160, 22);
            this.tsmfactura.Text = "Factura";
            // 
            // tsmnotacredito
            // 
            this.tsmnotacredito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmnotacredito.Name = "tsmnotacredito";
            this.tsmnotacredito.Size = new System.Drawing.Size(160, 22);
            this.tsmnotacredito.Text = "Nota de Credito";
            // 
            // tsmnotacargo
            // 
            this.tsmnotacargo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmnotacargo.Name = "tsmnotacargo";
            this.tsmnotacargo.Size = new System.Drawing.Size(160, 22);
            this.tsmnotacargo.Text = "Nota de Cargo";
            // 
            // tsmnotaventa
            // 
            this.tsmnotaventa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmnotaventa.Name = "tsmnotaventa";
            this.tsmnotaventa.Size = new System.Drawing.Size(160, 22);
            this.tsmnotaventa.Text = "Nota de venta";
            this.tsmnotaventa.Click += new System.EventHandler(this.notaDeVentaToolStripMenuItem_Click);
            // 
            // tsmRegmovimientos
            // 
            this.tsmRegmovimientos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmRegmovimientos.Name = "tsmRegmovimientos";
            this.tsmRegmovimientos.Size = new System.Drawing.Size(172, 22);
            this.tsmRegmovimientos.Text = "Reg. Movimientos";
            // 
            // tsmordencompra
            // 
            this.tsmordencompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genOrdenDeCompraToolStripMenuItem});
            this.tsmordencompra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmordencompra.Name = "tsmordencompra";
            this.tsmordencompra.Size = new System.Drawing.Size(172, 22);
            this.tsmordencompra.Text = "Orden de compra";
            // 
            // genOrdenDeCompraToolStripMenuItem
            // 
            this.genOrdenDeCompraToolStripMenuItem.Name = "genOrdenDeCompraToolStripMenuItem";
            this.genOrdenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.genOrdenDeCompraToolStripMenuItem.Text = "Generar OC";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConsultaProd,
            this.tsmConsultaVenta});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.consultasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Pie_Diagram_32x32_32;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(92, 40);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // tsmConsultaProd
            // 
            this.tsmConsultaProd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmConsultaProd.Name = "tsmConsultaProd";
            this.tsmConsultaProd.Size = new System.Drawing.Size(130, 22);
            this.tsmConsultaProd.Text = "Productos";
            this.tsmConsultaProd.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // tsmConsultaVenta
            // 
            this.tsmConsultaVenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmConsultaVenta.Name = "tsmConsultaVenta";
            this.tsmConsultaVenta.Size = new System.Drawing.Size(130, 22);
            this.tsmConsultaVenta.Text = "Ventas";
            this.tsmConsultaVenta.Click += new System.EventHandler(this.ventasToolStripMenuItem2_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmreporteventas,
            this.tsmreporteproductos});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.chart_accept_32x32_32;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(87, 40);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tsmreporteventas
            // 
            this.tsmreporteventas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmreporteventas.Name = "tsmreporteventas";
            this.tsmreporteventas.Size = new System.Drawing.Size(145, 22);
            this.tsmreporteventas.Text = "R. Ventas";
            // 
            // tsmreporteproductos
            // 
            this.tsmreporteproductos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmreporteproductos.Name = "tsmreporteproductos";
            this.tsmreporteproductos.Size = new System.Drawing.Size(145, 22);
            this.tsmreporteproductos.Text = "R. Productos";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.acercaDeToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.user_comment_32x32_32;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(70, 40);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(0, 436);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(822, 29);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(822, 465);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSeguridad;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmfactura;
        private System.Windows.Forms.ToolStripMenuItem tsmnotacredito;
        private System.Windows.Forms.ToolStripMenuItem tsmnotacargo;
        private System.Windows.Forms.ToolStripMenuItem tsmnotaventa;
        private System.Windows.Forms.ToolStripMenuItem tsmRegmovimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmordencompra;
        private System.Windows.Forms.ToolStripMenuItem genOrdenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaProd;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaVenta;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmreporteventas;
        private System.Windows.Forms.ToolStripMenuItem tsmreporteproductos;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.Label lblUsuario;
    }
}