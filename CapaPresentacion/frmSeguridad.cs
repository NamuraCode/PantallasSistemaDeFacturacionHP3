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
    public partial class frmSeguridad : Form
    {
        public frmSeguridad()
        {
            InitializeComponent();
            txtGuardar.Click += btnActualizarSeguridad_Click;
        }

        private void btnActualizarSeguridad_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ComboBoxSeleccionado(cmbEmpleado, "Empleado")) return;
            if (!Validaciones.ValidarCamposRequeridos((txtUsuario, "Usuario"))) return;
            if (!Validaciones.EsClaveValida(txtClave, 6)) return;

            // TODO: llamar DALSeguridad.ActualizarSeguridad
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.LimpiarError(txtUsuario);
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            Validaciones.LimpiarError(txtClave);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
