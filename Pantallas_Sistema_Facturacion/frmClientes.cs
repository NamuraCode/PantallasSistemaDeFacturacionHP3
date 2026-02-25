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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void SalirVistaCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Validator validator = new Validator();
        private void button1_Click(object sender, EventArgs e)
        {
            validator.ValidarCamposTexto(textBox6, errorProvider1);
            validator.ValidarCamposTexto(textBox1, errorProvider2);
            validator.ValidarCamposTexto(textBox2, errorProvider3);
            validator.ValidarCamposTexto(textBox3, errorProvider4);
            validator.ValidarCamposTexto(textBox4, errorProvider5);
            validator.ValidarCamposTexto(textBox5, errorProvider6);
        }
    }
}
