namespace Administracion
{
    partial class frmUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Agregra = new ContextMenuStrip(components);
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label11 = new Label();
            txtId = new TextBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            idUsuaruio = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            clave = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            estadoValor = new DataGridViewTextBoxColumn();
            btnCanecelar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label8 = new Label();
            cboEstado = new ComboBox();
            cboRol = new ComboBox();
            txtConfirmarClave = new TextBox();
            label7 = new Label();
            txtClave = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombreC = new TextBox();
            txtDocumento = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Agregra.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnCanecelar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(cboRol);
            panel1.Controls.Add(txtConfirmarClave);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNombreC);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 549);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(224, 224, 224);
            label11.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(14, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(145, 24);
            label11.TabIndex = 23;
            label11.Text = "Detalle usuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(220, 80);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 22;
            txtId.Visible = false;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 128, 0);
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(314, 10);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(880, 27);
            label10.TabIndex = 21;
            label10.Text = "Lista de Usuarios";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, idUsuaruio, documento, nombreCompleto, correo, clave, idRol, rol, estado, estadoValor });
            dataGridView1.Location = new Point(312, 42);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(882, 372);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // idUsuaruio
            // 
            idUsuaruio.HeaderText = "ID usuario";
            idUsuaruio.Name = "idUsuaruio";
            idUsuaruio.ReadOnly = true;
            idUsuaruio.Visible = false;
            // 
            // documento
            // 
            documento.HeaderText = "Nro Documento";
            documento.Name = "documento";
            documento.ReadOnly = true;
            documento.Width = 150;
            // 
            // nombreCompleto
            // 
            nombreCompleto.HeaderText = "Nombre completo";
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.ReadOnly = true;
            nombreCompleto.Width = 180;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 150;
            // 
            // clave
            // 
            clave.HeaderText = "Clave";
            clave.Name = "clave";
            clave.ReadOnly = true;
            clave.Visible = false;
            // 
            // idRol
            // 
            idRol.HeaderText = "ID rol";
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            rol.ReadOnly = true;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // estadoValor
            // 
            estadoValor.HeaderText = "Estado valor";
            estadoValor.Name = "estadoValor";
            estadoValor.ReadOnly = true;
            estadoValor.Visible = false;
            // 
            // btnCanecelar
            // 
            btnCanecelar.BackColor = Color.Red;
            btnCanecelar.Cursor = Cursors.Hand;
            btnCanecelar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnCanecelar.FlatStyle = FlatStyle.Flat;
            btnCanecelar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnCanecelar.IconColor = Color.Black;
            btnCanecelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCanecelar.IconSize = 16;
            btnCanecelar.Location = new Point(204, 479);
            btnCanecelar.Margin = new Padding(4, 3, 4, 3);
            btnCanecelar.Name = "btnCanecelar";
            btnCanecelar.Size = new Size(88, 27);
            btnCanecelar.TabIndex = 19;
            btnCanecelar.Text = "Eliminar";
            btnCanecelar.TextAlign = ContentAlignment.MiddleRight;
            btnCanecelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCanecelar.UseVisualStyleBackColor = false;
            btnCanecelar.Click += iconButton3_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Blue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 16;
            btnEditar.Location = new Point(110, 479);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 27);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += iconButton2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(15, 479);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 27);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += iconButton1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Tahoma", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(14, 418);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 16;
            label9.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Tahoma", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(16, 370);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 15;
            label8.Text = "Rol:";
            label8.Click += label8_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(14, 436);
            cboEstado.Margin = new Padding(4, 3, 4, 3);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(243, 23);
            cboEstado.TabIndex = 14;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(14, 390);
            cboRol.Margin = new Padding(4, 3, 4, 3);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(243, 23);
            cboRol.TabIndex = 13;
            cboRol.SelectedIndexChanged += cboRol_SelectedIndexChanged;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(15, 340);
            txtConfirmarClave.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(243, 23);
            txtConfirmarClave.TabIndex = 12;
            txtConfirmarClave.TextChanged += txtConfirmarClave_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Tahoma", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 321);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 17);
            label7.TabIndex = 11;
            label7.Text = "Confirmar contraseña:";
            label7.Click += label7_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(16, 288);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(242, 23);
            txtClave.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Tahoma", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 270);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 9;
            label6.Text = "Contraseña:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(15, 242);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(242, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(15, 197);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(242, 23);
            txtCorreo.TabIndex = 7;
            // 
            // txtNombreC
            // 
            txtNombreC.Location = new Point(15, 152);
            txtNombreC.Margin = new Padding(4, 3, 4, 3);
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(242, 23);
            txtNombreC.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(15, 106);
            txtDocumento.Margin = new Padding(4, 3, 4, 3);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(242, 23);
            txtDocumento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 224);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Tahoma", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 179);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Tahoma", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Tahoma", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 1;
            label2.Text = "Nro. Documento: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 549);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1204, 549);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmUsuario";
            Text = "Usuario";
            Load += FormularioUsuario_Load;
            Agregra.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnCanecelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuaruio;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.Label label11;
    }
}

