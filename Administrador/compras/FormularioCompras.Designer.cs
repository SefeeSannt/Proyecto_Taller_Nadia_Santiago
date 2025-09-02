namespace compras
{
    partial class frmCompras
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            labelBuscarPor = new Label();
            dataGridView1 = new DataGridView();
            fechaRegistro = new DataGridViewTextBoxColumn();
            tipoDoc = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            montoTotal = new DataGridViewTextBoxColumn();
            usuarioRegistro = new DataGridViewTextBoxColumn();
            docProveedor = new DataGridViewTextBoxColumn();
            codigoProducto = new DataGridViewTextBoxColumn();
            nombreProducto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            label3 = new Label();
            comboBox1 = new ComboBox();
            lblProveedor = new Label();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1020, 144);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 29;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(870, 144);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 28;
            // 
            // labelBuscarPor
            // 
            labelBuscarPor.AutoSize = true;
            labelBuscarPor.BackColor = Color.White;
            labelBuscarPor.Font = new Font("Franklin Gothic Medium", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBuscarPor.ForeColor = SystemColors.ActiveCaptionText;
            labelBuscarPor.Location = new Point(791, 147);
            labelBuscarPor.Margin = new Padding(4, 0, 4, 0);
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(62, 15);
            labelBuscarPor.TabIndex = 27;
            labelBuscarPor.Text = "Búscar por:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaRegistro, tipoDoc, NroDocumento, montoTotal, usuarioRegistro, docProveedor, codigoProducto, nombreProducto, categoria, precioCompra });
            dataGridView1.Location = new Point(31, 195);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1210, 310);
            dataGridView1.TabIndex = 26;
            // 
            // fechaRegistro
            // 
            fechaRegistro.HeaderText = "Fecha Registro";
            fechaRegistro.Name = "fechaRegistro";
            // 
            // tipoDoc
            // 
            tipoDoc.HeaderText = "Tipo Documento";
            tipoDoc.Name = "tipoDoc";
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro. Documento";
            NroDocumento.Name = "NroDocumento";
            // 
            // montoTotal
            // 
            montoTotal.HeaderText = "Monto Total";
            montoTotal.Name = "montoTotal";
            // 
            // usuarioRegistro
            // 
            usuarioRegistro.HeaderText = "Usuario Registro";
            usuarioRegistro.Name = "usuarioRegistro";
            // 
            // docProveedor
            // 
            docProveedor.HeaderText = "Documento Proveedor";
            docProveedor.Name = "docProveedor";
            // 
            // codigoProducto
            // 
            codigoProducto.HeaderText = "Código Producto";
            codigoProducto.Name = "codigoProducto";
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre Producto";
            nombreProducto.Name = "nombreProducto";
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio Compra";
            precioCompra.Name = "precioCompra";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(-2, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1323, 402);
            label3.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(562, 65);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 23);
            comboBox1.TabIndex = 24;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.BackColor = Color.White;
            lblProveedor.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProveedor.ForeColor = SystemColors.ActiveCaptionText;
            lblProveedor.Location = new Point(472, 67);
            lblProveedor.Margin = new Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(71, 18);
            lblProveedor.TabIndex = 23;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.BackColor = Color.White;
            lblFechaFin.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaFin.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaFin.Location = new Point(253, 69);
            lblFechaFin.Margin = new Padding(4, 0, 4, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(62, 17);
            lblFechaFin.TabIndex = 22;
            lblFechaFin.Text = "Fecha fin:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.White;
            lblFechaInicio.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaInicio.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaInicio.Location = new Point(35, 69);
            lblFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(77, 17);
            lblFechaInicio.TabIndex = 21;
            lblFechaInicio.Text = "Fecha inicio:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(132, 66);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(114, 23);
            dateTimePicker2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(46, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 24);
            label2.TabIndex = 19;
            label2.Text = "Reporte de Compras";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(329, 65);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1289, 93);
            label1.TabIndex = 18;
            // 
            // iconButton2
            // 
            iconButton2.AccessibleRole = AccessibleRole.None;
            iconButton2.BackColor = Color.White;
            iconButton2.FlatAppearance.BorderColor = Color.White;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.White;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.White;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.ForeColor = SystemColors.ActiveCaptionText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 18;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(1204, 141);
            iconButton2.Margin = new Padding(4, 3, 4, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(37, 28);
            iconButton2.TabIndex = 31;
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.AccessibleRole = AccessibleRole.None;
            iconButton1.BackColor = Color.White;
            iconButton1.FlatAppearance.BorderColor = Color.White;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.White;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = SystemColors.ActiveCaptionText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(820, 63);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(92, 25);
            iconButton1.TabIndex = 30;
            iconButton1.Text = "Buscar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 519);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(labelBuscarPor);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(lblProveedor);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCompras";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn docProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

