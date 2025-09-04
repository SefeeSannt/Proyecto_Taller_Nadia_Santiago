namespace inicio
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            lblTitulo = new Label();
            btnSupervisor = new FontAwesome.Sharp.IconButton();
            btnAdmin = new FontAwesome.Sharp.IconButton();
            btnVendedor = new FontAwesome.Sharp.IconButton();
            pnlFondo = new Panel();
            btnSalir = new Button();
            pnlFondo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Ivory;
            lblTitulo.Font = new Font("Microsoft YaHei Light", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonShadow;
            lblTitulo.Location = new Point(61, 24);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(339, 60);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Tienda ZonaFit";
            // 
            // btnSupervisor
            // 
            btnSupervisor.BackColor = SystemColors.ControlLight;
            btnSupervisor.Cursor = Cursors.Hand;
            btnSupervisor.FlatAppearance.BorderSize = 0;
            btnSupervisor.Font = new Font("Bahnschrift SemiBold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupervisor.ForeColor = Color.FromArgb(64, 64, 64);
            btnSupervisor.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btnSupervisor.IconColor = SystemColors.ScrollBar;
            btnSupervisor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSupervisor.Location = new Point(125, 262);
            btnSupervisor.Margin = new Padding(4, 3, 4, 3);
            btnSupervisor.Name = "btnSupervisor";
            btnSupervisor.Size = new Size(223, 63);
            btnSupervisor.TabIndex = 5;
            btnSupervisor.Text = "Encargado Repositor";
            btnSupervisor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSupervisor.UseVisualStyleBackColor = false;
            btnSupervisor.Click += btnSupervisor_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ControlLight;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.Font = new Font("Bahnschrift SemiBold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            btnAdmin.IconColor = SystemColors.ScrollBar;
            btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(125, 121);
            btnAdmin.Margin = new Padding(4, 3, 4, 3);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(223, 63);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Administrador";
            btnAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.BackColor = SystemColors.ControlLight;
            btnVendedor.Cursor = Cursors.Hand;
            btnVendedor.FlatAppearance.BorderSize = 0;
            btnVendedor.Font = new Font("Bahnschrift SemiBold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVendedor.ForeColor = Color.FromArgb(64, 64, 64);
            btnVendedor.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            btnVendedor.IconColor = SystemColors.ScrollBar;
            btnVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVendedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendedor.Location = new Point(125, 192);
            btnVendedor.Margin = new Padding(4, 3, 4, 3);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(223, 63);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Vendedor";
            btnVendedor.TextAlign = ContentAlignment.MiddleRight;
            btnVendedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVendedor.UseVisualStyleBackColor = false;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // pnlFondo
            // 
            pnlFondo.BackgroundImage = (Image)resources.GetObject("pnlFondo.BackgroundImage");
            pnlFondo.Controls.Add(btnSalir);
            pnlFondo.Controls.Add(lblTitulo);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 0);
            pnlFondo.Margin = new Padding(4, 3, 4, 3);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(478, 378);
            pnlFondo.TabIndex = 8;
            pnlFondo.Paint += pnlFondo_Paint;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(391, 343);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 378);
            Controls.Add(btnSupervisor);
            Controls.Add(btnAdmin);
            Controls.Add(btnVendedor);
            Controls.Add(pnlFondo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inicio";
            pnlFondo.ResumeLayout(false);
            pnlFondo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnVendedor;
        private FontAwesome.Sharp.IconButton btnSupervisor;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private System.Windows.Forms.Panel pnlFondo;
        private Button btnSalir;
    }
}

