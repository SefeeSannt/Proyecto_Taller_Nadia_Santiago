namespace CapaPresentacion.Pantalla_Inicio
{
    partial class frmInicio
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
            btnAdmin = new Button();
            label1 = new Label();
            btnEncargado = new Button();
            btnVendedor = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(304, 122);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(175, 39);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(304, 71);
            label1.Name = "label1";
            label1.Size = new Size(175, 36);
            label1.TabIndex = 1;
            label1.Text = "Iniciar Sesión";
            // 
            // btnEncargado
            // 
            btnEncargado.Location = new Point(304, 212);
            btnEncargado.Name = "btnEncargado";
            btnEncargado.Size = new Size(175, 39);
            btnEncargado.TabIndex = 2;
            btnEncargado.Text = "Encargado de inventario";
            btnEncargado.UseVisualStyleBackColor = true;
            btnEncargado.Click += btnEncargado_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.Location = new Point(304, 167);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(175, 39);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(705, 289);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(83, 39);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 340);
            Controls.Add(btnSalir);
            Controls.Add(btnVendedor);
            Controls.Add(btnEncargado);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmin;
        private Label label1;
        private Button btnEncargado;
        private Button btnVendedor;
        private Button btnSalir;
    }
}