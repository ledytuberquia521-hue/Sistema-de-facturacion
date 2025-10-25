namespace Patalla_sistemaDeFacturación
{
    partial class frmProductos
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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.labelProductos = new System.Windows.Forms.Label();
            this.panelproductos = new System.Windows.Forms.Panel();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.DetallesProductos = new System.Windows.Forms.Label();
            this.txtRutaImagen = new System.Windows.Forms.LinkLabel();
            this.Categoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCanStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPreVentas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPreCompras = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(22, 74);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 22);
            this.txtProducto.TabIndex = 2;
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProductos.Location = new System.Drawing.Point(214, 27);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(377, 25);
            this.labelProductos.TabIndex = 3;
            this.labelProductos.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // panelproductos
            // 
            this.panelproductos.Controls.Add(this.txtDetalle);
            this.panelproductos.Controls.Add(this.DetallesProductos);
            this.panelproductos.Controls.Add(this.txtRutaImagen);
            this.panelproductos.Controls.Add(this.Categoria);
            this.panelproductos.Controls.Add(this.comboBox1);
            this.panelproductos.Controls.Add(this.txtCanStock);
            this.panelproductos.Controls.Add(this.txtPreVentas);
            this.panelproductos.Controls.Add(this.txtPreCompras);
            this.panelproductos.Controls.Add(this.txtNomProducto);
            this.panelproductos.Controls.Add(this.txtCodReferencia);
            this.panelproductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelproductos.Location = new System.Drawing.Point(22, 111);
            this.panelproductos.Name = "panelproductos";
            this.panelproductos.Size = new System.Drawing.Size(1003, 416);
            this.panelproductos.TabIndex = 4;
            this.panelproductos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelproductos_Paint);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(673, 261);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(295, 128);
            this.txtDetalle.TabIndex = 9;
            this.txtDetalle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DetallesProductos
            // 
            this.DetallesProductos.AutoSize = true;
            this.DetallesProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetallesProductos.Location = new System.Drawing.Point(703, 226);
            this.DetallesProductos.Name = "DetallesProductos";
            this.DetallesProductos.Size = new System.Drawing.Size(160, 20);
            this.DetallesProductos.TabIndex = 8;
            this.DetallesProductos.Text = "Detalles Producto";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.AutoSize = true;
            this.txtRutaImagen.LinkColor = System.Drawing.Color.Black;
            this.txtRutaImagen.Location = new System.Drawing.Point(703, 136);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(83, 16);
            this.txtRutaImagen.TabIndex = 7;
            this.txtRutaImagen.TabStop = true;
            this.txtRutaImagen.Text = "Ruta Imagen";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.Location = new System.Drawing.Point(703, 31);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(90, 20);
            this.Categoria.TabIndex = 6;
            this.Categoria.Text = "Categoria";
            this.Categoria.Click += new System.EventHandler(this.label1_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(811, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCanStock
            // 
            this.txtCanStock.Depth = 0;
            this.txtCanStock.Hint = "Cantidad Stock";
            this.txtCanStock.Location = new System.Drawing.Point(54, 298);
            this.txtCanStock.MaxLength = 32767;
            this.txtCanStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCanStock.Name = "txtCanStock";
            this.txtCanStock.PasswordChar = '\0';
            this.txtCanStock.SelectedText = "";
            this.txtCanStock.SelectionLength = 0;
            this.txtCanStock.SelectionStart = 0;
            this.txtCanStock.Size = new System.Drawing.Size(341, 28);
            this.txtCanStock.TabIndex = 4;
            this.txtCanStock.TabStop = false;
            this.txtCanStock.UseSystemPasswordChar = false;
            // 
            // txtPreVentas
            // 
            this.txtPreVentas.Depth = 0;
            this.txtPreVentas.Hint = "Precio Venta";
            this.txtPreVentas.Location = new System.Drawing.Point(54, 239);
            this.txtPreVentas.MaxLength = 32767;
            this.txtPreVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPreVentas.Name = "txtPreVentas";
            this.txtPreVentas.PasswordChar = '\0';
            this.txtPreVentas.SelectedText = "";
            this.txtPreVentas.SelectionLength = 0;
            this.txtPreVentas.SelectionStart = 0;
            this.txtPreVentas.Size = new System.Drawing.Size(341, 28);
            this.txtPreVentas.TabIndex = 3;
            this.txtPreVentas.TabStop = false;
            this.txtPreVentas.UseSystemPasswordChar = false;
            // 
            // txtPreCompras
            // 
            this.txtPreCompras.Depth = 0;
            this.txtPreCompras.Hint = "Precio Compras";
            this.txtPreCompras.Location = new System.Drawing.Point(54, 175);
            this.txtPreCompras.MaxLength = 32767;
            this.txtPreCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPreCompras.Name = "txtPreCompras";
            this.txtPreCompras.PasswordChar = '\0';
            this.txtPreCompras.SelectedText = "";
            this.txtPreCompras.SelectionLength = 0;
            this.txtPreCompras.SelectionStart = 0;
            this.txtPreCompras.Size = new System.Drawing.Size(341, 28);
            this.txtPreCompras.TabIndex = 2;
            this.txtPreCompras.TabStop = false;
            this.txtPreCompras.UseSystemPasswordChar = false;
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.Depth = 0;
            this.txtNomProducto.Hint = "Nombre Producto";
            this.txtNomProducto.Location = new System.Drawing.Point(54, 28);
            this.txtNomProducto.MaxLength = 32767;
            this.txtNomProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.PasswordChar = '\0';
            this.txtNomProducto.SelectedText = "";
            this.txtNomProducto.SelectionLength = 0;
            this.txtNomProducto.SelectionStart = 0;
            this.txtNomProducto.Size = new System.Drawing.Size(341, 28);
            this.txtNomProducto.TabIndex = 1;
            this.txtNomProducto.TabStop = false;
            this.txtNomProducto.UseSystemPasswordChar = false;
            // 
            // txtCodReferencia
            // 
            this.txtCodReferencia.Depth = 0;
            this.txtCodReferencia.Hint = "Código Referencia";
            this.txtCodReferencia.Location = new System.Drawing.Point(54, 103);
            this.txtCodReferencia.MaxLength = 32767;
            this.txtCodReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodReferencia.Name = "txtCodReferencia";
            this.txtCodReferencia.PasswordChar = '\0';
            this.txtCodReferencia.SelectedText = "";
            this.txtCodReferencia.SelectionLength = 0;
            this.txtCodReferencia.SelectionStart = 0;
            this.txtCodReferencia.Size = new System.Drawing.Size(341, 28);
            this.txtCodReferencia.TabIndex = 0;
            this.txtCodReferencia.TabStop = false;
            this.txtCodReferencia.UseSystemPasswordChar = false;
            this.txtCodReferencia.UseWaitCursor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(238, 586);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 5;
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
            this.btnSalir.Location = new System.Drawing.Point(812, 586);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 663);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panelproductos);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.labelProductos);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.panelproductos.ResumeLayout(false);
            this.panelproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Panel panelproductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCanStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPreVentas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPreCompras;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodReferencia;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label DetallesProductos;
        private System.Windows.Forms.TextBox txtDetalle;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel txtRutaImagen;
    }
}