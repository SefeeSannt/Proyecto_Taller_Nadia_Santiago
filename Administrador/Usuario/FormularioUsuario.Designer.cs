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
            Label lblTituloListaUsuarios;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Agregra = new ContextMenuStrip(components);
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblTituloAltaUs = new Label();
            dgvUsuariosAlta = new DataGridView();
            documento = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
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
            lblAltaUsuario = new Label();
            lblTituloListaUsuarios = new Label();
            Agregra.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosAlta).BeginInit();
            SuspendLayout();
            // 
            // lblTituloListaUsuarios
            // 
            lblTituloListaUsuarios.BackColor = Color.FromArgb(255, 128, 0);
            lblTituloListaUsuarios.Dock = DockStyle.Top;
            lblTituloListaUsuarios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloListaUsuarios.Location = new Point(249, 0);
            lblTituloListaUsuarios.Margin = new Padding(4, 0, 4, 0);
            lblTituloListaUsuarios.Name = "lblTituloListaUsuarios";
            lblTituloListaUsuarios.Size = new Size(712, 49);
            lblTituloListaUsuarios.TabIndex = 21;
            lblTituloListaUsuarios.Text = "Lista de Usuarios de Alta";
            lblTituloListaUsuarios.TextAlign = ContentAlignment.MiddleLeft;
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
            panel1.Controls.Add(lblTituloAltaUs);
            panel1.Controls.Add(lblTituloListaUsuarios);
            panel1.Controls.Add(dgvUsuariosAlta);
            panel1.Controls.Add(btnCanecelar);
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
            panel1.Controls.Add(lblAltaUsuario);
            panel1.Cursor = Cursors.Hand;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 560);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // lblTituloAltaUs
            // 
            lblTituloAltaUs.AutoSize = true;
            lblTituloAltaUs.BackColor = Color.White;
            lblTituloAltaUs.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloAltaUs.ForeColor = Color.Black;
            lblTituloAltaUs.Location = new Point(14, 25);
            lblTituloAltaUs.Margin = new Padding(4, 0, 4, 0);
            lblTituloAltaUs.Name = "lblTituloAltaUs";
            lblTituloAltaUs.Size = new Size(118, 24);
            lblTituloAltaUs.TabIndex = 23;
            lblTituloAltaUs.Text = "Alta Usuario";
            // 
            // dgvUsuariosAlta
            // 
            dgvUsuariosAlta.AllowUserToAddRows = false;
            dgvUsuariosAlta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuariosAlta.BackgroundColor = Color.White;
            dgvUsuariosAlta.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuariosAlta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuariosAlta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosAlta.Columns.AddRange(new DataGridViewColumn[] { documento, nombreCompleto, correo, rol, estado });
            dgvUsuariosAlta.Dock = DockStyle.Bottom;
            dgvUsuariosAlta.Location = new Point(249, 54);
            dgvUsuariosAlta.Margin = new Padding(4, 3, 4, 3);
            dgvUsuariosAlta.MultiSelect = false;
            dgvUsuariosAlta.Name = "dgvUsuariosAlta";
            dgvUsuariosAlta.ReadOnly = true;
            dgvUsuariosAlta.RowHeadersWidth = 10;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvUsuariosAlta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuariosAlta.RowTemplate.Height = 28;
            dgvUsuariosAlta.Size = new Size(712, 506);
            dgvUsuariosAlta.TabIndex = 20;
            dgvUsuariosAlta.CellContentClick += dataGridView1_CellContentClick;
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
            // btnCanecelar
            // 
            btnCanecelar.BackColor = Color.Red;
            btnCanecelar.Cursor = Cursors.Hand;
            btnCanecelar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnCanecelar.FlatStyle = FlatStyle.Flat;
            btnCanecelar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnCanecelar.IconColor = Color.Black;
            btnCanecelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCanecelar.IconSize = 16;
            btnCanecelar.Location = new Point(14, 486);
            btnCanecelar.Margin = new Padding(4, 3, 4, 3);
            btnCanecelar.Name = "btnCanecelar";
            btnCanecelar.Size = new Size(219, 27);
            btnCanecelar.TabIndex = 19;
            btnCanecelar.Text = "Limpiar";
            btnCanecelar.TextAlign = ContentAlignment.MiddleRight;
            btnCanecelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCanecelar.UseVisualStyleBackColor = false;
            btnCanecelar.Click += iconButton3_Click;
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
            btnGuardar.Location = new Point(12, 453);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(221, 27);
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
            label9.BackColor = Color.White;
            label9.Font = new Font("Tahoma", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 393);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 16;
            label9.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Tahoma", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(14, 345);
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
            cboEstado.Location = new Point(12, 411);
            cboEstado.Margin = new Padding(4, 3, 4, 3);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(221, 23);
            cboEstado.TabIndex = 14;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(12, 365);
            cboRol.Margin = new Padding(4, 3, 4, 3);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(221, 23);
            cboRol.TabIndex = 13;
            cboRol.SelectedIndexChanged += cboRol_SelectedIndexChanged;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(13, 315);
            txtConfirmarClave.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(221, 23);
            txtConfirmarClave.TabIndex = 12;
            txtConfirmarClave.TextChanged += txtConfirmarClave_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Tahoma", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(10, 296);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 17);
            label7.TabIndex = 11;
            label7.Text = "Confirmar contraseña:";
            label7.Click += label7_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(14, 263);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(220, 23);
            txtClave.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(10, 245);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 9;
            label6.Text = "Contraseña:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(13, 217);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(220, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(13, 172);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(220, 23);
            txtCorreo.TabIndex = 7;
            // 
            // txtNombreC
            // 
            txtNombreC.Location = new Point(13, 127);
            txtNombreC.Margin = new Padding(4, 3, 4, 3);
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(220, 23);
            txtNombreC.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(13, 81);
            txtDocumento.Margin = new Padding(4, 3, 4, 3);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(220, 23);
            txtDocumento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 199);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(10, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 1;
            label2.Text = "Nro. Documento: ";
            label2.Click += label2_Click;
            // 
            // lblAltaUsuario
            // 
            lblAltaUsuario.BackColor = Color.White;
            lblAltaUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblAltaUsuario.Dock = DockStyle.Left;
            lblAltaUsuario.Location = new Point(0, 0);
            lblAltaUsuario.Margin = new Padding(4, 0, 4, 0);
            lblAltaUsuario.Name = "lblAltaUsuario";
            lblAltaUsuario.Size = new Size(249, 560);
            lblAltaUsuario.TabIndex = 0;
            lblAltaUsuario.Click += label1_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(960, 560);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
            Load += FormularioUsuario_Load;
            Agregra.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosAlta).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAltaUsuario;
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
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridView dgvUsuariosAlta;
        private System.Windows.Forms.Label lblTituloAltaUs;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn nombreCompleto;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn estado;
        private Label lblTituloListaUsuarios;
    }
}

