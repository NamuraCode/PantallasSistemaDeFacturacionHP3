namespace PantallasSistemaFacturacion
{
    partial class frmListaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnEditar = new Button();
            pnlFormulario = new Panel();
            dgvProductos = new DataGridView();
            panel1 = new Panel();
            btnNuevo = new Button();
            btnBuscar = new Button();
            label2 = new Label();
            txtBuscar = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(654, 523);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 39);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.BackgroundImageLayout = ImageLayout.None;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Location = new Point(300, 523);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 39);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.GhostWhite;
            pnlFormulario.BorderStyle = BorderStyle.FixedSingle;
            pnlFormulario.Controls.Add(dgvProductos);
            pnlFormulario.Controls.Add(panel1);
            pnlFormulario.Controls.Add(label1);
            pnlFormulario.Location = new Point(82, 36);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(870, 469);
            pnlFormulario.TabIndex = 20;
            pnlFormulario.Paint += pnlFormulario_Paint;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(0, 142);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(868, 326);
            dgvProductos.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBuscar);
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 92);
            panel1.TabIndex = 17;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.SteelBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevo.ForeColor = SystemColors.ButtonFace;
            btnNuevo.Location = new Point(692, 22);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(123, 39);
            btnNuevo.TabIndex = 24;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(477, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(123, 39);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(27, 31);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(98, 28);
            txtBuscar.Margin = new Padding(0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(325, 29);
            txtBuscar.TabIndex = 6;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(868, 50);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(477, 523);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 39);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // frmListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 587);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnEditar);
            Controls.Add(pnlFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaProductos";
            Text = "frmListaProductos";
            pnlFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnEditar;
        private Panel pnlFormulario;
        private Panel panel1;
        private TextBox txtBuscar;
        private Label label2;
        private Label label1;
        private Button btnNuevo;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private Button btnEliminar;
    }
}