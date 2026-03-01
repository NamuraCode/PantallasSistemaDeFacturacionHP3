namespace PantallasSistemaFacturacion
{
    partial class frmProductos
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
            pnlBase = new Panel();
            btnSalir = new Button();
            btnGuardar = new Button();
            pnlFormulario = new Panel();
            txtDetallesProducto = new TextBox();
            label9 = new Label();
            txtRutaImagen = new TextBox();
            label8 = new Label();
            cmbCategoria = new ComboBox();
            label7 = new Label();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtPrecioCompra = new TextBox();
            txtCodigo = new TextBox();
            txtNombreProducto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlBase.SuspendLayout();
            pnlFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlBase.Controls.Add(btnSalir);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(pnlFormulario);
            pnlBase.Location = new Point(0, 0);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1032, 587);
            pnlBase.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(608, 516);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 39);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(289, 516);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 39);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.GhostWhite;
            pnlFormulario.BorderStyle = BorderStyle.FixedSingle;
            pnlFormulario.Controls.Add(txtDetallesProducto);
            pnlFormulario.Controls.Add(label9);
            pnlFormulario.Controls.Add(txtRutaImagen);
            pnlFormulario.Controls.Add(label8);
            pnlFormulario.Controls.Add(cmbCategoria);
            pnlFormulario.Controls.Add(label7);
            pnlFormulario.Controls.Add(txtStock);
            pnlFormulario.Controls.Add(txtPrecioVenta);
            pnlFormulario.Controls.Add(txtPrecioCompra);
            pnlFormulario.Controls.Add(txtCodigo);
            pnlFormulario.Controls.Add(txtNombreProducto);
            pnlFormulario.Controls.Add(label6);
            pnlFormulario.Controls.Add(label5);
            pnlFormulario.Controls.Add(label4);
            pnlFormulario.Controls.Add(label3);
            pnlFormulario.Controls.Add(label2);
            pnlFormulario.Controls.Add(label1);
            pnlFormulario.Location = new Point(125, 39);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(795, 453);
            pnlFormulario.TabIndex = 0;
            // 
            // txtDetallesProducto
            // 
            txtDetallesProducto.Font = new Font("Segoe UI", 12F);
            txtDetallesProducto.Location = new Point(441, 277);
            txtDetallesProducto.Multiline = true;
            txtDetallesProducto.Name = "txtDetallesProducto";
            txtDetallesProducto.Size = new Size(240, 100);
            txtDetallesProducto.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(441, 234);
            label9.Name = "label9";
            label9.Size = new Size(132, 21);
            label9.TabIndex = 15;
            label9.Text = "Detalles Producto";
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Font = new Font("Segoe UI", 12F);
            txtRutaImagen.Location = new Point(545, 180);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.Size = new Size(136, 29);
            txtRutaImagen.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(441, 180);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 13;
            label8.Text = "Ruta Imagen";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(545, 84);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(136, 29);
            cmbCategoria.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(441, 87);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 11;
            label7.Text = "Categoría";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.Location = new Point(193, 306);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(163, 29);
            txtStock.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Font = new Font("Segoe UI", 12F);
            txtPrecioVenta.Location = new Point(192, 252);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(163, 29);
            txtPrecioVenta.TabIndex = 9;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Font = new Font("Segoe UI", 12F);
            txtPrecioCompra.Location = new Point(192, 197);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(163, 29);
            txtPrecioCompra.TabIndex = 8;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(193, 142);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(163, 29);
            txtCodigo.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Cursor = Cursors.IBeam;
            txtNombreProducto.Font = new Font("Segoe UI", 12F);
            txtNombreProducto.Location = new Point(192, 88);
            txtNombreProducto.Margin = new Padding(0);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(163, 29);
            txtNombreProducto.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(38, 309);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 5;
            label6.Text = "Cantidad Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(38, 260);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 4;
            label5.Text = "Precio Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(38, 205);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 3;
            label4.Text = "Precio Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(38, 142);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 2;
            label3.Text = "Código Referencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre Producto ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(793, 50);
            label1.TabIndex = 0;
            label1.Text = "Administración De Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 587);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            Text = "frmProductos";
            pnlBase.ResumeLayout(false);
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Panel pnlFormulario;
        private Label label1;
        private Label label7;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private TextBox txtCodigo;
        private TextBox txtNombreProducto;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDetallesProducto;
        private Label label9;
        private TextBox txtRutaImagen;
        private Label label8;
        private ComboBox cmbCategoria;
        private Button btnSalir;
        private Button btnGuardar;
    }
}