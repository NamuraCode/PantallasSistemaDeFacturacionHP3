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
    public partial class frmLogin : Form
    {
        private readonly DALLogin dalLogin = new DALLogin();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposRequeridos(
                (txtUsuario, "Usuario"),
                (txtcontrasenia, "Contraseña"))) return;

            try
            {
                DataTable resultado = dalLogin.ValidarLogin(
                    txtUsuario.Text.Trim(),
                    txtcontrasenia.Text);

                if (resultado.Rows.Count > 0)
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Validaciones.ResaltarError(txtUsuario);
                    Validaciones.ResaltarError(txtcontrasenia);
                    txtcontrasenia.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
