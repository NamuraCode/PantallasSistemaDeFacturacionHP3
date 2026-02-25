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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Validator validator = new Validator();
        private void button1_Click(object sender, EventArgs e)
        {
            validator.ValidarCamposTexto(textBox1, errorProvider1);
            validator.ValidarComboBox(comboBox2, errorProvider2);
            validator.ValidarComboBox(comboBox3, errorProvider3);
            validator.ValidarCamposTexto(textBox4, errorProvider4);
            validator.ValidarCamposTexto(textBox5, errorProvider5);
            validator.ValidarCamposTexto(textBox6, errorProvider6);
            validator.ValidarComboBox(comboBox1, errorProvider7);
            validator.ValidarCamposTexto(textBox2, errorProvider8);
        }
    }
}
