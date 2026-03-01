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
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://support.microsoft.com/es-es");
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
