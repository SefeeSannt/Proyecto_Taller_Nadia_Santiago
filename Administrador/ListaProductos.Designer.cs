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
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precioCosto = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            colImg = new DataGridViewImageColumn();
            colAccion = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, precioCosto, precioVenta, marca, proveedor, stock, colImg, colAccion });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(960, 519);
            dataGridView1.TabIndex = 0;
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
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 519);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precioCosto;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn proveedor;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewImageColumn colImg;
        private DataGridViewButtonColumn colAccion;
    }
}