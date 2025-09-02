using Administracion;
using CapaPresentacion.Pantalla_Inicio;
using compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class frmVistaAdmin : Form
    {
        public frmVistaAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVistaUsuario_Click(object sender, EventArgs e)
        {
            var form = new frmUsuario();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }

        private void btnVistaCompras_Click(object sender, EventArgs e)
        {
            var form = new frmCompras();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }

        private void btnVistaVentas_Click(object sender, EventArgs e)
        {
            var form = new frmVentas();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }
    }
}
