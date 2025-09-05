namespace Administracion
{
    partial class frmVistaAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Agregra = new ContextMenuStrip(components);
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            pntCabecera = new Panel();
            lblNombreRegistro = new Label();
            lblTituloAdm = new Label();
            lblTitulo = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            tsmiListarProd = new ToolStripMenuItem();
            tsmiAltaProd = new ToolStripMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            tsmiAltaUsuario = new ToolStripMenuItem();
            bajaDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            tsmiDetalleVentas = new ToolStripMenuItem();
            tsmiDetalleCompras = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            Agregra.SuspendLayout();
            pntCabecera.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Agregra
            // 
            Agregra.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem });
            Agregra.Name = "Agregra";
            Agregra.Size = new Size(110, 26);
            Agregra.Text = "Agregar";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(109, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // pntCabecera
            // 
            pntCabecera.BackColor = Color.Indigo;
            pntCabecera.Controls.Add(lblNombreRegistro);
            pntCabecera.Controls.Add(lblTituloAdm);
            pntCabecera.Controls.Add(lblTitulo);
            pntCabecera.Controls.Add(iconButton1);
            pntCabecera.Dock = DockStyle.Top;
            pntCabecera.Location = new Point(0, 0);
            pntCabecera.Margin = new Padding(4, 3, 4, 3);
            pntCabecera.Name = "pntCabecera";
            pntCabecera.Size = new Size(960, 70);
            pntCabecera.TabIndex = 9;
            // 
            // lblNombreRegistro
            // 
            lblNombreRegistro.AutoSize = true;
            lblNombreRegistro.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreRegistro.Location = new Point(818, 24);
            lblNombreRegistro.Margin = new Padding(4, 0, 4, 0);
            lblNombreRegistro.Name = "lblNombreRegistro";
            lblNombreRegistro.Size = new Size(129, 19);
            lblNombreRegistro.TabIndex = 12;
            lblNombreRegistro.Text = "nombreCompleto";
            // 
            // lblTituloAdm
            // 
            lblTituloAdm.AutoSize = true;
            lblTituloAdm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAdm.Location = new Point(711, 24);
            lblTituloAdm.Margin = new Padding(4, 0, 4, 0);
            lblTituloAdm.Name = "lblTituloAdm";
            lblTituloAdm.Size = new Size(108, 19);
            lblTituloAdm.TabIndex = 11;
            lblTituloAdm.Text = "Administrador";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Ink Free", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(14, 24);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 29);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Tienda zonafitt";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Indigo;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 22;
            iconButton1.Location = new Point(680, 18);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 33);
            iconButton1.TabIndex = 8;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(192, 192, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2, iconMenuItem3, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 70);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(960, 52);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tsmiListarProd, tsmiAltaProd });
            iconMenuItem1.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem1.ForeColor = Color.White;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconMenuItem1.IconColor = Color.White;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 50;
            iconMenuItem1.Margin = new Padding(2, 10, 0, 0);
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Padding = new Padding(0, 0, 4, 0);
            iconMenuItem1.Size = new Size(94, 38);
            iconMenuItem1.Text = "Productos";
            // 
            // tsmiListarProd
            // 
            tsmiListarProd.Name = "tsmiListarProd";
            tsmiListarProd.Size = new Size(142, 22);
            tsmiListarProd.Text = "Listar";
            tsmiListarProd.Click += tsmiListarProd_Click;
            // 
            // tsmiAltaProd
            // 
            tsmiAltaProd.Name = "tsmiAltaProd";
            tsmiAltaProd.Size = new Size(142, 22);
            tsmiAltaProd.Text = "Dar de alta";
            tsmiAltaProd.Click += tsmiAltaProd_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { tsmiAltaUsuario, bajaDeUsuarioToolStripMenuItem });
            iconMenuItem2.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem2.ForeColor = Color.White;
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconMenuItem2.IconColor = Color.White;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Margin = new Padding(2, 10, 0, 0);
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Padding = new Padding(0, 0, 4, 0);
            iconMenuItem2.Size = new Size(84, 38);
            iconMenuItem2.Text = "Usuarios";
            // 
            // tsmiAltaUsuario
            // 
            tsmiAltaUsuario.Name = "tsmiAltaUsuario";
            tsmiAltaUsuario.Size = new Size(142, 22);
            tsmiAltaUsuario.Text = "Dar de alta";
            tsmiAltaUsuario.Click += tsmiAltaUsuario_Click;
            // 
            // bajaDeUsuarioToolStripMenuItem
            // 
            bajaDeUsuarioToolStripMenuItem.Name = "bajaDeUsuarioToolStripMenuItem";
            bajaDeUsuarioToolStripMenuItem.Size = new Size(142, 22);
            bajaDeUsuarioToolStripMenuItem.Text = "Listar";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { tsmiDetalleVentas, tsmiDetalleCompras });
            iconMenuItem3.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem3.ForeColor = Color.White;
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconMenuItem3.IconColor = Color.White;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Margin = new Padding(0, 10, 0, 0);
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(90, 38);
            iconMenuItem3.Text = "Reportes";
            // 
            // tsmiDetalleVentas
            // 
            tsmiDetalleVentas.Name = "tsmiDetalleVentas";
            tsmiDetalleVentas.Size = new Size(194, 22);
            tsmiDetalleVentas.Text = "Detalle de Ventas";
            tsmiDetalleVentas.Click += tsmiDetalleVentas_Click;
            // 
            // tsmiDetalleCompras
            // 
            tsmiDetalleCompras.Name = "tsmiDetalleCompras";
            tsmiDetalleCompras.Size = new Size(194, 22);
            tsmiDetalleCompras.Text = "Detalle de Compras";
            tsmiDetalleCompras.Click += tsmiDetalleCompras_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(22, 48);
            toolStripMenuItem3.Text = " ";
            // 
            // frmVistaAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(960, 660);
            Controls.Add(menuStrip1);
            Controls.Add(pntCabecera);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmVistaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Agregra.ResumeLayout(false);
            pntCabecera.ResumeLayout(false);
            pntCabecera.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private Panel pntCabecera;
        private Label lblNombreRegistro;
        private Label lblTituloAdm;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem tsmiListarProd;
        private ToolStripMenuItem tsmiAltaProd;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private ToolStripMenuItem tsmiAltaUsuario;
        private ToolStripMenuItem bajaDeUsuarioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private ToolStripMenuItem tsmiDetalleVentas;
        private ToolStripMenuItem tsmiDetalleCompras;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}

