namespace CapaPresentacion.Vendedor
{
    partial class frmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedor));
            btnSalir = new Button();
            menuStrip1 = new MenuStrip();
            icoRegistro = new FontAwesome.Sharp.IconMenuItem();
            icoFactura = new FontAwesome.Sharp.IconMenuItem();
            verDetalleToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            darDeAltaToolStripMenuItem = new ToolStripMenuItem();
            darDeBajaToolStripMenuItem = new ToolStripMenuItem();
            verClientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            verDisponiblesToolStripMenuItem = new ToolStripMenuItem();
            notificarToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnVolver = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(682, 391);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 27);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { icoRegistro, clientesToolStripMenuItem, productosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // icoRegistro
            // 
            icoRegistro.DropDownItems.AddRange(new ToolStripItem[] { icoFactura, verDetalleToolStripMenuItem });
            icoRegistro.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            icoRegistro.IconColor = Color.Black;
            icoRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoRegistro.Name = "icoRegistro";
            icoRegistro.Size = new Size(64, 20);
            icoRegistro.Text = "Venta";
            // 
            // icoFactura
            // 
            icoFactura.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            icoFactura.IconColor = Color.Black;
            icoFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoFactura.Name = "icoFactura";
            icoFactura.Size = new Size(180, 22);
            icoFactura.Text = "Emitir Factura";
            icoFactura.Click += icoFactura_Click;
            // 
            // verDetalleToolStripMenuItem
            // 
            verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            verDetalleToolStripMenuItem.Size = new Size(180, 22);
            verDetalleToolStripMenuItem.Text = "ver detalle";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darDeAltaToolStripMenuItem, darDeBajaToolStripMenuItem, verClientesToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // darDeAltaToolStripMenuItem
            // 
            darDeAltaToolStripMenuItem.Name = "darDeAltaToolStripMenuItem";
            darDeAltaToolStripMenuItem.Size = new Size(133, 22);
            darDeAltaToolStripMenuItem.Text = "Dar de alta";
            // 
            // darDeBajaToolStripMenuItem
            // 
            darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            darDeBajaToolStripMenuItem.Size = new Size(133, 22);
            darDeBajaToolStripMenuItem.Text = "dar de baja";
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(133, 22);
            verClientesToolStripMenuItem.Text = "ver clientes";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verDisponiblesToolStripMenuItem, notificarToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(73, 20);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // verDisponiblesToolStripMenuItem
            // 
            verDisponiblesToolStripMenuItem.Name = "verDisponiblesToolStripMenuItem";
            verDisponiblesToolStripMenuItem.Size = new Size(153, 22);
            verDisponiblesToolStripMenuItem.Text = "ver disponibles";
            // 
            // notificarToolStripMenuItem
            // 
            notificarToolStripMenuItem.Name = "notificarToolStripMenuItem";
            notificarToolStripMenuItem.Size = new Size(153, 22);
            notificarToolStripMenuItem.Text = "notificar";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVolver);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 426);
            panel1.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(713, 391);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Vendedor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem icoRegistro;
        private FontAwesome.Sharp.IconMenuItem icoFactura;
        private Panel panel1;
        private Button btnVolver;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem verDisponiblesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem darDeAltaToolStripMenuItem;
        private ToolStripMenuItem darDeBajaToolStripMenuItem;
        private ToolStripMenuItem verClientesToolStripMenuItem;
        private ToolStripMenuItem notificarToolStripMenuItem;
        private ToolStripMenuItem verDetalleToolStripMenuItem;
    }
}