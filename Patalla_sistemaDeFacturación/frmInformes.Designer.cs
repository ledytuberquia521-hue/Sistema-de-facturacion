namespace Patalla_sistemaDeFacturación
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
            this.components = new System.ComponentModel.Container();
            this.TITULO = new System.Windows.Forms.Label();
            this.labelSelecInforme = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.comboSelectInforme = new System.Windows.Forms.ComboBox();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButtonEnPantalla = new System.Windows.Forms.RadioButton();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonExcel = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.Location = new System.Drawing.Point(170, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TITULO.Size = new System.Drawing.Size(427, 20);
            this.TITULO.TabIndex = 2;
            this.TITULO.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // labelSelecInforme
            // 
            this.labelSelecInforme.AutoSize = true;
            this.labelSelecInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecInforme.Location = new System.Drawing.Point(12, 75);
            this.labelSelecInforme.Name = "labelSelecInforme";
            this.labelSelecInforme.Size = new System.Drawing.Size(173, 16);
            this.labelSelecInforme.TabIndex = 18;
            this.labelSelecInforme.Text = "SELECCIONE INFORME";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(12, 124);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(91, 16);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "Fecha Inicio";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicio.Location = new System.Drawing.Point(138, 118);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(117, 22);
            this.dateTimeInicio.TabIndex = 20;
            this.dateTimeInicio.Value = new System.DateTime(2025, 9, 15, 19, 52, 55, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha Final";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(540, 119);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(133, 22);
            this.dateTimeFinal.TabIndex = 22;
            this.dateTimeFinal.Value = new System.DateTime(2025, 9, 15, 19, 52, 55, 0);
            // 
            // comboSelectInforme
            // 
            this.comboSelectInforme.FormattingEnabled = true;
            this.comboSelectInforme.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboSelectInforme.Location = new System.Drawing.Point(215, 72);
            this.comboSelectInforme.Name = "comboSelectInforme";
            this.comboSelectInforme.Size = new System.Drawing.Size(118, 24);
            this.comboSelectInforme.TabIndex = 23;
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenar.Location = new System.Drawing.Point(375, 75);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(118, 16);
            this.labelOrdenar.TabIndex = 24;
            this.labelOrdenar.Text = "ORDENAR POR";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(581, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // radioButtonEnPantalla
            // 
            this.radioButtonEnPantalla.AutoSize = true;
            this.radioButtonEnPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnPantalla.Location = new System.Drawing.Point(138, 197);
            this.radioButtonEnPantalla.Name = "radioButtonEnPantalla";
            this.radioButtonEnPantalla.Size = new System.Drawing.Size(107, 20);
            this.radioButtonEnPantalla.TabIndex = 26;
            this.radioButtonEnPantalla.TabStop = true;
            this.radioButtonEnPantalla.Text = "En Pantalla";
            this.radioButtonEnPantalla.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPDF.Location = new System.Drawing.Point(331, 165);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(58, 20);
            this.radioButtonPDF.TabIndex = 27;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonExcel
            // 
            this.radioButtonExcel.AutoSize = true;
            this.radioButtonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonExcel.Location = new System.Drawing.Point(499, 165);
            this.radioButtonExcel.Name = "radioButtonExcel";
            this.radioButtonExcel.Size = new System.Drawing.Size(75, 20);
            this.radioButtonExcel.TabIndex = 28;
            this.radioButtonExcel.TabStop = true;
            this.radioButtonExcel.Text = "EXCEL";
            this.radioButtonExcel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonExcel);
            this.panel1.Controls.Add(this.radioButtonPDF);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 211);
            this.panel1.TabIndex = 29;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSize = true;
            this.btnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Icon = null;
            this.btnGenerarInforme.Location = new System.Drawing.Point(121, 249);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Primary = true;
            this.btnGenerarInforme.Size = new System.Drawing.Size(176, 36);
            this.btnGenerarInforme.TabIndex = 30;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.AutoSize = true;
            this.ButtonSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSalir.Depth = 0;
            this.ButtonSalir.Icon = null;
            this.ButtonSalir.Location = new System.Drawing.Point(499, 249);
            this.ButtonSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Primary = true;
            this.ButtonSalir.Size = new System.Drawing.Size(69, 36);
            this.ButtonSalir.TabIndex = 31;
            this.ButtonSalir.Text = "SALIR";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 147);
            this.dataGridView1.TabIndex = 32;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.radioButtonEnPantalla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.comboSelectInforme);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelSelecInforme);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.panel1);
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.Label labelSelecInforme;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.ComboBox comboSelectInforme;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButtonEnPantalla;
        private System.Windows.Forms.RadioButton radioButtonPDF;
        private System.Windows.Forms.RadioButton radioButtonExcel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}