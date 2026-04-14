using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace PantallasSistemaFacturacion
{
    public partial class frmFacturaEditar : Form
    {
        private readonly DALFacturas  dalFacturas  = new DALFacturas();
        private readonly DALClientes  dalClientes  = new DALClientes();
        private readonly DALProductos dalProductos = new DALProductos();
        private readonly DALEmpleados dalEmpleados = new DALEmpleados();

        private int       idFactura = 0;
        private DataTable dtDetalle = new DataTable();

        // Constructor nuevo
        public frmFacturaEditar()
        {
            InitializeComponent();
            this.Load += frmFacturaEditar_Load;
            InicializarTablaDetalle();
        }

        // Constructor editar
        public frmFacturaEditar(int idFactura) : this()
        {
            this.idFactura = idFactura;
        }

        private void InicializarTablaDetalle()
        {
            dtDetalle.Columns.Add("IdProducto",     typeof(int));
            dtDetalle.Columns.Add("Producto",        typeof(string));
            dtDetalle.Columns.Add("Cantidad",        typeof(int));
            dtDetalle.Columns.Add("PrecioUnitario",  typeof(decimal));
            dtDetalle.Columns.Add("Subtotal",        typeof(decimal));
            dgvDetalle.DataSource = dtDetalle;
        }

        private void frmFacturaEditar_Load(object? sender, EventArgs e)
        {
            CargarClientes();
            CargarEmpleados();
            CargarProductos();
            CargarEstados();

            if (idFactura == 0)
            {
                lblTitulo.Text          = "Nueva Factura";
                txtNumeroFactura.Text   = dalFacturas.GenerarNumeroFactura();
                dtpFechaFactura.Value   = DateTime.Today;
                cmbEstado.SelectedIndex = 0;
            }
            else
            {
                lblTitulo.Text = "Editar Factura";
                CargarFactura();
            }

            if (dgvDetalle.Columns.Contains("IdProducto"))
                dgvDetalle.Columns["IdProducto"].Visible = false;
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = dalClientes.ListarClientes();
                cmbCliente.DataSource    = dt;
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember   = "IdCliente";
                cmbCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                DataTable dt = dalEmpleados.ListarEmpleados();
                cmbEmpleado.DataSource    = dt;
                cmbEmpleado.DisplayMember = "Nombre";
                cmbEmpleado.ValueMember   = "IdEmpleado";
                cmbEmpleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                DataTable dt = dalProductos.ListarProductos();
                cmbProducto.DataSource    = dt;
                cmbProducto.DisplayMember = "NombreProducto";
                cmbProducto.ValueMember   = "IdProducto";
                cmbProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("Pagada");
            cmbEstado.Items.Add("Anulada");
        }

        private void CargarFactura()
        {
            try
            {
                DataTable dt = dalFacturas.ObtenerFacturaPorId(idFactura);
                if (dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];
                txtNumeroFactura.Text = row["NumeroFactura"].ToString();
                cmbCliente.SelectedValue = row["IdCliente"];
                cmbEmpleado.SelectedValue = row["IdEmpleado"];
                dtpFechaFactura.Value = Convert.ToDateTime(row["FechaFactura"]);
                txtDescuento.Text = Convert.ToDecimal(row["Descuento"]).ToString("N2");
                cmbEstado.SelectedItem = row["Estado"].ToString();

                // Cargar detalle
                DataTable detalles = dalFacturas.ListarDetallesFactura(idFactura);
                foreach (DataRow r in detalles.Rows)
                {
                    dtDetalle.Rows.Add(
                        Convert.ToInt32(r["IdProducto"]),
                        r["NombreProducto"].ToString(),
                        Convert.ToInt32(r["Cantidad"]),
                        Convert.ToDecimal(r["PrecioUnitario"]),
                        Convert.ToDecimal(r["Subtotal"])
                    );
                }
                dtDetalle.AcceptChanges();
                CalcularTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar factura: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (entero mayor a 0).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView drv      = (DataRowView)cmbProducto.SelectedItem!;
            int         idProd   = Convert.ToInt32(drv["IdProducto"]);
            string      nombre   = drv["NombreProducto"].ToString()!;
            decimal     precio   = Convert.ToDecimal(drv["PrecioVenta"]);

            DataRow? existente = FindProductoInDetalle(idProd);
            if (existente != null)
            {
                int cantNueva = Convert.ToInt32(existente["Cantidad"]) + cantidad;
                existente["Cantidad"] = cantNueva;
                existente["Subtotal"] = cantNueva * precio;
            }
            else
            {
                dtDetalle.Rows.Add(idProd, nombre, cantidad, precio, precio * cantidad);
            }

            dgvDetalle.Refresh();
            CalcularTotales();
            txtCantidad.Text      = "1";
            cmbProducto.SelectedIndex = -1;
        }

        private void btnQuitarProducto_Click(object? sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto del detalle para quitarlo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = dgvDetalle.SelectedRows[0].Index;
            dtDetalle.Rows[idx].Delete();
            dtDetalle.AcceptChanges();
            CalcularTotales();
        }

        private DataRow? FindProductoInDetalle(int idProducto)
        {
            foreach (DataRow row in dtDetalle.Rows)
            {
                if (row.RowState != DataRowState.Deleted &&
                    Convert.ToInt32(row["IdProducto"]) == idProducto)
                    return row;
            }
            return null;
        }

        private void txtDescuento_TextChanged(object? sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;
            foreach (DataRow row in dtDetalle.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                    subtotal += Convert.ToDecimal(row["Subtotal"]);
            }

            decimal.TryParse(txtDescuento.Text, out decimal descuento);
            if (descuento < 0)        descuento = 0;
            if (descuento > subtotal) descuento = subtotal;

            decimal baseIVA = subtotal - descuento;
            decimal iva     = baseIVA * 0.19m;
            decimal total   = baseIVA + iva;

            lblSubtotalVal.Text = subtotal.ToString("N2");
            lblIVAVal.Text      = iva.ToString("N2");
            lblTotalVal.Text    = total.ToString("N2");
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un cliente.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbEmpleado.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un empleado.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool tieneDetalle = false;
            foreach (DataRow row in dtDetalle.Rows)
            {
                if (row.RowState != DataRowState.Deleted) { tieneDetalle = true; break; }
            }
            if (!tieneDetalle)
            {
                MessageBox.Show("Agregue al menos un producto al detalle de la factura.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal subtotal = 0;
                var activeRows = new List<DataRow>();
                foreach (DataRow row in dtDetalle.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        activeRows.Add(row);
                        subtotal += Convert.ToDecimal(row["Subtotal"]);
                    }
                }

                decimal.TryParse(txtDescuento.Text, out decimal descuento);
                if (descuento < 0)        descuento = 0;
                if (descuento > subtotal) descuento = subtotal;

                decimal baseIVA  = subtotal - descuento;
                decimal iva      = baseIVA * 0.19m;
                decimal total    = baseIVA + iva;
                int     idCli    = Convert.ToInt32(cmbCliente.SelectedValue);
                int     idEmp    = Convert.ToInt32(cmbEmpleado.SelectedValue);
                DateTime fecha   = dtpFechaFactura.Value.Date;
                string   estado  = cmbEstado.SelectedItem?.ToString() ?? "Pendiente";

                if (idFactura == 0)
                {
                    int newId = dalFacturas.InsertarFactura(
                        txtNumeroFactura.Text.Trim(),
                        idCli, idEmp, fecha, descuento, subtotal, iva, total, estado);

                    foreach (var row in activeRows)
                        dalFacturas.InsertarDetalleFactura(newId,
                            Convert.ToInt32(row["IdProducto"]),
                            Convert.ToInt32(row["Cantidad"]),
                            Convert.ToDecimal(row["PrecioUnitario"]),
                            Convert.ToDecimal(row["Subtotal"]));
                }
                else
                {
                    dalFacturas.ActualizarFactura(
                        idFactura, idCli, idEmp, fecha,
                        descuento, subtotal, iva, total, estado);

                    dalFacturas.EliminarDetallesFactura(idFactura);

                    foreach (var row in activeRows)
                        dalFacturas.InsertarDetalleFactura(idFactura,
                            Convert.ToInt32(row["IdProducto"]),
                            Convert.ToInt32(row["Cantidad"]),
                            Convert.ToDecimal(row["PrecioUnitario"]),
                            Convert.ToDecimal(row["Subtotal"]));
                }

                MessageBox.Show(
                    idFactura == 0 ? "Factura creada correctamente." : "Factura actualizada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar factura: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
