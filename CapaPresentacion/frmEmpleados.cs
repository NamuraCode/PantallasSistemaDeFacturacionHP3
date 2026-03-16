using CapaDatos;
using System;
using System.Data;
using System.Windows.Forms;

namespace PantallasSistemaFacturacion
{
    public partial class frmEmpleados : Form
    {
        private readonly DALEmpleados dalEmpleados = new DALEmpleados();
        private int _idEmpleado = 0;

        public frmEmpleados()
        {
            InitializeComponent();
            this.Load += frmEmpleados_Load;
        }

        public frmEmpleados(int idEmpleado) : this()
        {
            _idEmpleado = idEmpleado;
        }

        private void frmEmpleados_Load(object? sender, EventArgs e)
        {
            CargarRoles();
            if (_idEmpleado > 0)
            {
                lblTitulo.Text = "Editar Empleado";
                txtGuardar.Text = "Actualizar";
                CargarEmpleado();
            }
            else
            {
                lblTitulo.Text = "Nuevo Empleado";
                txtGuardar.Text = "Guardar";
            }
        }

        private void CargarRoles()
        {
            try
            {
                DataTable dt = dalEmpleados.ListarRoles();
                cmbRol.DataSource    = dt;
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember   = "IdRol";
                cmbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar roles: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEmpleado()
        {
            try
            {
                DataTable dt = dalEmpleados.ObtenerEmpleadoPorId(_idEmpleado);
                if (dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];
                txtNombreEmpleado.Text = row["Nombre"].ToString();
                txtDocumento.Text      = row["Documento"].ToString();
                txtDireccion.Text      = row["Direccion"].ToString();
                txtTelefono.Text       = row["Telefono"].ToString();
                txtEmail.Text          = row["Email"].ToString();
                cmbRol.SelectedValue   = row["IdRol"];
                txtDetalles.Text       = row["Detalles"].ToString();

                if (row["FechaIngreso"] != DBNull.Value)
                    dtpFechaIngreso.Value = Convert.ToDateTime(row["FechaIngreso"]);

                if (row["FechaRetiro"] != DBNull.Value)
                {
                    dtpFechaRetiro.Checked = true;
                    dtpFechaRetiro.Value   = Convert.ToDateTime(row["FechaRetiro"]);
                }
                else
                {
                    dtpFechaRetiro.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposRequeridos(
                (txtNombreEmpleado, "Nombre Empleado"),
                (txtDocumento,      "Documento"))) return;

            if (!Validaciones.EsEmailValido(txtEmail, "Email", false)) return;
            if (!Validaciones.ComboBoxSeleccionado(cmbRol, "Rol")) return;

            try
            {
                string    nombre       = txtNombreEmpleado.Text.Trim();
                string    documento    = txtDocumento.Text.Trim();
                string    direccion    = txtDireccion.Text.Trim();
                string    telefono     = txtTelefono.Text.Trim();
                string    email        = txtEmail.Text.Trim();
                int       idRol        = Convert.ToInt32(cmbRol.SelectedValue);
                DateTime  fechaIngreso = dtpFechaIngreso.Value.Date;
                DateTime? fechaRetiro  = dtpFechaRetiro.Checked ? dtpFechaRetiro.Value.Date : (DateTime?)null;
                string    detalles     = txtDetalles.Text.Trim();

                if (_idEmpleado == 0)
                    dalEmpleados.InsertarEmpleado(nombre, documento, direccion, telefono,
                        email, idRol, fechaIngreso, fechaRetiro, detalles);
                else
                    dalEmpleados.ActualizarEmpleado(_idEmpleado, nombre, documento, direccion,
                        telefono, email, idRol, fechaIngreso, fechaRetiro, detalles);

                MessageBox.Show(
                    _idEmpleado == 0 ? "Empleado creado correctamente." : "Empleado actualizado correctamente.",
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
