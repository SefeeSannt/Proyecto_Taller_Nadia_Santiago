namespace CapaPresentacion.Repositor
{
    partial class frmAltaProducto
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button3 = new Button();
            label11 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            idProducto = new DataGridViewTextBoxColumn();
            nombreProducto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblNombreProducto = new Label();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            lblPrecioVenta = new Label();
            lblCosto = new Label();
            lblStock = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            btnCanecelar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblRegistrarProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(713, 395);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(64, 64, 64);
            label11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(-183, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(141, 25);
            label11.TabIndex = 27;
            label11.Text = "Detalle usuario";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 128, 0);
            label10.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(314, 9);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(844, 27);
            label10.TabIndex = 26;
            label10.Text = "Lista de Productos";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, idProducto, nombreProducto, categoria, descripcion, precioVenta, costo, stock });
            dataGridView1.Location = new Point(314, 55);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(844, 372);
            dataGridView1.TabIndex = 25;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID producto";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Visible = false;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre";
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            nombreProducto.Width = 150;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 180;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 150;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.Name = "precioVenta";
            precioVenta.ReadOnly = true;
            // 
            // costo
            // 
            costo.HeaderText = "Costo";
            costo.Name = "costo";
            costo.ReadOnly = true;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 427);
            label1.TabIndex = 24;
            label1.Click += label1_Click;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BackColor = Color.White;
            lblNombreProducto.Font = new Font("Tahoma", 10F);
            lblNombreProducto.Location = new Point(12, 65);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(139, 17);
            lblNombreProducto.TabIndex = 28;
            lblNombreProducto.Text = "Nombre del producto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.White;
            lblCategoria.Font = new Font("Tahoma", 10F);
            lblCategoria.Location = new Point(12, 109);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(66, 17);
            lblCategoria.TabIndex = 29;
            lblCategoria.Text = "Categoria";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.White;
            lblDescripcion.Font = new Font("Tahoma", 10F);
            lblDescripcion.Location = new Point(12, 153);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(78, 17);
            lblDescripcion.TabIndex = 30;
            lblDescripcion.Text = "Descripción";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.BackColor = Color.White;
            lblPrecioVenta.Font = new Font("Tahoma", 10F);
            lblPrecioVenta.Location = new Point(12, 200);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(84, 17);
            lblPrecioVenta.TabIndex = 31;
            lblPrecioVenta.Text = "Precio venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.BackColor = Color.White;
            lblCosto.Font = new Font("Tahoma", 10F);
            lblCosto.Location = new Point(12, 244);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(44, 17);
            lblCosto.TabIndex = 32;
            lblCosto.Text = "Costo";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.White;
            lblStock.Font = new Font("Tahoma", 10F);
            lblStock.Location = new Point(12, 288);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(43, 17);
            lblStock.TabIndex = 33;
            lblStock.Text = "Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 23);
            textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 37;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(13, 83);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(231, 23);
            textBox5.TabIndex = 38;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 23);
            comboBox1.TabIndex = 39;
            // 
            // btnCanecelar
            // 
            btnCanecelar.BackColor = Color.Red;
            btnCanecelar.Cursor = Cursors.Hand;
            btnCanecelar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnCanecelar.FlatStyle = FlatStyle.Flat;
            btnCanecelar.Font = new Font("Segoe UI", 10F);
            btnCanecelar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnCanecelar.IconColor = Color.Black;
            btnCanecelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCanecelar.IconSize = 16;
            btnCanecelar.Location = new Point(202, 349);
            btnCanecelar.Margin = new Padding(4, 3, 4, 3);
            btnCanecelar.Name = "btnCanecelar";
            btnCanecelar.Size = new Size(99, 27);
            btnCanecelar.TabIndex = 42;
            btnCanecelar.Text = "Eliminar";
            btnCanecelar.TextAlign = ContentAlignment.MiddleRight;
            btnCanecelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCanecelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Blue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 16;
            btnEditar.Location = new Point(104, 349);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 27);
            btnEditar.TabIndex = 41;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(7, 349);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(89, 27);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblRegistrarProducto
            // 
            lblRegistrarProducto.AutoSize = true;
            lblRegistrarProducto.BackColor = Color.White;
            lblRegistrarProducto.Font = new Font("Tahoma", 14F);
            lblRegistrarProducto.Location = new Point(12, 13);
            lblRegistrarProducto.Name = "lblRegistrarProducto";
            lblRegistrarProducto.Size = new Size(165, 23);
            lblRegistrarProducto.TabIndex = 43;
            lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // frmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 427);
            Controls.Add(lblRegistrarProducto);
            Controls.Add(btnCanecelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblStock);
            Controls.Add(lblCosto);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombreProducto);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "frmAltaProducto";
            Text = "Alta producto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Label label11;
        private Label label10;
        private DataGridView dataGridView1;
        private Label label1;
        private Label lblNombreProducto;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblStock;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnCanecelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblRegistrarProducto;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewTextBoxColumn stock;
    }
}