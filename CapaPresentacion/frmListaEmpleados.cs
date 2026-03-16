using CapaDatos;
using System;
using System.Windows.Forms;

namespace PantallasSistemaFacturacion
{
    public partial class frmListaEmpleados : Form
    {
        private readonly DALEmpleados dalEmpleados = new DALEmpleados();

        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void frmListaEmpleados_Load(object? sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = dalEmpleados.ListarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                    dgvEmpleados.DataSource = dalEmpleados.ListarEmpleados();
                else
                    dgvEmpleados.DataSource = dalEmpleados.BuscarEmpleados(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var f = new frmEmpleados())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    CargarEmpleados();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado de la lista para editar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value);
            using (var f = new frmEmpleados(id))
            {
                if (f.ShowDialog() == DialogResult.OK)
                    CargarEmpleados();
            }
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado de la lista para eliminarlo.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Está seguro de que desea eliminar este empleado?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value);
                dalEmpleados.EliminarEmpleado(id);
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
