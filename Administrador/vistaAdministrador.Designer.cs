namespace CapaPresentacion.Administrador
{
    partial class frmVistaAdmin
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
            button1 = new Button();
            btnVistaUsuario = new Button();
            btnVistaCompras = new Button();
            btnVistaVentas = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(695, 334);
            button1.Name = "button1";
            button1.Size = new Size(93, 52);
            button1.TabIndex = 5;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnVistaUsuario
            // 
            btnVistaUsuario.Location = new Point(321, 61);
            btnVistaUsuario.Name = "btnVistaUsuario";
            btnVistaUsuario.Size = new Size(82, 23);
            btnVistaUsuario.TabIndex = 7;
            btnVistaUsuario.Text = "Ver Usuarios";
            btnVistaUsuario.UseVisualStyleBackColor = true;
            btnVistaUsuario.Click += btnVistaUsuario_Click;
            // 
            // btnVistaCompras
            // 
            btnVistaCompras.Location = new Point(321, 90);
            btnVistaCompras.Name = "btnVistaCompras";
            btnVistaCompras.Size = new Size(82, 23);
            btnVistaCompras.TabIndex = 8;
            btnVistaCompras.Text = "Ver compras";
            btnVistaCompras.UseVisualStyleBackColor = true;
            // 
            // btnVistaVentas
            // 
            btnVistaVentas.Location = new Point(321, 119);
            btnVistaVentas.Name = "btnVistaVentas";
            btnVistaVentas.Size = new Size(82, 23);
            btnVistaVentas.TabIndex = 9;
            btnVistaVentas.Text = "Ver Ventas";
            btnVistaVentas.UseVisualStyleBackColor = true;
            // 
            // frmVistaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(btnVistaVentas);
            Controls.Add(btnVistaCompras);
            Controls.Add(btnVistaUsuario);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmVistaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnVistaUsuario;
        private Button btnVistaCompras;
        private Button btnVistaVentas;
    }
}