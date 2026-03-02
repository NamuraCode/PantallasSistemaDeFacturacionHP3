using System.Text.RegularExpressions;

namespace PantallasSistemaFacturacion
{
    internal static class Validaciones
    {
        // ─── Campos de texto ────────────────────────────────────────────────

        /// <summary>Verifica que un TextBox no esté vacío.</summary>
        public static bool CampoVacio(TextBox campo)
        {
            return string.IsNullOrWhiteSpace(campo.Text);
        }

        /// <summary>
        /// Valida una lista de TextBox obligatorios.
        /// Resalta en rojo los que estén vacíos y muestra un mensaje.
        /// Retorna true si todos son válidos.
        /// </summary>
        public static bool ValidarCamposRequeridos(params (TextBox Campo, string Nombre)[] campos)
        {
            bool valido = true;
            List<string> vacios = new();

            foreach (var (campo, nombre) in campos)
            {
                if (CampoVacio(campo))
                {
                    ResaltarError(campo);
                    vacios.Add(nombre);
                    valido = false;
                }
                else
                {
                    LimpiarError(campo);
                }
            }

            if (!valido)
                MostrarErrorCampos(vacios);

            return valido;
        }

        // ─── Campos numéricos ────────────────────────────────────────────────

        /// <summary>
        /// Verifica que el texto del campo sea un decimal válido y mayor a cero.
        /// Retorna true si es válido.
        /// </summary>
        public static bool EsDecimalValido(TextBox campo, string nombre, out decimal valor)
        {
            if (!decimal.TryParse(campo.Text.Trim(), out valor) || valor <= 0)
            {
                ResaltarError(campo);
                MessageBox.Show($"El campo '{nombre}' debe ser un número mayor a 0.",
                    "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            LimpiarError(campo);
            return true;
        }

        /// <summary>
        /// Verifica que el texto del campo sea un entero válido y mayor o igual a cero.
        /// Retorna true si es válido.
        /// </summary>
        public static bool EsEnteroValido(TextBox campo, string nombre, out int valor)
        {
            if (!int.TryParse(campo.Text.Trim(), out valor) || valor < 0)
            {
                ResaltarError(campo);
                MessageBox.Show($"El campo '{nombre}' debe ser un número entero mayor o igual a 0.",
                    "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            LimpiarError(campo);
            return true;
        }

        // ─── ComboBox ────────────────────────────────────────────────────────

        /// <summary>
        /// Verifica que el ComboBox tenga un elemento seleccionado.
        /// Retorna true si es válido.
        /// </summary>
        public static bool ComboBoxSeleccionado(ComboBox combo, string nombre)
        {
            if (combo.SelectedIndex < 0)
            {
                combo.BackColor = Color.MistyRose;
                MessageBox.Show($"Debe seleccionar un valor en '{nombre}'.",
                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            combo.BackColor = SystemColors.Window;
            return true;
        }

        // ─── Email ───────────────────────────────────────────────────────────

        /// <summary>
        /// Verifica que el campo tenga formato de email válido.
        /// Permite campo vacío si no es obligatorio.
        /// Retorna true si es válido.
        /// </summary>
        public static bool EsEmailValido(TextBox campo, string nombre, bool obligatorio = false)
        {
            string texto = campo.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                if (obligatorio)
                {
                    ResaltarError(campo);
                    MessageBox.Show($"El campo '{nombre}' es obligatorio.",
                        "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }

            bool formato = Regex.IsMatch(texto, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!formato)
            {
                ResaltarError(campo);
                MessageBox.Show($"El campo '{nombre}' no tiene un formato de correo válido.",
                    "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            LimpiarError(campo);
            return true;
        }

        // ─── Contraseña ──────────────────────────────────────────────────────

        /// <summary>
        /// Verifica que la contraseña tenga al menos la longitud mínima indicada.
        /// Retorna true si es válida.
        /// </summary>
        public static bool EsClaveValida(TextBox campo, int longitudMinima = 6)
        {
            if (campo.Text.Length < longitudMinima)
            {
                ResaltarError(campo);
                MessageBox.Show($"La contraseña debe tener al menos {longitudMinima} caracteres.",
                    "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            LimpiarError(campo);
            return true;
        }

        // ─── Resaltado visual ────────────────────────────────────────────────

        /// <summary>Marca el campo con fondo rojo claro para indicar error.</summary>
        public static void ResaltarError(TextBox campo)
        {
            campo.BackColor = Color.MistyRose;
        }

        /// <summary>Restaura el fondo original del campo.</summary>
        public static void LimpiarError(TextBox campo)
        {
            campo.BackColor = SystemColors.Window;
        }

        /// <summary>Limpia el resaltado de error de todos los campos indicados.</summary>
        public static void LimpiarTodos(params TextBox[] campos)
        {
            foreach (var campo in campos)
                LimpiarError(campo);
        }

        // ─── Helpers internos ────────────────────────────────────────────────

        private static void MostrarErrorCampos(List<string> nombres)
        {
            string lista = string.Join("\n  - ", nombres);
            MessageBox.Show($"Los siguientes campos son obligatorios:\n  - {lista}",
                "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
