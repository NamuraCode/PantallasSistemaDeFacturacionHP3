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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposRequeridos(
                (txtCodigo, "Código"),
                (txtNombreProducto, "Nombre Producto"))) return;

            if (!Validaciones.EsDecimalValido(txtPrecioCompra, "Precio Compra", out decimal precioCompra)) return;
            if (!Validaciones.EsDecimalValido(txtPrecioVenta, "Precio Venta", out decimal precioVenta)) return;
            if (!Validaciones.EsEnteroValido(txtStock, "Cantidad Stock", out int stock)) return;
            if (!Validaciones.ComboBoxSeleccionado(cmbCategoria, "Categoría")) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
