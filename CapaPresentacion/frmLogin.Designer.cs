
namespace PantallasSistemaFacturacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            txtUsuario = new TextBox();
            txtcontrasenia = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnValidar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 96);
            label1.Name = "label1";
            label1.Size = new Size(106, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ScrollBar;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(428, 196);
            txtUsuario.MinimumSize = new Size(0, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(249, 30);
            txtUsuario.TabIndex = 1;
            // 
            // txtcontrasenia
            // 
            txtcontrasenia.BackColor = SystemColors.ScrollBar;
            txtcontrasenia.BorderStyle = BorderStyle.None;
            txtcontrasenia.Font = new Font("Segoe UI", 12F);
            txtcontrasenia.Location = new Point(428, 252);
            txtcontrasenia.MinimumSize = new Size(0, 30);
            txtcontrasenia.Name = "txtcontrasenia";
            txtcontrasenia.PasswordChar = '*';
            txtcontrasenia.PlaceholderText = "Contraseña";
            txtcontrasenia.Size = new Size(249, 30);
            txtcontrasenia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 138);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 580);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(45, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 299);
            panel2.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = SystemColors.WindowFrame;
            btnValidar.BackgroundImageLayout = ImageLayout.None;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnValidar.ForeColor = SystemColors.ButtonFace;
            btnValidar.Location = new Point(463, 452);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(123, 39);
            btnValidar.TabIndex = 24;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.WindowFrame;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(670, 452);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 39);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(875, 559);
            Controls.Add(btnCancelar);
            Controls.Add(btnValidar);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtcontrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtcontrasenia;
        private Label label2;
        private Panel panel1;
        private Button btnValidar;
        private Button btnCancelar;
        private Panel panel2;
    }
}