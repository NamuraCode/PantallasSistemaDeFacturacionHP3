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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
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
            validator.ValidarCamposTexto(textBox2, errorProvider3);
            validator.ValidarCamposTexto(textBox4, errorProvider4);
            validator.ValidarCamposTexto(textBox5, errorProvider5);
            validator.ValidarCamposTexto(textBox7, errorProvider6);
            validator.ValidarComboBox(comboBox1, errorProvider7);
            validator.ValidarCamposTexto(textBox3, errorProvider8);
        }
    }
}
