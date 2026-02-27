namespace PantallasSistemaFacturacion
{
    partial class frmRoles
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
            panel3 = new Panel();
            panel2 = new Panel();
            txtDescripcionRol = new TextBox();
            label9 = new Label();
            txtNombreRol = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSalir = new Button();
            txtActualizar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtDescripcionRol);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtNombreRol);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(119, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 370);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Location = new Point(77, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 2);
            panel3.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Location = new Point(77, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 2);
            panel2.TabIndex = 2;
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Font = new Font("Segoe UI", 12F);
            txtDescripcionRol.Location = new Point(77, 221);
            txtDescripcionRol.Multiline = true;
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.Size = new Size(495, 108);
            txtDescripcionRol.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(77, 181);
            label9.Name = "label9";
            label9.Size = new Size(145, 21);
            label9.TabIndex = 22;
            label9.Text = "Descripción Del Rol";
            label9.Click += label9_Click;
            // 
            // txtNombreRol
            // 
            txtNombreRol.BorderStyle = BorderStyle.None;
            txtNombreRol.Font = new Font("Segoe UI", 12F);
            txtNombreRol.Location = new Point(195, 111);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(282, 22);
            txtNombreRol.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(77, 112);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre Del Rol";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(793, 50);
            label1.TabIndex = 1;
            label1.Text = "Rol De Empleados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(592, 461);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 39);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtActualizar
            // 
            txtActualizar.BackColor = Color.SteelBlue;
            txtActualizar.BackgroundImageLayout = ImageLayout.None;
            txtActualizar.FlatStyle = FlatStyle.Flat;
            txtActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizar.ForeColor = SystemColors.ButtonFace;
            txtActualizar.Location = new Point(310, 461);
            txtActualizar.Name = "txtActualizar";
            txtActualizar.Size = new Size(123, 39);
            txtActualizar.TabIndex = 20;
            txtActualizar.Text = "Actualizar";
            txtActualizar.UseVisualStyleBackColor = false;
            // 
            // frmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 587);
            Controls.Add(panel1);
            Controls.Add(txtActualizar);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRoles";
            Text = "frmRoles";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private Button txtActualizar;
        private TextBox txtNombreRol;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcionRol;
        private Label label9;
        private Panel panel2;
        private Panel panel3;
    }
}