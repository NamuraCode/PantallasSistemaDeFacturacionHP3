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
    public partial class frmClientesEditar : Form
    {
        public frmClientesEditar()
        {
            InitializeComponent();
            btnActualizar.Click += btnActualizar_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposRequeridos(
                (txtNombre, "Nombre"),
                (txtDocumento, "Documento"))) return;

            if (!Validaciones.EsEmailValido(txtCorreo, "Correo")) return;
            if (!Validaciones.EsEmailValido(txtEmail, "Email")) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
