
namespace PantallasSistemaFacturacion
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            pincipalToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoríasToolStripMenuItem = new ToolStripMenuItem();
            facturaciónToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem1 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pnlContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.WindowFrame;
            menuStrip1.Items.AddRange(new ToolStripItem[] { pincipalToolStripMenuItem, tablasToolStripMenuItem, facturaciónToolStripMenuItem, seguridadToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1032, 48);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pincipalToolStripMenuItem
            // 
            pincipalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            pincipalToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            pincipalToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            pincipalToolStripMenuItem.Name = "pincipalToolStripMenuItem";
            pincipalToolStripMenuItem.Size = new Size(80, 44);
            pincipalToolStripMenuItem.Text = "Principal";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            salirToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, categoríasToolStripMenuItem });
            tablasToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tablasToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(63, 44);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            clientesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            productosToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 24);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoríasToolStripMenuItem
            // 
            categoríasToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            categoríasToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            categoríasToolStripMenuItem.Size = new Size(180, 24);
            categoríasToolStripMenuItem.Text = "Categorías";
            categoríasToolStripMenuItem.Click += categoríasToolStripMenuItem_Click;
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturasToolStripMenuItem, informesToolStripMenuItem });
            facturaciónToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            facturaciónToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(98, 44);
            facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            facturasToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(180, 24);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            informesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(180, 24);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.Click += informesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, rolesToolStripMenuItem, seguridadToolStripMenuItem1 });
            seguridadToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            seguridadToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(90, 44);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            empleadosToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(180, 24);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            rolesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(180, 24);
            rolesToolStripMenuItem.Text = "Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem1
            // 
            seguridadToolStripMenuItem1.BackColor = SystemColors.WindowFrame;
            seguridadToolStripMenuItem1.ForeColor = SystemColors.ButtonFace;
            seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            seguridadToolStripMenuItem1.Size = new Size(180, 24);
            seguridadToolStripMenuItem1.Text = "Seguridad";
            seguridadToolStripMenuItem1.Click += seguridadToolStripMenuItem1_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ayudaToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(64, 44);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.BackColor = SystemColors.WindowFrame;
            ayudaToolStripMenuItem1.ForeColor = SystemColors.ButtonFace;
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(180, 24);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            acercaDeToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 24);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = SystemColors.ActiveCaption;
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 48);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1032, 587);
            pnlContenedor.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1032, 635);
            Controls.Add(pnlContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Sistema Facturación";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pincipalToolStripMenuItem;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoríasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem facturaciónToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem1;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Panel pnlContenedor;
    }
}