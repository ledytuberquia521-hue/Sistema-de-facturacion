namespace Patalla_sistemaDeFacturación
{
    partial class Frmlogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LOGIN = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnValidar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGIN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.LOGIN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 266);
            this.panel1.TabIndex = 0;
            // 
            // LOGIN
            // 
            this.LOGIN.ErrorImage = null;
            this.LOGIN.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.contrasena;
            this.LOGIN.Location = new System.Drawing.Point(24, 39);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(124, 148);
            this.LOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGIN.TabIndex = 0;
            this.LOGIN.TabStop = false;
            this.LOGIN.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(273, 24);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "VALIDAR USUARIO";
            this.lblTitulo.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Hint = "";
            this.TxtUsuario.Location = new System.Drawing.Point(232, 74);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsuario.MaxLength = 32767;
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(214, 28);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.TabStop = false;
            this.TxtUsuario.Text = "Usuario";
            this.TxtUsuario.UseSystemPasswordChar = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "";
            this.TxtPassword.Location = new System.Drawing.Point(232, 124);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(214, 28);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.Text = "Password";
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // btnValidar
            // 
            this.btnValidar.AutoSize = true;
            this.btnValidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidar.Depth = 0;
            this.btnValidar.Icon = null;
            this.btnValidar.Location = new System.Drawing.Point(257, 206);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Primary = true;
            this.btnValidar.Size = new System.Drawing.Size(92, 36);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(381, 206);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(109, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(541, 266);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frmlogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LOGIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LOGIN;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnValidar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
    }
}

