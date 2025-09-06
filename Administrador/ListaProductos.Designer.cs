namespace CapaPresentacion.Administrador
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvUsuariosAlta = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precioCosto = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            colImg = new DataGridViewImageColumn();
            colAccion = new DataGridViewButtonColumn();
            lblTituloListUsuarioAlta = new Label();
            btnBuscarListUsuarioAlta = new FontAwesome.Sharp.IconButton();
            txtBuscarUsuarioAlta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosAlta).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuariosAlta
            // 
            dgvUsuariosAlta.AllowUserToAddRows = false;
            dgvUsuariosAlta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuariosAlta.BackgroundColor = Color.White;
            dgvUsuariosAlta.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvUsuariosAlta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuariosAlta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuariosAlta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosAlta.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, precioCosto, precioVenta, marca, proveedor, stock, colImg, colAccion });
            dgvUsuariosAlta.Dock = DockStyle.Bottom;
            dgvUsuariosAlta.Location = new Point(0, 100);
            dgvUsuariosAlta.Name = "dgvUsuariosAlta";
            dgvUsuariosAlta.Size = new Size(960, 419);
            dgvUsuariosAlta.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "Codigo";
            codigo.Name = "codigo";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // precioCosto
            // 
            precioCosto.HeaderText = "Precio Costo";
            precioCosto.Name = "precioCosto";
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.Name = "precioVenta";
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            // 
            // proveedor
            // 
            proveedor.HeaderText = "Proveedor";
            proveedor.Name = "proveedor";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // colImg
            // 
            colImg.HeaderText = "Imagen";
            colImg.Name = "colImg";
            // 
            // colAccion
            // 
            colAccion.HeaderText = "Accion";
            colAccion.Name = "colAccion";
            colAccion.Resizable = DataGridViewTriState.True;
            // 
            // lblTituloListUsuarioAlta
            // 
            lblTituloListUsuarioAlta.BackColor = Color.FromArgb(255, 128, 0);
            lblTituloListUsuarioAlta.Dock = DockStyle.Top;
            lblTituloListUsuarioAlta.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloListUsuarioAlta.ForeColor = Color.White;
            lblTituloListUsuarioAlta.Location = new Point(0, 0);
            lblTituloListUsuarioAlta.Margin = new Padding(4, 0, 4, 0);
            lblTituloListUsuarioAlta.Name = "lblTituloListUsuarioAlta";
            lblTituloListUsuarioAlta.Size = new Size(960, 49);
            lblTituloListUsuarioAlta.TabIndex = 22;
            lblTituloListUsuarioAlta.Text = "Lista de Usuarios de Alta";
            lblTituloListUsuarioAlta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuscarListUsuarioAlta
            // 
            btnBuscarListUsuarioAlta.AccessibleRole = AccessibleRole.None;
            btnBuscarListUsuarioAlta.BackColor = Color.White;
            btnBuscarListUsuarioAlta.FlatAppearance.BorderColor = Color.White;
            btnBuscarListUsuarioAlta.FlatAppearance.BorderSize = 0;
            btnBuscarListUsuarioAlta.FlatAppearance.MouseDownBackColor = Color.White;
            btnBuscarListUsuarioAlta.FlatAppearance.MouseOverBackColor = Color.White;
            btnBuscarListUsuarioAlta.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarListUsuarioAlta.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarListUsuarioAlta.IconColor = Color.Black;
            btnBuscarListUsuarioAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarListUsuarioAlta.IconSize = 15;
            btnBuscarListUsuarioAlta.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarListUsuarioAlta.Location = new Point(866, 59);
            btnBuscarListUsuarioAlta.Margin = new Padding(4, 3, 4, 3);
            btnBuscarListUsuarioAlta.Name = "btnBuscarListUsuarioAlta";
            btnBuscarListUsuarioAlta.Size = new Size(66, 35);
            btnBuscarListUsuarioAlta.TabIndex = 33;
            btnBuscarListUsuarioAlta.Text = "Búscar";
            btnBuscarListUsuarioAlta.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarListUsuarioAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarListUsuarioAlta.UseVisualStyleBackColor = false;
            // 
            // txtBuscarUsuarioAlta
            // 
            txtBuscarUsuarioAlta.Location = new Point(618, 59);
            txtBuscarUsuarioAlta.Margin = new Padding(4, 3, 4, 3);
            txtBuscarUsuarioAlta.Multiline = true;
            txtBuscarUsuarioAlta.Name = "txtBuscarUsuarioAlta";
            txtBuscarUsuarioAlta.Size = new Size(240, 35);
            txtBuscarUsuarioAlta.TabIndex = 32;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 519);
            Controls.Add(btnBuscarListUsuarioAlta);
            Controls.Add(txtBuscarUsuarioAlta);
            Controls.Add(lblTituloListUsuarioAlta);
            Controls.Add(dgvUsuariosAlta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
           
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosAlta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuariosAlta;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precioCosto;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn proveedor;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewImageColumn colImg;
        private DataGridViewButtonColumn colAccion;
        private Label lblTituloListUsuarioAlta;
        private FontAwesome.Sharp.IconButton btnBuscarListUsuarioAlta;
        private TextBox txtBuscarUsuarioAlta;
    }
}