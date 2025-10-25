namespace Patalla_sistemaDeFacturación
{
    partial class frmEmpleados
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.datosAdicionales = new System.Windows.Forms.Label();
            this.dtmRetiro = new System.Windows.Forms.DateTimePicker();
            this.dtmIngreso = new System.Windows.Forms.DateTimePicker();
            this.labelFechaR = new System.Windows.Forms.Label();
            this.labelFechaI = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnEmpleado = new System.Windows.Forms.TextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(188, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitulo.Size = new System.Drawing.Size(318, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDatosAdicionales);
            this.panel1.Controls.Add(this.datosAdicionales);
            this.panel1.Controls.Add(this.dtmRetiro);
            this.panel1.Controls.Add(this.dtmIngreso);
            this.panel1.Controls.Add(this.labelFechaR);
            this.panel1.Controls.Add(this.labelFechaI);
            this.panel1.Controls.Add(this.cboRol);
            this.panel1.Controls.Add(this.labelRol);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtnEmpleado);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 324);
            this.panel1.TabIndex = 4;
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(433, 221);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(250, 70);
            this.txtDatosAdicionales.TabIndex = 32;
            // 
            // datosAdicionales
            // 
            this.datosAdicionales.AutoSize = true;
            this.datosAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosAdicionales.Location = new System.Drawing.Point(463, 198);
            this.datosAdicionales.Name = "datosAdicionales";
            this.datosAdicionales.Size = new System.Drawing.Size(201, 20);
            this.datosAdicionales.TabIndex = 31;
            this.datosAdicionales.Text = "DATOS ADICIONALES";
            // 
            // dtmRetiro
            // 
            this.dtmRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmRetiro.Location = new System.Drawing.Point(588, 151);
            this.dtmRetiro.Name = "dtmRetiro";
            this.dtmRetiro.Size = new System.Drawing.Size(118, 22);
            this.dtmRetiro.TabIndex = 30;
            // 
            // dtmIngreso
            // 
            this.dtmIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmIngreso.Location = new System.Drawing.Point(588, 111);
            this.dtmIngreso.Name = "dtmIngreso";
            this.dtmIngreso.Size = new System.Drawing.Size(118, 22);
            this.dtmIngreso.TabIndex = 29;
            // 
            // labelFechaR
            // 
            this.labelFechaR.AutoSize = true;
            this.labelFechaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaR.Location = new System.Drawing.Point(430, 157);
            this.labelFechaR.Name = "labelFechaR";
            this.labelFechaR.Size = new System.Drawing.Size(81, 16);
            this.labelFechaR.TabIndex = 28;
            this.labelFechaR.Text = "F. RETIRO";
            // 
            // labelFechaI
            // 
            this.labelFechaI.AutoSize = true;
            this.labelFechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaI.Location = new System.Drawing.Point(430, 111);
            this.labelFechaI.Name = "labelFechaI";
            this.labelFechaI.Size = new System.Drawing.Size(92, 16);
            this.labelFechaI.TabIndex = 27;
            this.labelFechaI.Text = "F. INGRESO";
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboRol.Location = new System.Drawing.Point(588, 66);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(118, 24);
            this.cboRol.TabIndex = 26;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(430, 74);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(123, 16);
            this.labelRol.TabIndex = 25;
            this.labelRol.Text = "ROL EMPLEADO";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(25, 198);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(267, 28);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Hint = "Teléfono";
            this.txtTelefono.Location = new System.Drawing.Point(25, 164);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(267, 28);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.Location = new System.Drawing.Point(25, 130);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(267, 28);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.Location = new System.Drawing.Point(25, 96);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(267, 28);
            this.txtDocumento.TabIndex = 16;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Hint = "Nombre Empleado";
            this.txtNombre.Location = new System.Drawing.Point(25, 62);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(267, 28);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.Click += new System.EventHandler(this.txtNomEmpleado_Click);
            // 
            // txtnEmpleado
            // 
            this.txtnEmpleado.Location = new System.Drawing.Point(25, 12);
            this.txtnEmpleado.Multiline = true;
            this.txtnEmpleado.Name = "txtnEmpleado";
            this.txtnEmpleado.Size = new System.Drawing.Size(37, 23);
            this.txtnEmpleado.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(109, 402);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(479, 402);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label labelFechaR;
        private System.Windows.Forms.Label labelFechaI;
        private System.Windows.Forms.DateTimePicker dtmRetiro;
        private System.Windows.Forms.DateTimePicker dtmIngreso;
        private System.Windows.Forms.Label datosAdicionales;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}