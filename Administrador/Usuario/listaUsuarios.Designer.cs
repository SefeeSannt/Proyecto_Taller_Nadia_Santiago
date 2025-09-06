namespace CapaPresentacion.Administrador.Usuario
{
    partial class frmListaUsuarios
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
            lblUsuarioTitulo = new Label();
            btnCanecelar = new FontAwesome.Sharp.IconButton();
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
            label10 = new Label();
            dgvListaUsuarios = new DataGridView();
            documento = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblUsuarioTitulo
            // 
            lblUsuarioTitulo.AutoSize = true;
            lblUsuarioTitulo.BackColor = Color.White;
            lblUsuarioTitulo.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuarioTitulo.ForeColor = Color.Black;
            lblUsuarioTitulo.Location = new Point(4, 9);
            lblUsuarioTitulo.Margin = new Padding(4, 0, 4, 0);
            lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            lblUsuarioTitulo.Size = new Size(165, 24);
            lblUsuarioTitulo.TabIndex = 43;
            lblUsuarioTitulo.Text = "Registro Usuarios";
            // 
            // btnCanecelar
            // 
            btnCanecelar.BackColor = Color.Green;
            btnCanecelar.Cursor = Cursors.Hand;
            btnCanecelar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnCanecelar.FlatStyle = FlatStyle.Flat;
            btnCanecelar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnCanecelar.IconColor = Color.Black;
            btnCanecelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCanecelar.IconSize = 16;
            btnCanecelar.Location = new Point(14, 510);
            btnCanecelar.Margin = new Padding(4, 3, 4, 3);
            btnCanecelar.Name = "btnCanecelar";
            btnCanecelar.Size = new Size(220, 27);
            btnCanecelar.TabIndex = 42;
            btnCanecelar.Text = "Guardar";
            btnCanecelar.TextAlign = ContentAlignment.MiddleRight;
            btnCanecelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCanecelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Blue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(14, 477);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(219, 27);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Editar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Tahoma", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 391);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 40;
            label9.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Tahoma", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(18, 343);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 39;
            label8.Text = "Rol:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(12, 410);
            cboEstado.Margin = new Padding(4, 3, 4, 3);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(221, 23);
            cboEstado.TabIndex = 38;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(12, 364);
            cboRol.Margin = new Padding(4, 3, 4, 3);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(221, 23);
            cboRol.TabIndex = 37;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(13, 314);
            txtConfirmarClave.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(221, 23);
            txtConfirmarClave.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Tahoma", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(14, 294);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 17);
            label7.TabIndex = 35;
            label7.Text = "Confirmar contraseña:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(14, 262);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(220, 23);
            txtClave.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(14, 243);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 33;
            label6.Text = "Contraseña:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(13, 216);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(220, 23);
            txtTelefono.TabIndex = 32;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(13, 171);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(220, 23);
            txtCorreo.TabIndex = 31;
            // 
            // txtNombreC
            // 
            txtNombreC.Location = new Point(13, 126);
            txtNombreC.Margin = new Padding(4, 3, 4, 3);
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(220, 23);
            txtNombreC.TabIndex = 30;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(13, 80);
            txtDocumento.Margin = new Padding(4, 3, 4, 3);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(220, 23);
            txtDocumento.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 197);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 28;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 27;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 26;
            label3.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 61);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 25;
            label2.Text = "Nro. Documento: ";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 560);
            label1.TabIndex = 24;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 128, 0);
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(249, 0);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(711, 49);
            label10.TabIndex = 45;
            label10.Text = "Lista de Usuarios ";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.BackgroundColor = Color.White;
            dgvListaUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { documento, nombreCompleto, correo, rol, estado, eliminar });
            dgvListaUsuarios.Location = new Point(249, 52);
            dgvListaUsuarios.Margin = new Padding(4, 3, 4, 3);
            dgvListaUsuarios.MultiSelect = false;
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvListaUsuarios.RowHeadersWidth = 10;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaUsuarios.RowTemplate.Height = 28;
            dgvListaUsuarios.Size = new Size(711, 508);
            dgvListaUsuarios.TabIndex = 44;
            dgvListaUsuarios.CellContentClick += dgvListaUsuarios_CellContentClick;
            // 
            // documento
            // 
            documento.HeaderText = "DNI";
            documento.Name = "documento";
            documento.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            nombreCompleto.HeaderText = "Nombre";
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.ReadOnly = true;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
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
            // eliminar
            // 
            eliminar.HeaderText = "";
            eliminar.Name = "eliminar";
            eliminar.ReadOnly = true;
            // 
            // frmListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 560);
            Controls.Add(label10);
            Controls.Add(dgvListaUsuarios);
            Controls.Add(lblUsuarioTitulo);
            Controls.Add(btnCanecelar);
            Controls.Add(btnGuardar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cboEstado);
            Controls.Add(cboRol);
            Controls.Add(txtConfirmarClave);
            Controls.Add(label7);
            Controls.Add(txtClave);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombreC);
            Controls.Add(txtDocumento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "listaUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioTitulo;
        private FontAwesome.Sharp.IconButton btnCanecelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label9;
        private Label label8;
        private ComboBox cboEstado;
        private ComboBox cboRol;
        private TextBox txtConfirmarClave;
        private Label label7;
        private TextBox txtClave;
        private Label label6;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombreC;
        private TextBox txtDocumento;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private DataGridView dgvListaUsuarios;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn nombreCompleto;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewButtonColumn eliminar;
    }
}