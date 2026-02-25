using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SalirVistaCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Validator validator = new Validator();
        private void button1_Click(object sender, EventArgs e)
        {
            validator.ValidarCamposTexto(textBox6, errorProvider1);
            validator.ValidarCamposTexto(textBox1, errorProvider2);
        }
    }
}
