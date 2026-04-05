namespace PantallasSistemaFacturacion
{
    partial class frmFacturaEditar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo          = new Label();
            gbDatosFactura     = new GroupBox();
            lblNroFactura      = new Label();
            txtNumeroFactura   = new TextBox();
            lblEmpleado        = new Label();
            cmbEmpleado        = new ComboBox();
            lblCliente         = new Label();
            cmbCliente         = new ComboBox();
            lblFechaFactura    = new Label();
            dtpFechaFactura    = new DateTimePicker();
            lblEstado          = new Label();
            cmbEstado          = new ComboBox();
            gbAgregarProducto  = new GroupBox();
            lblProducto        = new Label();
            cmbProducto        = new ComboBox();
            lblCantidad        = new Label();
            txtCantidad        = new TextBox();
            btnAgregar         = new Button();
            btnQuitarProducto  = new Button();
            gbDetalle          = new GroupBox();
            dgvDetalle         = new DataGridView();
            gbTotales          = new GroupBox();
            lblSubtotalLabel   = new Label();
            lblSubtotalVal     = new Label();
            lblDescuentoLabel  = new Label();
            txtDescuento       = new TextBox();
            lblIVALabel        = new Label();
            lblIVAVal          = new Label();
            lblTotalLabel      = new Label();
            lblTotalVal        = new Label();
            pnlBotones         = new Panel();
            btnGuardar         = new Button();
            btnSalir           = new Button();

            gbDatosFactura.SuspendLayout();
            gbAgregarProducto.SuspendLayout();
            gbDetalle.SuspendLayout();
            gbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            pnlBotones.SuspendLayout();
            SuspendLayout();

            // ── lblTitulo ──────────────────────────────────────────────────
            lblTitulo.Dock      = DockStyle.Top;
            lblTitulo.Font      = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.Location  = new Point(0, 0);
            lblTitulo.Name      = "lblTitulo";
            lblTitulo.Size      = new Size(950, 46);
            lblTitulo.TabIndex  = 0;
            lblTitulo.Text      = "Factura";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // ── gbDatosFactura ─────────────────────────────────────────────
            gbDatosFactura.Controls.Add(lblNroFactura);
            gbDatosFactura.Controls.Add(txtNumeroFactura);
            gbDatosFactura.Controls.Add(lblEmpleado);
            gbDatosFactura.Controls.Add(cmbEmpleado);
            gbDatosFactura.Controls.Add(lblCliente);
            gbDatosFactura.Controls.Add(cmbCliente);
            gbDatosFactura.Controls.Add(lblFechaFactura);
            gbDatosFactura.Controls.Add(dtpFechaFactura);
            gbDatosFactura.Controls.Add(lblEstado);
            gbDatosFactura.Controls.Add(cmbEstado);
            gbDatosFactura.Font     = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbDatosFactura.Location = new Point(10, 52);
            gbDatosFactura.Name     = "gbDatosFactura";
            gbDatosFactura.Size     = new Size(930, 155);
            gbDatosFactura.TabIndex = 1;
            gbDatosFactura.TabStop  = false;
            gbDatosFactura.Text     = "Datos de la Factura";

            // lblNroFactura
            lblNroFactura.AutoSize = true;
            lblNroFactura.Font     = new Font("Segoe UI", 10F);
            lblNroFactura.Location = new Point(15, 32);
            lblNroFactura.Name     = "lblNroFactura";
            lblNroFactura.Size     = new Size(95, 19);
            lblNroFactura.TabIndex = 0;
            lblNroFactura.Text     = "Nro. Factura:";

            // txtNumeroFactura
            txtNumeroFactura.BackColor   = Color.WhiteSmoke;
            txtNumeroFactura.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroFactura.Font        = new Font("Segoe UI", 10F);
            txtNumeroFactura.Location    = new Point(125, 29);
            txtNumeroFactura.Name        = "txtNumeroFactura";
            txtNumeroFactura.ReadOnly    = true;
            txtNumeroFactura.Size        = new Size(140, 25);
            txtNumeroFactura.TabIndex    = 1;

            // lblEmpleado
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font     = new Font("Segoe UI", 10F);
            lblEmpleado.Location = new Point(490, 32);
            lblEmpleado.Name     = "lblEmpleado";
            lblEmpleado.Size     = new Size(71, 19);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text     = "Empleado:";

            // cmbEmpleado
            cmbEmpleado.DropDownStyle     = ComboBoxStyle.DropDownList;
            cmbEmpleado.Font              = new Font("Segoe UI", 10F);
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location          = new Point(575, 29);
            cmbEmpleado.Name              = "cmbEmpleado";
            cmbEmpleado.Size              = new Size(240, 25);
            cmbEmpleado.TabIndex          = 5;

            // lblCliente
            lblCliente.AutoSize = true;
            lblCliente.Font     = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(15, 74);
            lblCliente.Name     = "lblCliente";
            lblCliente.Size     = new Size(57, 19);
            lblCliente.TabIndex = 2;
            lblCliente.Text     = "Cliente:";

            // cmbCliente
            cmbCliente.DropDownStyle     = ComboBoxStyle.DropDownList;
            cmbCliente.Font              = new Font("Segoe UI", 10F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location          = new Point(90, 71);
            cmbCliente.Name              = "cmbCliente";
            cmbCliente.Size              = new Size(310, 25);
            cmbCliente.TabIndex          = 3;

            // lblFechaFactura
            lblFechaFactura.AutoSize = true;
            lblFechaFactura.Font     = new Font("Segoe UI", 10F);
            lblFechaFactura.Location = new Point(490, 74);
            lblFechaFactura.Name     = "lblFechaFactura";
            lblFechaFactura.Size     = new Size(50, 19);
            lblFechaFactura.TabIndex = 6;
            lblFechaFactura.Text     = "Fecha:";

            // dtpFechaFactura
            dtpFechaFactura.Format   = DateTimePickerFormat.Short;
            dtpFechaFactura.Font     = new Font("Segoe UI", 10F);
            dtpFechaFactura.Location = new Point(551, 71);
            dtpFechaFactura.Name     = "dtpFechaFactura";
            dtpFechaFactura.Size     = new Size(160, 25);
            dtpFechaFactura.TabIndex = 7;

            // lblEstado
            lblEstado.AutoSize = true;
            lblEstado.Font     = new Font("Segoe UI", 10F);
            lblEstado.Location = new Point(15, 116);
            lblEstado.Name     = "lblEstado";
            lblEstado.Size     = new Size(55, 19);
            lblEstado.TabIndex = 8;
            lblEstado.Text     = "Estado:";

            // cmbEstado
            cmbEstado.DropDownStyle     = ComboBoxStyle.DropDownList;
            cmbEstado.Font              = new Font("Segoe UI", 10F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location          = new Point(90, 113);
            cmbEstado.Name              = "cmbEstado";
            cmbEstado.Size              = new Size(150, 25);
            cmbEstado.TabIndex          = 9;

            // ── gbAgregarProducto ──────────────────────────────────────────
            gbAgregarProducto.Controls.Add(lblProducto);
            gbAgregarProducto.Controls.Add(cmbProducto);
            gbAgregarProducto.Controls.Add(lblCantidad);
            gbAgregarProducto.Controls.Add(txtCantidad);
            gbAgregarProducto.Controls.Add(btnAgregar);
            gbAgregarProducto.Controls.Add(btnQuitarProducto);
            gbAgregarProducto.Font     = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbAgregarProducto.Location = new Point(10, 217);
            gbAgregarProducto.Name     = "gbAgregarProducto";
            gbAgregarProducto.Size     = new Size(930, 65);
            gbAgregarProducto.TabIndex = 2;
            gbAgregarProducto.TabStop  = false;
            gbAgregarProducto.Text     = "Agregar Producto";

            // lblProducto
            lblProducto.AutoSize = true;
            lblProducto.Font     = new Font("Segoe UI", 10F);
            lblProducto.Location = new Point(15, 30);
            lblProducto.Name     = "lblProducto";
            lblProducto.Size     = new Size(67, 19);
            lblProducto.TabIndex = 0;
            lblProducto.Text     = "Producto:";

            // cmbProducto
            cmbProducto.DropDownStyle     = ComboBoxStyle.DropDownList;
            cmbProducto.Font              = new Font("Segoe UI", 10F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location          = new Point(90, 27);
            cmbProducto.Name              = "cmbProducto";
            cmbProducto.Size              = new Size(320, 25);
            cmbProducto.TabIndex          = 1;

            // lblCantidad
            lblCantidad.AutoSize = true;
            lblCantidad.Font     = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(425, 30);
            lblCantidad.Name     = "lblCantidad";
            lblCantidad.Size     = new Size(65, 19);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text     = "Cantidad:";

            // txtCantidad
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Font        = new Font("Segoe UI", 10F);
            txtCantidad.Location    = new Point(498, 27);
            txtCantidad.Name        = "txtCantidad";
            txtCantidad.Size        = new Size(55, 25);
            txtCantidad.TabIndex    = 3;
            txtCantidad.Text        = "1";
            txtCantidad.TextAlign   = HorizontalAlignment.Center;

            // btnAgregar
            btnAgregar.BackColor            = Color.SteelBlue;
            btnAgregar.FlatStyle            = FlatStyle.Flat;
            btnAgregar.Font                 = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor            = SystemColors.ButtonFace;
            btnAgregar.Location             = new Point(570, 22);
            btnAgregar.Name                 = "btnAgregar";
            btnAgregar.Size                 = new Size(120, 33);
            btnAgregar.TabIndex             = 4;
            btnAgregar.Text                 = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click               += btnAgregar_Click;

            // btnQuitarProducto
            btnQuitarProducto.BackColor            = Color.SteelBlue;
            btnQuitarProducto.FlatStyle            = FlatStyle.Flat;
            btnQuitarProducto.Font                 = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuitarProducto.ForeColor            = SystemColors.ButtonFace;
            btnQuitarProducto.Location             = new Point(705, 22);
            btnQuitarProducto.Name                 = "btnQuitarProducto";
            btnQuitarProducto.Size                 = new Size(130, 33);
            btnQuitarProducto.TabIndex             = 5;
            btnQuitarProducto.Text                 = "Quitar";
            btnQuitarProducto.UseVisualStyleBackColor = false;
            btnQuitarProducto.Click               += btnQuitarProducto_Click;

            // ── gbDetalle ──────────────────────────────────────────────────
            gbDetalle.Controls.Add(dgvDetalle);
            gbDetalle.Font     = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbDetalle.Location = new Point(10, 292);
            gbDetalle.Name     = "gbDetalle";
            gbDetalle.Size     = new Size(930, 185);
            gbDetalle.TabIndex = 3;
            gbDetalle.TabStop  = false;
            gbDetalle.Text     = "Detalle de Factura";

            // dgvDetalle
            dgvDetalle.AllowUserToAddRows          = false;
            dgvDetalle.AutoSizeColumnsMode         = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor             = Color.White;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location      = new Point(10, 25);
            dgvDetalle.MultiSelect   = false;
            dgvDetalle.Name          = "dgvDetalle";
            dgvDetalle.ReadOnly      = true;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size          = new Size(910, 148);
            dgvDetalle.TabIndex      = 0;

            // ── gbTotales ──────────────────────────────────────────────────
            gbTotales.Controls.Add(lblSubtotalLabel);
            gbTotales.Controls.Add(lblSubtotalVal);
            gbTotales.Controls.Add(lblDescuentoLabel);
            gbTotales.Controls.Add(txtDescuento);
            gbTotales.Controls.Add(lblIVALabel);
            gbTotales.Controls.Add(lblIVAVal);
            gbTotales.Controls.Add(lblTotalLabel);
            gbTotales.Controls.Add(lblTotalVal);
            gbTotales.Font     = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbTotales.Location = new Point(10, 487);
            gbTotales.Name     = "gbTotales";
            gbTotales.Size     = new Size(930, 110);
            gbTotales.TabIndex = 4;
            gbTotales.TabStop  = false;
            gbTotales.Text     = "Totales";

            // lblSubtotalLabel
            lblSubtotalLabel.AutoSize = true;
            lblSubtotalLabel.Font     = new Font("Segoe UI", 10F);
            lblSubtotalLabel.Location = new Point(15, 32);
            lblSubtotalLabel.Name     = "lblSubtotalLabel";
            lblSubtotalLabel.TabIndex = 0;
            lblSubtotalLabel.Text     = "Subtotal $:";

            // lblSubtotalVal
            lblSubtotalVal.AutoSize  = true;
            lblSubtotalVal.Font      = new Font("Segoe UI", 10F);
            lblSubtotalVal.ForeColor = Color.DimGray;
            lblSubtotalVal.Location  = new Point(200, 32);
            lblSubtotalVal.Name      = "lblSubtotalVal";
            lblSubtotalVal.TabIndex  = 1;
            lblSubtotalVal.Text      = "0.00";

            // lblDescuentoLabel
            lblDescuentoLabel.AutoSize = true;
            lblDescuentoLabel.Font     = new Font("Segoe UI", 10F);
            lblDescuentoLabel.Location = new Point(15, 68);
            lblDescuentoLabel.Name     = "lblDescuentoLabel";
            lblDescuentoLabel.TabIndex = 2;
            lblDescuentoLabel.Text     = "Descuento $:";

            // txtDescuento
            txtDescuento.BorderStyle = BorderStyle.FixedSingle;
            txtDescuento.Font        = new Font("Segoe UI", 10F);
            txtDescuento.Location    = new Point(130, 65);
            txtDescuento.Name        = "txtDescuento";
            txtDescuento.Size        = new Size(80, 25);
            txtDescuento.TabIndex    = 3;
            txtDescuento.Text        = "0";
            txtDescuento.TextChanged += txtDescuento_TextChanged;

            // lblIVALabel
            lblIVALabel.AutoSize = true;
            lblIVALabel.Font     = new Font("Segoe UI", 10F);
            lblIVALabel.Location = new Point(500, 32);
            lblIVALabel.Name     = "lblIVALabel";
            lblIVALabel.TabIndex = 4;
            lblIVALabel.Text     = "IVA (19%):";

            // lblIVAVal
            lblIVAVal.AutoSize  = true;
            lblIVAVal.Font      = new Font("Segoe UI", 10F);
            lblIVAVal.ForeColor = Color.DimGray;
            lblIVAVal.Location  = new Point(640, 32);
            lblIVAVal.Name      = "lblIVAVal";
            lblIVAVal.TabIndex  = 5;
            lblIVAVal.Text      = "0.00";

            // lblTotalLabel
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font     = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalLabel.Location = new Point(500, 62);
            lblTotalLabel.Name     = "lblTotalLabel";
            lblTotalLabel.TabIndex = 6;
            lblTotalLabel.Text     = "TOTAL:";

            // lblTotalVal
            lblTotalVal.AutoSize  = true;
            lblTotalVal.Font      = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.SteelBlue;
            lblTotalVal.Location  = new Point(640, 62);
            lblTotalVal.Name      = "lblTotalVal";
            lblTotalVal.TabIndex  = 7;
            lblTotalVal.Text      = "0.00";

            // ── pnlBotones ─────────────────────────────────────────────────
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnSalir);
            pnlBotones.Dock     = DockStyle.Bottom;
            pnlBotones.Location = new Point(0, 612);
            pnlBotones.Name     = "pnlBotones";
            pnlBotones.Size     = new Size(950, 63);
            pnlBotones.TabIndex = 5;

            // btnGuardar
            btnGuardar.BackColor            = Color.SteelBlue;
            btnGuardar.FlatStyle            = FlatStyle.Flat;
            btnGuardar.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor            = SystemColors.ButtonFace;
            btnGuardar.Location             = new Point(590, 12);
            btnGuardar.Name                 = "btnGuardar";
            btnGuardar.Size                 = new Size(140, 39);
            btnGuardar.TabIndex             = 0;
            btnGuardar.Text                 = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click               += btnGuardar_Click;

            // btnSalir
            btnSalir.BackColor            = Color.SteelBlue;
            btnSalir.FlatStyle            = FlatStyle.Flat;
            btnSalir.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor            = SystemColors.ButtonFace;
            btnSalir.Location             = new Point(748, 12);
            btnSalir.Name                 = "btnSalir";
            btnSalir.Size                 = new Size(123, 39);
            btnSalir.TabIndex             = 1;
            btnSalir.Text                 = "Cancelar";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click               += btnSalir_Click;

            // ── frmFacturaEditar ───────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(950, 675);
            Controls.Add(pnlBotones);
            Controls.Add(gbTotales);
            Controls.Add(gbDetalle);
            Controls.Add(gbAgregarProducto);
            Controls.Add(gbDatosFactura);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            MinimizeBox     = false;
            Name            = "frmFacturaEditar";
            StartPosition   = FormStartPosition.CenterParent;
            Text            = "Factura";

            gbDatosFactura.ResumeLayout(false);
            gbDatosFactura.PerformLayout();
            gbAgregarProducto.ResumeLayout(false);
            gbAgregarProducto.PerformLayout();
            gbDetalle.ResumeLayout(false);
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            pnlBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label          lblTitulo;
        private GroupBox       gbDatosFactura;
        private Label          lblNroFactura;
        private TextBox        txtNumeroFactura;
        private Label          lblEmpleado;
        private ComboBox       cmbEmpleado;
        private Label          lblCliente;
        private ComboBox       cmbCliente;
        private Label          lblFechaFactura;
        private DateTimePicker dtpFechaFactura;
        private Label          lblEstado;
        private ComboBox       cmbEstado;
        private GroupBox       gbAgregarProducto;
        private Label          lblProducto;
        private ComboBox       cmbProducto;
        private Label          lblCantidad;
        private TextBox        txtCantidad;
        private Button         btnAgregar;
        private Button         btnQuitarProducto;
        private GroupBox       gbDetalle;
        private DataGridView   dgvDetalle;
        private GroupBox       gbTotales;
        private Label          lblSubtotalLabel;
        private Label          lblSubtotalVal;
        private Label          lblDescuentoLabel;
        private TextBox        txtDescuento;
        private Label          lblIVALabel;
        private Label          lblIVAVal;
        private Label          lblTotalLabel;
        private Label          lblTotalVal;
        private Panel          pnlBotones;
        private Button         btnGuardar;
        private Button         btnSalir;
    }
}
