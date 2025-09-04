using Administracion;
using CapaPresentacion;
using CapaPresentacion.Repositor;
using CapaPresentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("en proceso");

            var vistaRepositor = new frmVistaRepositor();
            vistaRepositor.Show();
            this.Hide();
            vistaRepositor.FormClosed += (s, args) => this.Show();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var vistaAdmin = new frmVistaAdmin();
            vistaAdmin.Show();
            this.Hide();
            vistaAdmin.FormClosed += (s, args) => this.Show();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            var frmVendedor = new frmVendedor();
            frmVendedor.Show();
            this.Hide();
            frmVendedor.FormClosed += (s, args) => this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
