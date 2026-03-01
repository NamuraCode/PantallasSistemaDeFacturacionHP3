namespace PantallasSistemaFacturacion
{
    partial class frmAcercaDe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            this.btnAceptar = new Button();
            label1 = new Label();
            textBox5 = new TextBox();
            btnCopiarInfo = new Button();
            this.btnInfoSistema = new Button();
            lvwProductosInstalados = new ListView();
            Producto = new ColumnHeader();
            Version = new ColumnHeader();
            pnlDetalle = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlDetalle);
            panel1.Controls.Add(lvwProductosInstalados);
            panel1.Controls.Add(this.btnInfoSistema);
            panel1.Controls.Add(btnCopiarInfo);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(this.btnAceptar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 563);
            panel1.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonFace;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 9F);
            textBox4.ForeColor = Color.SteelBlue;
            textBox4.Location = new Point(795, 53);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 91);
            textBox4.TabIndex = 35;
            textBox4.Text = "Información de licencia                        Términos de licencia";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 9F);
            textBox3.Location = new Point(48, 186);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 21);
            textBox3.TabIndex = 34;
            textBox3.Text = "Productos instalados:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(521, 98);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 91);
            textBox2.TabIndex = 33;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(48, 98);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 91);
            textBox1.TabIndex = 32;
            textBox1.Text = "Microsoft Visual Studio Community 2022 Versión 17.12.0                                                   © 2022 Microsoft Corporation                          Todos los derechos reservados";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = Color.White;
            this.btnAceptar.FlatStyle = FlatStyle.Flat;
            this.btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnAceptar.ForeColor = Color.SteelBlue;
            this.btnAceptar.Location = new Point(795, 504);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new Size(123, 30);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += this.btnSalir_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1008, 50);
            label1.TabIndex = 1;
            label1.Text = "Administración De Usuarios Del Sistema";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 9F);
            textBox5.Location = new Point(49, 377);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(240, 21);
            textBox5.TabIndex = 36;
            textBox5.Text = "Detalles del producto:";
            // 
            // btnCopiarInfo
            // 
            btnCopiarInfo.BackColor = Color.White;
            btnCopiarInfo.FlatStyle = FlatStyle.Flat;
            btnCopiarInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiarInfo.ForeColor = Color.SteelBlue;
            btnCopiarInfo.Location = new Point(795, 207);
            btnCopiarInfo.Name = "btnCopiarInfo";
            btnCopiarInfo.Size = new Size(193, 30);
            btnCopiarInfo.TabIndex = 39;
            btnCopiarInfo.Text = "Copiar información";
            btnCopiarInfo.UseVisualStyleBackColor = false;
            btnCopiarInfo.Click += btnCopiarInfo_Click;
            // 
            // btnInfoSistema
            // 
            this.btnInfoSistema.BackColor = Color.White;
            this.btnInfoSistema.FlatStyle = FlatStyle.Flat;
            this.btnInfoSistema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnInfoSistema.ForeColor = Color.SteelBlue;
            this.btnInfoSistema.Location = new Point(795, 243);
            this.btnInfoSistema.Name = "btnInfoSistema";
            this.btnInfoSistema.Size = new Size(193, 30);
            this.btnInfoSistema.TabIndex = 40;
            this.btnInfoSistema.Text = "Info. del sistema";
            this.btnInfoSistema.UseVisualStyleBackColor = false;
            this.btnInfoSistema.Click += this.btnInfoSistema_Click;
            // 
            // lvwProductosInstalados
            // 
            lvwProductosInstalados.Columns.AddRange(new ColumnHeader[] { Producto, Version });
            lvwProductosInstalados.FullRowSelect = true;
            lvwProductosInstalados.Location = new Point(48, 207);
            lvwProductosInstalados.MultiSelect = false;
            lvwProductosInstalados.Name = "lvwProductosInstalados";
            lvwProductosInstalados.Size = new Size(741, 149);
            lvwProductosInstalados.TabIndex = 42;
            lvwProductosInstalados.UseCompatibleStateImageBehavior = false;
            lvwProductosInstalados.View = View.Details;
            lvwProductosInstalados.SelectedIndexChanged += lvwProductosInstalados_SelectedIndexChanged;
            // 
            // Producto
            // 
            Producto.Text = "Visual C++ 2017 - ";
            Producto.Width = 120;
            // 
            // Version
            // 
            Version.Text = "Administrador de paquetes NuGet ";
            Version.Width = 250;
            // 
            // pnlDetalle
            // 
            pnlDetalle.BorderStyle = BorderStyle.FixedSingle;
            pnlDetalle.Location = new Point(49, 395);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(740, 80);
            pnlDetalle.TabIndex = 43;
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 587);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAcercaDe";
            Text = "Form1";
            Load += frmAcercaDe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private Label label1;
        private TextBox textBox1;
        private Button btnAceptar;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button3;
        private Button button2;
        private Button btnCopiarInfo;
        private Button btnInfoSistema;
        private ListView lvwProductosInstalados;
        private ColumnHeader Producto;
        private ColumnHeader Version;
        private Panel pnlDetalle;
    }
}
