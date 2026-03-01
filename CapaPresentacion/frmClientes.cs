using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasSistemaFacturacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var f = new frmClientesEditar())
            {
                f.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var f = new frmClientesEditar())
            {
                f.ShowDialog();
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            using (var f = new frmClientesEditar())
            {
                f.ShowDialog();
            }
        }
    }
}
