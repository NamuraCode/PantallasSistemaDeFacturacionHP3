namespace PantallasSistemaFacturacion
{
    partial class frmCategoriasProductos
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
            panel1 = new Panel();
            btnSalir = new Button();
            btnActualizar = new Button();
            txtNombreCategoria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(txtNombreCategoria);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(119, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 453);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(495, 365);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 39);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SteelBlue;
            btnActualizar.BackgroundImageLayout = ImageLayout.None;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(184, 365);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(123, 39);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.BorderStyle = BorderStyle.None;
            txtNombreCategoria.Font = new Font("Segoe UI", 14F);
            txtNombreCategoria.Location = new Point(203, 139);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(283, 25);
            txtNombreCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(39, 142);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre Categoría";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(793, 50);
            label1.TabIndex = 1;
            label1.Text = "Categoría Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Font = new Font("Segoe UI", 15F);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(39, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 2);
            panel3.TabIndex = 26;
            // 
            // frmCategoriasProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 587);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoriasProductos";
            Text = "frmCategorias";
            Load += frmCategoriasProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtNombreCategoria;
        private Button btnSalir;
        private Button btnActualizar;
        private Panel panel3;
    }
}