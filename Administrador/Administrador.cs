using CapaPresentacion.Administrador;
using CapaPresentacion.Repositor;
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

namespace Administracion
{
    public partial class frmVistaAdmin : Form
    {
        public frmVistaAdmin()
        {
            InitializeComponent();
        }

        private void tsmiListarProd_Click(object sender, EventArgs e)
        {
            Form frm = new frmProductos();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAltaProd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAltaProducto();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiDetalleCompras_Click(object sender, EventArgs e)
        {
            Form form = new frmCompras();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void tsmiAltaUsuario_Click(object sender, EventArgs e)
        {
            Form frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDetalleVentas_Click(object sender, EventArgs e)
        {
            Form frm = new frmVentas();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
