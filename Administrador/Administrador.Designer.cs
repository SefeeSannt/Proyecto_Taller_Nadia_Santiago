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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            bajaProductoToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            altaUsuariosToolStripMenuItem = new ToolStripMenuItem();
            bajaDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            usuariosRegistradosToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            detalleDeComprasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pntCabecera = new Panel();
            lblNombreRegistro = new Label();
            lblTituloAdm = new Label();
            lblTitulo = new Label();
            Agregra.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            pntCabecera.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(192, 192, 0);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2, iconMenuItem3, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 68);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(996, 52);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, bajaProductoToolStripMenuItem });
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
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Alta producto";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // bajaProductoToolStripMenuItem
            // 
            bajaProductoToolStripMenuItem.Name = "bajaProductoToolStripMenuItem";
            bajaProductoToolStripMenuItem.Size = new Size(180, 22);
            bajaProductoToolStripMenuItem.Text = "Baja producto";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { altaUsuariosToolStripMenuItem, bajaDeUsuarioToolStripMenuItem, usuariosRegistradosToolStripMenuItem });
            iconMenuItem2.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem2.ForeColor = Color.White;
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconMenuItem2.IconColor = Color.White;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Margin = new Padding(2, 10, 0, 0);
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Padding = new Padding(0, 0, 4, 0);
            iconMenuItem2.Size = new Size(84, 82);
            iconMenuItem2.Text = "Usuarios";
            // 
            // altaUsuariosToolStripMenuItem
            // 
            altaUsuariosToolStripMenuItem.Name = "altaUsuariosToolStripMenuItem";
            altaUsuariosToolStripMenuItem.Size = new Size(200, 22);
            altaUsuariosToolStripMenuItem.Text = "Alta usuarios";
            // 
            // bajaDeUsuarioToolStripMenuItem
            // 
            bajaDeUsuarioToolStripMenuItem.Name = "bajaDeUsuarioToolStripMenuItem";
            bajaDeUsuarioToolStripMenuItem.Size = new Size(200, 22);
            bajaDeUsuarioToolStripMenuItem.Text = "Baja de usuario";
            // 
            // usuariosRegistradosToolStripMenuItem
            // 
            usuariosRegistradosToolStripMenuItem.Name = "usuariosRegistradosToolStripMenuItem";
            usuariosRegistradosToolStripMenuItem.Size = new Size(200, 22);
            usuariosRegistradosToolStripMenuItem.Text = "Usuarios registrados";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, detalleDeComprasToolStripMenuItem });
            iconMenuItem3.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem3.ForeColor = Color.White;
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconMenuItem3.IconColor = Color.White;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Margin = new Padding(0, 10, 0, 0);
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(90, 82);
            iconMenuItem3.Text = "Reportes";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(194, 22);
            toolStripMenuItem1.Text = "Detalle de Ventas";
            // 
            // detalleDeComprasToolStripMenuItem
            // 
            detalleDeComprasToolStripMenuItem.Name = "detalleDeComprasToolStripMenuItem";
            detalleDeComprasToolStripMenuItem.Size = new Size(194, 22);
            detalleDeComprasToolStripMenuItem.Text = "Detalle de Compras";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(22, 92);
            toolStripMenuItem3.Text = " ";
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
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(pntCabecera);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 519);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pntCabecera
            // 
            pntCabecera.BackColor = Color.Indigo;
            pntCabecera.Controls.Add(lblNombreRegistro);
            pntCabecera.Controls.Add(lblTituloAdm);
            pntCabecera.Controls.Add(lblTitulo);
            pntCabecera.Controls.Add(iconButton1);
            pntCabecera.Location = new Point(0, 0);
            pntCabecera.Margin = new Padding(4, 3, 4, 3);
            pntCabecera.Name = "pntCabecera";
            pntCabecera.Size = new Size(996, 70);
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
            // frmVistaAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = CapaPresentacion.Properties.Resources.negro4;
            ClientSize = new Size(960, 519);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmVistaAdmin";
            Text = "Administrador";
            Agregra.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            pntCabecera.ResumeLayout(false);
            pntCabecera.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bajaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosRegistradosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pntCabecera;
        private System.Windows.Forms.Label lblTituloAdm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreRegistro;
        private ToolStripMenuItem altaUsuariosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem detalleDeComprasToolStripMenuItem;
        private ToolStripMenuItem bajaProductoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}

