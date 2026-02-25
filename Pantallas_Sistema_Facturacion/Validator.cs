using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Pantallas_Sistema_Facturacion
{
    public class Validator
    {
        public Validator() { }
        public bool ValidarCamposTexto(TextBox texto1, ErrorProvider errorProvider)
        {
            bool valido = true;
            // Limpia errores anteriores
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(texto1.Text))
            {
                errorProvider.SetError(texto1, "El campo no puede estar vacío.");
                valido = false;
            }
            return valido;
        }

        public bool ValidarComboBox(ComboBox comboBox, ErrorProvider errorProvider)
        {
            bool valido = true;
            // Limpia errores anteriores
            errorProvider.Clear();
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Debes seleccionar una opción");
                valido = false;
            }
            else
            {
                errorProvider.SetError(comboBox, "");
            }
            return valido;
        }
    }
}
