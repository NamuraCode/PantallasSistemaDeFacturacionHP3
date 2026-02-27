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
    public partial class frmListaCategoriasProductos : Form
    {
        public frmListaCategoriasProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var f = new frmCategoriasProductos())
            {
                f.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var f = new frmCategoriasProductos())
            {
                f.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
