using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace PantallasSistemaFacturacion
{
    public partial class frmProductos : Form
    {
        private readonly DALProductos dalProductos = new DALProductos();
        private int _idProducto = 0;

        public frmProductos()
        {
            InitializeComponent();
            this.Load += frmProductos_Load;
        }

        public frmProductos(int idProducto) : this()
        {
            _idProducto = idProducto;
        }

        private void frmProductos_Load(object? sender, EventArgs e)
        {
            CargarCategorias();
            if (_idProducto > 0)
                CargarProducto();
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable dt = dalProductos.ListarCategorias();
                cmbCategoria.DataSource    = dt;
                cmbCategoria.DisplayMember = "NombreCategoria";
                cmbCategoria.ValueMember   = "IdCategoria";
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProducto()
        {
            try
            {
                DataTable dt = dalProductos.ObtenerProductoPorId(_idProducto);
                if (dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];
                txtCodigo.Text          = row["Codigo"].ToString();
                txtNombreProducto.Text  = row["NombreProducto"].ToString();
                txtPrecioCompra.Text    = row["PrecioCompra"].ToString();
                txtPrecioVenta.Text     = row["PrecioVenta"].ToString();
                txtStock.Text           = row["Stock"].ToString();
                txtRutaImagen.Text      = row["RutaImagen"].ToString();
                txtDetallesProducto.Text = row["Detalles"].ToString();
                cmbCategoria.SelectedValue = row["IdCategoria"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar producto: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            try
            {
                int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                string codigo   = txtCodigo.Text.Trim();
                string nombre   = txtNombreProducto.Text.Trim();
                string ruta     = txtRutaImagen.Text.Trim();
                string detalles = txtDetallesProducto.Text.Trim();

                if (_idProducto == 0)
                    dalProductos.InsertarProducto(codigo, nombre, precioCompra, precioVenta, stock, ruta, detalles, idCategoria);
                else
                    dalProductos.ActualizarProducto(_idProducto, codigo, nombre, precioCompra, precioVenta, stock, ruta, detalles, idCategoria);

                MessageBox.Show(_idProducto == 0 ? "Producto creado correctamente." : "Producto actualizado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
