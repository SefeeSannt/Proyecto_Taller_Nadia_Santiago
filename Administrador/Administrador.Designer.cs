namespace Administracion
{
    partial class frmVistaAdmin
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
            Agregra = new ContextMenuStrip(components);
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            bajaDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            usuariosRegistradosToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconbtnNotif = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Agregra.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem2, iconMenuItem1, iconMenuItem3 });
            menuStrip1.Location = new Point(0, 68);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(996, 48);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { bajaDeUsuarioToolStripMenuItem, usuariosRegistradosToolStripMenuItem });
            iconMenuItem2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem2.ForeColor = SystemColors.ButtonFace;
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconMenuItem2.IconColor = Color.White;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Margin = new Padding(2, 10, 0, 0);
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Padding = new Padding(0, 0, 4, 0);
            iconMenuItem2.Size = new Size(85, 34);
            iconMenuItem2.Text = "Usuarios";
            // 
            // bajaDeUsuarioToolStripMenuItem
            // 
            bajaDeUsuarioToolStripMenuItem.Name = "bajaDeUsuarioToolStripMenuItem";
            bajaDeUsuarioToolStripMenuItem.Size = new Size(202, 28);
            bajaDeUsuarioToolStripMenuItem.Text = "Baja de usuario";
            // 
            // usuariosRegistradosToolStripMenuItem
            // 
            usuariosRegistradosToolStripMenuItem.Name = "usuariosRegistradosToolStripMenuItem";
            usuariosRegistradosToolStripMenuItem.Size = new Size(202, 28);
            usuariosRegistradosToolStripMenuItem.Text = "Usuarios registrados";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem });
            iconMenuItem1.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem1.ForeColor = Color.White;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            iconMenuItem1.IconColor = Color.White;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Margin = new Padding(0, 10, 0, 0);
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(77, 34);
            iconMenuItem1.Text = "Ventas";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 28);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            iconMenuItem3.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem3.ForeColor = Color.White;
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            iconMenuItem3.IconColor = Color.White;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Margin = new Padding(0, 10, 0, 0);
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(74, 34);
            iconMenuItem3.Text = "Ayuda";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(70, 22);
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Black;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 22;
            iconButton1.Location = new Point(581, 20);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 33);
            iconButton1.TabIndex = 8;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconbtnNotif
            // 
            iconbtnNotif.BackColor = Color.Black;
            iconbtnNotif.FlatAppearance.BorderSize = 0;
            iconbtnNotif.FlatStyle = FlatStyle.Flat;
            iconbtnNotif.ForeColor = SystemColors.ControlText;
            iconbtnNotif.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconbtnNotif.IconColor = Color.White;
            iconbtnNotif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnNotif.IconSize = 22;
            iconbtnNotif.Location = new Point(940, 21);
            iconbtnNotif.Margin = new Padding(4, 3, 4, 3);
            iconbtnNotif.Name = "iconbtnNotif";
            iconbtnNotif.Size = new Size(42, 33);
            iconbtnNotif.TabIndex = 7;
            iconbtnNotif.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = CapaPresentacion.Properties.Resources.negro4;
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 519);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(iconbtnNotif);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 75);
            panel2.TabIndex = 9;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Black;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = SystemColors.ControlText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 22;
            iconButton2.Location = new Point(891, 21);
            iconButton2.Margin = new Padding(4, 3, 4, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(42, 33);
            iconButton2.TabIndex = 13;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(659, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 12;
            label3.Text = "nombreCompleto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(614, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 11;
            label2.Text = "Hola:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 10;
            label1.Text = "Crosffit Store";
            // 
            // frmVistaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = CapaPresentacion.Properties.Resources.negro4;
            ClientSize = new Size(996, 519);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmVistaAdmin";
            Text = "Administrador";
            Agregra.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bajaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconButton iconbtnNotif;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
    }
}

