using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace PantallasSistemaFacturacion
{
    public partial class frmFacturas : Form
    {
        private readonly DALFacturas dalFacturas = new DALFacturas();

        public frmFacturas()
        {
            InitializeComponent();
            this.Load        += frmFacturas_Load;
            btnBuscar.Click  += btnBuscar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
        }

        private void frmFacturas_Load(object? sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            try
            {
                dgvFacturas.DataSource = dalFacturas.ListarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar facturas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                    dgvFacturas.DataSource = dalFacturas.ListarFacturas();
                else
                    dgvFacturas.DataSource = dalFacturas.BuscarFacturas(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarFacturas();
        }

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            using (var f = new frmFacturaEditar())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    CargarFacturas();
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura de la lista para editar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvFacturas.SelectedRows[0].Cells["IdFactura"].Value);
            using (var f = new frmFacturaEditar(id))
            {
                if (f.ShowDialog() == DialogResult.OK)
                    CargarFacturas();
            }
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura de la lista para eliminarla.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("¿Está seguro de que desea eliminar esta factura?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgvFacturas.SelectedRows[0].Cells["IdFactura"].Value);
                dalFacturas.EliminarFactura(id);
                CargarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
