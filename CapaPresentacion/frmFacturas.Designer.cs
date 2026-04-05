namespace PantallasSistemaFacturacion
{
    partial class frmFacturas
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
            panel1    = new Panel();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            btnBuscar    = new Button();
            btnActualizar = new Button();
            btnNuevo     = new Button();
            dgvFacturas  = new DataGridView();
            panel2       = new Panel();
            btnSalir     = new Button();
            btnEliminar  = new Button();
            btnEditar    = new Button();

            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();

            // panel1 - barra superior
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(lblBuscar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock     = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name     = "panel1";
            panel1.Size     = new Size(1032, 74);
            panel1.TabIndex = 0;

            // txtBuscar
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location    = new Point(109, 23);
            txtBuscar.Name        = "txtBuscar";
            txtBuscar.Size        = new Size(311, 23);
            txtBuscar.TabIndex    = 1;

            // lblBuscar
            lblBuscar.AutoSize = true;
            lblBuscar.Font     = new Font("Segoe UI", 13F);
            lblBuscar.Location = new Point(27, 23);
            lblBuscar.Name     = "lblBuscar";
            lblBuscar.TabIndex = 0;
            lblBuscar.Text     = "Buscar";

            // btnBuscar
            btnBuscar.BackColor            = Color.SteelBlue;
            btnBuscar.FlatStyle            = FlatStyle.Flat;
            btnBuscar.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor            = SystemColors.ButtonFace;
            btnBuscar.Location             = new Point(453, 16);
            btnBuscar.Name                 = "btnBuscar";
            btnBuscar.Size                 = new Size(123, 39);
            btnBuscar.TabIndex             = 2;
            btnBuscar.Text                 = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;

            // btnNuevo
            btnNuevo.BackColor            = Color.SteelBlue;
            btnNuevo.FlatStyle            = FlatStyle.Flat;
            btnNuevo.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevo.ForeColor            = SystemColors.ButtonFace;
            btnNuevo.Location             = new Point(657, 16);
            btnNuevo.Name                 = "btnNuevo";
            btnNuevo.Size                 = new Size(123, 39);
            btnNuevo.TabIndex             = 3;
            btnNuevo.Text                 = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click               += btnNuevo_Click;

            // btnActualizar
            btnActualizar.BackColor            = Color.SteelBlue;
            btnActualizar.FlatStyle            = FlatStyle.Flat;
            btnActualizar.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnActualizar.ForeColor            = SystemColors.ButtonFace;
            btnActualizar.Location             = new Point(846, 16);
            btnActualizar.Name                 = "btnActualizar";
            btnActualizar.Size                 = new Size(123, 39);
            btnActualizar.TabIndex             = 4;
            btnActualizar.Text                 = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;

            // dgvFacturas
            dgvFacturas.AllowUserToAddRows          = false;
            dgvFacturas.AutoSizeColumnsMode         = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturas.BackgroundColor             = SystemColors.ButtonFace;
            dgvFacturas.BorderStyle                 = BorderStyle.None;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Dock            = DockStyle.Fill;
            dgvFacturas.Location        = new Point(0, 74);
            dgvFacturas.MultiSelect     = false;
            dgvFacturas.Name            = "dgvFacturas";
            dgvFacturas.ReadOnly        = true;
            dgvFacturas.SelectionMode   = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size            = new Size(1032, 441);
            dgvFacturas.TabIndex        = 1;

            // panel2 - barra inferior
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Dock     = DockStyle.Bottom;
            panel2.Location = new Point(0, 515);
            panel2.Name     = "panel2";
            panel2.Size     = new Size(1032, 72);
            panel2.TabIndex = 2;

            // btnEditar
            btnEditar.BackColor            = Color.SteelBlue;
            btnEditar.FlatStyle            = FlatStyle.Flat;
            btnEditar.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor            = SystemColors.ButtonFace;
            btnEditar.Location             = new Point(469, 16);
            btnEditar.Name                 = "btnEditar";
            btnEditar.Size                 = new Size(123, 39);
            btnEditar.TabIndex             = 1;
            btnEditar.Text                 = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click               += btnEditar_Click;

            // btnEliminar
            btnEliminar.BackColor            = Color.SteelBlue;
            btnEliminar.FlatStyle            = FlatStyle.Flat;
            btnEliminar.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor            = SystemColors.ButtonFace;
            btnEliminar.Location             = new Point(282, 16);
            btnEliminar.Name                 = "btnEliminar";
            btnEliminar.Size                 = new Size(123, 39);
            btnEliminar.TabIndex             = 2;
            btnEliminar.Text                 = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;

            // btnSalir
            btnSalir.BackColor            = Color.SteelBlue;
            btnSalir.FlatStyle            = FlatStyle.Flat;
            btnSalir.Font                 = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor            = SystemColors.ButtonFace;
            btnSalir.Location             = new Point(657, 16);
            btnSalir.Name                 = "btnSalir";
            btnSalir.Size                 = new Size(123, 39);
            btnSalir.TabIndex             = 3;
            btnSalir.Text                 = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click               += btnSalir_Click;

            // frmFacturas
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(1032, 587);
            Controls.Add(panel2);
            Controls.Add(dgvFacturas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name            = "frmFacturas";
            Text            = "Gestión de Facturas";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel          panel1;
        private Label          lblBuscar;
        private TextBox        txtBuscar;
        private Button         btnBuscar;
        private Button         btnActualizar;
        private Button         btnNuevo;
        private DataGridView   dgvFacturas;
        private Panel          panel2;
        private Button         btnEditar;
        private Button         btnEliminar;
        private Button         btnSalir;
    }
}
