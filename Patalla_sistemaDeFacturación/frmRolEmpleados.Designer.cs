namespace Patalla_sistemaDeFacturación
{
    partial class frmRolEmpleados
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
            this.txtnEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datosAdicionales = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.Location = new System.Drawing.Point(234, 19);
            this.TITULO.Name = "TITULO";
            this.TITULO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TITULO.Size = new System.Drawing.Size(199, 20);
            this.TITULO.TabIndex = 4;
            this.TITULO.Text = "ROL DE EMPLEADOS";
            // 
            // txtnEmpleado
            // 
            this.txtnEmpleado.Location = new System.Drawing.Point(28, 83);
            this.txtnEmpleado.Multiline = true;
            this.txtnEmpleado.Name = "txtnEmpleado";
            this.txtnEmpleado.Size = new System.Drawing.Size(37, 23);
            this.txtnEmpleado.TabIndex = 12;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Hint = "Nombre Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(28, 138);
            this.txtNombreRol.MaxLength = 32767;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(267, 28);
            this.txtNombreRol.TabIndex = 16;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDetalle);
            this.panel1.Controls.Add(this.datosAdicionales);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 284);
            this.panel1.TabIndex = 17;
            // 
            // datosAdicionales
            // 
            this.datosAdicionales.AutoSize = true;
            this.datosAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosAdicionales.Location = new System.Drawing.Point(12, 133);
            this.datosAdicionales.Name = "datosAdicionales";
            this.datosAdicionales.Size = new System.Drawing.Size(226, 20);
            this.datosAdicionales.TabIndex = 32;
            this.datosAdicionales.Text = "Descripción detallada Rol";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(16, 172);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(656, 70);
            this.txtDetalle.TabIndex = 33;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(160, 380);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(470, 380);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.txtnEmpleado);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.panel1);
            this.Name = "frmRolEmpleados";
            this.Text = "frmRolEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.TextBox txtnEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datosAdicionales;
        private System.Windows.Forms.TextBox txtDetalle;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}