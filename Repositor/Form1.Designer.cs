namespace CapaPresentacion.Repositor
{
    partial class frmVistaRepositor
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
            lblTitulo = new Label();
            pntCabecera = new Panel();
            lblNombreRegistro = new Label();
            lblTituloRepositor = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            pntCabecera.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Ink Free", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Transparent;
            lblTitulo.Location = new Point(14, 24);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 29);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Tienda zonafitt";
            // 
            // pntCabecera
            // 
            pntCabecera.BackColor = Color.Indigo;
            pntCabecera.Controls.Add(lblNombreRegistro);
            pntCabecera.Controls.Add(lblTituloRepositor);
            pntCabecera.Controls.Add(lblTitulo);
            pntCabecera.Controls.Add(iconButton1);
            pntCabecera.Dock = DockStyle.Top;
            pntCabecera.Location = new Point(0, 0);
            pntCabecera.Margin = new Padding(4, 3, 4, 3);
            pntCabecera.Name = "pntCabecera";
            pntCabecera.Size = new Size(999, 70);
            pntCabecera.TabIndex = 10;
            // 
            // lblNombreRegistro
            // 
            lblNombreRegistro.AutoSize = true;
            lblNombreRegistro.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreRegistro.ForeColor = Color.Transparent;
            lblNombreRegistro.Location = new Point(858, 24);
            lblNombreRegistro.Margin = new Padding(4, 0, 4, 0);
            lblNombreRegistro.Name = "lblNombreRegistro";
            lblNombreRegistro.Size = new Size(129, 19);
            lblNombreRegistro.TabIndex = 12;
            lblNombreRegistro.Text = "nombreCompleto";
            // 
            // lblTituloRepositor
            // 
            lblTituloRepositor.AutoSize = true;
            lblTituloRepositor.BackColor = Color.Transparent;
            lblTituloRepositor.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRepositor.ForeColor = Color.Transparent;
            lblTituloRepositor.Location = new Point(784, 24);
            lblTituloRepositor.Margin = new Padding(4, 0, 4, 0);
            lblTituloRepositor.Name = "lblTituloRepositor";
            lblTituloRepositor.Size = new Size(75, 19);
            lblTituloRepositor.TabIndex = 11;
            lblTituloRepositor.Text = "Repositor";
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
            iconButton1.Location = new Point(753, 18);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 33);
            iconButton1.TabIndex = 8;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(192, 192, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem3 });
            menuStrip1.Location = new Point(0, 70);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(999, 52);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.BackColor = Color.FromArgb(192, 192, 0);
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem4, toolStripMenuItem1 });
            iconMenuItem3.ForeColor = Color.White;
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconMenuItem3.IconColor = Color.White;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(78, 44);
            iconMenuItem3.Text = "Compra";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(147, 22);
            iconMenuItem4.Text = "Alta producto";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(147, 22);
            toolStripMenuItem1.Text = "Ver Detalle";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Variable Text Semibold", 9.75F);
            panel1.Location = new Point(0, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 328);
            panel1.TabIndex = 13;
            // 
            // frmVistaRepositor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(999, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(pntCabecera);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmVistaRepositor";
            Text = "Repositor";
            pntCabecera.ResumeLayout(false);
            pntCabecera.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel pntCabecera;
        private Label lblNombreRegistro;
        private Label lblTituloRepositor;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel1;
    }
}