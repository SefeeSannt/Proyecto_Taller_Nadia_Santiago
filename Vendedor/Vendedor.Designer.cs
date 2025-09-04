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
            menuStrip1 = new MenuStrip();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            icoRegistro = new FontAwesome.Sharp.IconMenuItem();
            icoFactura = new FontAwesome.Sharp.IconMenuItem();
            verDetalleToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pntCabecera = new Panel();
            lblTitulo = new Label();
            lblNombreRegistro = new Label();
            lblTituloVendedor = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            pntCabecera.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(192, 192, 0);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem3, iconMenuItem1, icoRegistro });
            menuStrip1.Location = new Point(0, 63);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 52);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.BackColor = Color.FromArgb(192, 192, 0);
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem4, toolStripMenuItem1 });
            iconMenuItem3.Font = new Font("Segoe UI Variable Text Semibold", 9.75F);
            iconMenuItem3.ForeColor = Color.White;
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconMenuItem3.IconColor = Color.White;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(70, 48);
            iconMenuItem3.Text = "Venta";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(180, 22);
            iconMenuItem4.Text = "Emitir Factura";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "ver detalle";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.BackColor = Color.FromArgb(192, 192, 0);
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem5, toolStripMenuItem2 });
            iconMenuItem1.Font = new Font("Segoe UI Variable Text Semibold", 9.75F);
            iconMenuItem1.ForeColor = Color.White;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconMenuItem1.IconColor = Color.White;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(83, 48);
            iconMenuItem1.Text = "Clientes";
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(180, 22);
            iconMenuItem5.Text = "Alta Cliente";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Ver Cliente";
            // 
            // icoRegistro
            // 
            icoRegistro.DropDownItems.AddRange(new ToolStripItem[] { icoFactura, verDetalleToolStripMenuItem });
            icoRegistro.Font = new Font("Segoe UI Variable Text Semibold", 9.75F);
            icoRegistro.ForeColor = Color.White;
            icoRegistro.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            icoRegistro.IconColor = Color.White;
            icoRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoRegistro.Name = "icoRegistro";
            icoRegistro.Size = new Size(98, 48);
            icoRegistro.Text = "Productos";
            // 
            // icoFactura
            // 
            icoFactura.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            icoFactura.IconColor = Color.Black;
            icoFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoFactura.Name = "icoFactura";
            icoFactura.Size = new Size(180, 22);
            icoFactura.Text = "Ver Disponibles";
            icoFactura.Click += icoFactura_Click;
            // 
            // verDetalleToolStripMenuItem
            // 
            verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            verDetalleToolStripMenuItem.Size = new Size(180, 22);
            verDetalleToolStripMenuItem.Text = "Ver Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(pntCabecera);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 5;
            // 
            // pntCabecera
            // 
            pntCabecera.BackColor = Color.Indigo;
            pntCabecera.Controls.Add(lblTitulo);
            pntCabecera.Controls.Add(lblNombreRegistro);
            pntCabecera.Controls.Add(lblTituloVendedor);
            pntCabecera.Controls.Add(iconButton1);
            pntCabecera.Dock = DockStyle.Top;
            pntCabecera.Location = new Point(0, 0);
            pntCabecera.Name = "pntCabecera";
            pntCabecera.Size = new Size(800, 70);
            pntCabecera.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Indigo;
            lblTitulo.Font = new Font("Ink Free", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Transparent;
            lblTitulo.Location = new Point(13, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 29);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Tienda zonafitt";
            // 
            // lblNombreRegistro
            // 
            lblNombreRegistro.AutoSize = true;
            lblNombreRegistro.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreRegistro.ForeColor = Color.White;
            lblNombreRegistro.Location = new Point(658, 24);
            lblNombreRegistro.Margin = new Padding(4, 0, 4, 0);
            lblNombreRegistro.Name = "lblNombreRegistro";
            lblNombreRegistro.Size = new Size(129, 19);
            lblNombreRegistro.TabIndex = 16;
            lblNombreRegistro.Text = "nombreCompleto";
            // 
            // lblTituloVendedor
            // 
            lblTituloVendedor.AutoSize = true;
            lblTituloVendedor.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVendedor.ForeColor = Color.White;
            lblTituloVendedor.Location = new Point(585, 24);
            lblTituloVendedor.Margin = new Padding(4, 0, 4, 0);
            lblTituloVendedor.Name = "lblTituloVendedor";
            lblTituloVendedor.Size = new Size(75, 19);
            lblTituloVendedor.TabIndex = 15;
            lblTituloVendedor.Text = "Vendedor";
            lblTituloVendedor.Click += label2_Click;
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
            iconButton1.Location = new Point(552, 19);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 33);
            iconButton1.TabIndex = 13;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
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
            pntCabecera.ResumeLayout(false);
            pntCabecera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem icoRegistro;
        private FontAwesome.Sharp.IconMenuItem icoFactura;
        private Panel panel1;
        private ToolStripMenuItem verDetalleToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private ToolStripMenuItem toolStripMenuItem2;
        private Panel pntCabecera;
        private Label lblTitulo;
        private Label lblNombreRegistro;
        private Label lblTituloVendedor;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}