namespace PantallasSistemaFacturacion
{
    partial class frmInformes
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
            btnGenerar = new Button();
            pnlFormulario = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(552, 290);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 39);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.SteelBlue;
            btnGenerar.BackgroundImageLayout = ImageLayout.None;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerar.ForeColor = SystemColors.ButtonFace;
            btnGenerar.Location = new Point(326, 290);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(123, 39);
            btnGenerar.TabIndex = 21;
            btnGenerar.Text = "Generar Informe";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.GhostWhite;
            pnlFormulario.BorderStyle = BorderStyle.FixedSingle;
            pnlFormulario.Controls.Add(radioButton3);
            pnlFormulario.Controls.Add(radioButton2);
            pnlFormulario.Controls.Add(radioButton1);
            pnlFormulario.Controls.Add(dateTimePicker2);
            pnlFormulario.Controls.Add(label4);
            pnlFormulario.Controls.Add(dateTimePicker1);
            pnlFormulario.Controls.Add(label3);
            pnlFormulario.Controls.Add(comboBox1);
            pnlFormulario.Controls.Add(label2);
            pnlFormulario.Controls.Add(cmbCategoria);
            pnlFormulario.Controls.Add(label7);
            pnlFormulario.Controls.Add(label1);
            pnlFormulario.Location = new Point(119, 35);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(798, 239);
            pnlFormulario.TabIndex = 20;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(482, 198);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(52, 19);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.Text = "Excel";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(361, 198);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 19);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "PDF";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(206, 198);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "En Pantalla";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(498, 139);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(137, 23);
            dateTimePicker2.TabIndex = 22;
            dateTimePicker2.Value = new DateTime(2026, 2, 25, 21, 45, 33, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(390, 139);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 21;
            label4.Text = "Fecha Final";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(224, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 23);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2026, 2, 25, 21, 45, 33, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(121, 139);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 19;
            label3.Text = "Fecha Inicio";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(583, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 29);
            comboBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(482, 81);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 17;
            label2.Text = "Ordenar Por";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(215, 78);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(210, 29);
            cmbCategoria.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(38, 81);
            label7.Name = "label7";
            label7.Size = new Size(171, 21);
            label7.TabIndex = 11;
            label7.Text = "SELECCIONE INFORME";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(796, 50);
            label1.TabIndex = 0;
            label1.Text = "Generador De Informes De Facturación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(82, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(870, 216);
            dataGridView1.TabIndex = 23;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 587);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(pnlFormulario);
            Controls.Add(btnGenerar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInformes";
            Text = "frmInformes";
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnGenerar;
        private Panel pnlFormulario;
        private ComboBox cmbCategoria;
        private Label label7;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridView dataGridView1;
    }
}