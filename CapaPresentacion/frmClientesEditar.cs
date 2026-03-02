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
    public partial class frmClientesEditar : Form
    {
        private readonly DALClientes dalClientes = new DALClientes();
        private int idCliente = 0; // 0 = nuevo, >0 = editar

        // Constructor para nuevo cliente
        public frmClientesEditar()
        {
            InitializeComponent();
            btnActualizar.Click += btnActualizar_Click;
            groupBox1.Text = "Nuevo Cliente";
        }

        // Constructor para editar cliente existente
        public frmClientesEditar(int idCliente) : this()
        {
            this.idCliente = idCliente;
            groupBox1.Text = "Editar Cliente";
            CargarCliente();
        }

        private void CargarCliente()
        {
            try
            {
                DataTable dt = dalClientes.ObtenerClientePorId(idCliente);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtNombre.Text    = row["Nombre"].ToString();
                    txtDocumento.Text = row["Documento"].ToString();
                    txtDireccion.Text = row["Direccion"].ToString();
                    txtCorreo.Text    = row["Correo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cliente: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposRequeridos(
                (txtNombre, "Nombre"),
                (txtDocumento, "Documento"))) return;

            if (!Validaciones.EsEmailValido(txtCorreo, "Correo")) return;

            try
            {
                if (idCliente == 0)
                    dalClientes.InsertarCliente(
                        txtNombre.Text.Trim(),
                        txtDocumento.Text.Trim(),
                        txtDireccion.Text.Trim(),
                        txtCorreo.Text.Trim());
                else
                    dalClientes.ActualizarCliente(
                        idCliente,
                        txtNombre.Text.Trim(),
                        txtDocumento.Text.Trim(),
                        txtDireccion.Text.Trim(),
                        txtCorreo.Text.Trim());

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}
