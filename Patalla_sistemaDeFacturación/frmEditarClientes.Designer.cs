namespace Patalla_sistemaDeFacturación
{
    partial class frmEditarClientes
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.xtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.xtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.xtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.xtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(54, 120);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(60, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Titulo";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(59, 202);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 22);
            this.txtIdCliente.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtEmail);
            this.panel2.Controls.Add(this.xtTelefono);
            this.panel2.Controls.Add(this.xtDireccion);
            this.panel2.Controls.Add(this.xtNombre);
            this.panel2.Controls.Add(this.xtDocumento);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(59, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 408);
            this.panel2.TabIndex = 2;
            // 
            // xtEmail
            // 
            this.xtEmail.Depth = 0;
            this.xtEmail.Hint = "Email";
            this.xtEmail.Location = new System.Drawing.Point(54, 298);
            this.xtEmail.MaxLength = 32767;
            this.xtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.xtEmail.Name = "xtEmail";
            this.xtEmail.PasswordChar = '\0';
            this.xtEmail.SelectedText = "";
            this.xtEmail.SelectionLength = 0;
            this.xtEmail.SelectionStart = 0;
            this.xtEmail.Size = new System.Drawing.Size(341, 28);
            this.xtEmail.TabIndex = 4;
            this.xtEmail.TabStop = false;
            this.xtEmail.UseSystemPasswordChar = false;
            // 
            // xtTelefono
            // 
            this.xtTelefono.Depth = 0;
            this.xtTelefono.Hint = "Telefono";
            this.xtTelefono.Location = new System.Drawing.Point(54, 239);
            this.xtTelefono.MaxLength = 32767;
            this.xtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.xtTelefono.Name = "xtTelefono";
            this.xtTelefono.PasswordChar = '\0';
            this.xtTelefono.SelectedText = "";
            this.xtTelefono.SelectionLength = 0;
            this.xtTelefono.SelectionStart = 0;
            this.xtTelefono.Size = new System.Drawing.Size(341, 28);
            this.xtTelefono.TabIndex = 3;
            this.xtTelefono.TabStop = false;
            this.xtTelefono.UseSystemPasswordChar = false;
            // 
            // xtDireccion
            // 
            this.xtDireccion.Depth = 0;
            this.xtDireccion.Hint = "Dirección";
            this.xtDireccion.Location = new System.Drawing.Point(54, 175);
            this.xtDireccion.MaxLength = 32767;
            this.xtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.xtDireccion.Name = "xtDireccion";
            this.xtDireccion.PasswordChar = '\0';
            this.xtDireccion.SelectedText = "";
            this.xtDireccion.SelectionLength = 0;
            this.xtDireccion.SelectionStart = 0;
            this.xtDireccion.Size = new System.Drawing.Size(341, 28);
            this.xtDireccion.TabIndex = 2;
            this.xtDireccion.TabStop = false;
            this.xtDireccion.UseSystemPasswordChar = false;
            // 
            // xtNombre
            // 
            this.xtNombre.Depth = 0;
            this.xtNombre.Hint = "Nombre Cliente";
            this.xtNombre.Location = new System.Drawing.Point(54, 28);
            this.xtNombre.MaxLength = 32767;
            this.xtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.xtNombre.Name = "xtNombre";
            this.xtNombre.PasswordChar = '\0';
            this.xtNombre.SelectedText = "";
            this.xtNombre.SelectionLength = 0;
            this.xtNombre.SelectionStart = 0;
            this.xtNombre.Size = new System.Drawing.Size(341, 28);
            this.xtNombre.TabIndex = 1;
            this.xtNombre.TabStop = false;
            this.xtNombre.UseSystemPasswordChar = false;
            // 
            // xtDocumento
            // 
            this.xtDocumento.Depth = 0;
            this.xtDocumento.Hint = "Documento";
            this.xtDocumento.Location = new System.Drawing.Point(54, 103);
            this.xtDocumento.MaxLength = 32767;
            this.xtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.xtDocumento.Name = "xtDocumento";
            this.xtDocumento.PasswordChar = '\0';
            this.xtDocumento.SelectedText = "";
            this.xtDocumento.SelectionLength = 0;
            this.xtDocumento.SelectionStart = 0;
            this.xtDocumento.Size = new System.Drawing.Size(341, 28);
            this.xtDocumento.TabIndex = 0;
            this.xtDocumento.TabStop = false;
            this.xtDocumento.UseSystemPasswordChar = false;
            this.xtDocumento.UseWaitCursor = true;
            // 
            // btActualizar
            // 
            this.btActualizar.AutoSize = true;
            this.btActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btActualizar.Depth = 0;
            this.btActualizar.Icon = null;
            this.btActualizar.Location = new System.Drawing.Point(191, 676);
            this.btActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Primary = true;
            this.btActualizar.Size = new System.Drawing.Size(124, 36);
            this.btActualizar.TabIndex = 3;
            this.btActualizar.Text = "ACTUALIZAR";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = true;
            this.btSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSalir.Depth = 0;
            this.btSalir.Icon = null;
            this.btSalir.Location = new System.Drawing.Point(466, 676);
            this.btSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSalir.Name = "btSalir";
            this.btSalir.Primary = true;
            this.btSalir.Size = new System.Drawing.Size(69, 36);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarClientes
            // 
            this.ClientSize = new System.Drawing.Size(983, 724);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.labelTitulo);
            this.Name = "frmEditarClientes";
            this.Text = "ACTUALIZACIÓN CLIENTE";
            this.Load += new System.EventHandler(this.frmEditarClientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField xtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField xtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField xtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField xtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField xtDocumento;
        private MaterialSkin.Controls.MaterialRaisedButton btActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btSalir;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}