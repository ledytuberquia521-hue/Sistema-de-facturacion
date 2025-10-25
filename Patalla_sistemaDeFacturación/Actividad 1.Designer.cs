using System;

namespace Patalla_sistemaDeFacturación
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        // Clean up any resources being used.
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlcontenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Facturación = new System.Windows.Forms.TabPage();
            this.btninformes = new System.Windows.Forms.Button();
            this.btnfacturas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnroles = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Ayuda = new System.Windows.Forms.TabPage();
            this.btnacerca = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Facturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlcontenedor);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Location = new System.Drawing.Point(1, 97);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1202, 557);
            this.pnlPrincipal.TabIndex = 0;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlcontenedor
            // 
            this.pnlcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontenedor.Location = new System.Drawing.Point(201, 0);
            this.pnlcontenedor.Name = "pnlcontenedor";
            this.pnlcontenedor.Size = new System.Drawing.Size(1001, 557);
            this.pnlcontenedor.TabIndex = 1;
            this.pnlcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlcontenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbpMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 557);
            this.panel1.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.Tablas);
            this.TbpMenu.Controls.Add(this.Facturación);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.Ayuda);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(201, 557);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.RosyBrown;
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 25);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(193, 528);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.WhatsApp_Image_2025_08_31_at_6_09_58_PM;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(7, 452);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(167, 60);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.bienvenidos;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Tablas
            // 
            this.Tablas.BackColor = System.Drawing.Color.RosyBrown;
            this.Tablas.Controls.Add(this.btncategorias);
            this.Tablas.Controls.Add(this.btnproductos);
            this.Tablas.Controls.Add(this.btncliente);
            this.Tablas.Controls.Add(this.pictureBox2);
            this.Tablas.Location = new System.Drawing.Point(4, 25);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(193, 528);
            this.Tablas.TabIndex = 1;
            this.Tablas.Text = "Admin tablas";
            // 
            // btncategorias
            // 
            this.btncategorias.FlatAppearance.BorderSize = 0;
            this.btncategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncategorias.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.categorizacion;
            this.btncategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Location = new System.Drawing.Point(6, 286);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(167, 60);
            this.btncategorias.TabIndex = 7;
            this.btncategorias.Text = "    Categorias";
            this.btncategorias.UseVisualStyleBackColor = true;
            // 
            // btnproductos
            // 
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnproductos.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.anadir_al_carrito;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(7, 211);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(167, 60);
            this.btnproductos.TabIndex = 6;
            this.btnproductos.Text = "    Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            // 
            // btncliente
            // 
            this.btncliente.FlatAppearance.BorderSize = 0;
            this.btncliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncliente.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.clientes_potenciales;
            this.btncliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncliente.Location = new System.Drawing.Point(6, 145);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(167, 60);
            this.btncliente.TabIndex = 5;
            this.btncliente.Text = "Clientes";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.bienvenidos;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Facturación
            // 
            this.Facturación.BackColor = System.Drawing.Color.RosyBrown;
            this.Facturación.Controls.Add(this.btninformes);
            this.Facturación.Controls.Add(this.btnfacturas);
            this.Facturación.Controls.Add(this.pictureBox3);
            this.Facturación.Location = new System.Drawing.Point(4, 25);
            this.Facturación.Name = "Facturación";
            this.Facturación.Size = new System.Drawing.Size(193, 528);
            this.Facturación.TabIndex = 2;
            this.Facturación.Text = "facturación";
            // 
            // btninformes
            // 
            this.btninformes.FlatAppearance.BorderSize = 0;
            this.btninformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btninformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btninformes.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.cuidado_de_la_salud;
            this.btninformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformes.Location = new System.Drawing.Point(7, 258);
            this.btninformes.Name = "btninformes";
            this.btninformes.Size = new System.Drawing.Size(167, 60);
            this.btninformes.TabIndex = 7;
            this.btninformes.Text = "Informes";
            this.btninformes.UseVisualStyleBackColor = true;
            // 
            // btnfacturas
            // 
            this.btnfacturas.FlatAppearance.BorderSize = 0;
            this.btnfacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfacturas.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.factura;
            this.btnfacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacturas.Location = new System.Drawing.Point(7, 177);
            this.btnfacturas.Name = "btnfacturas";
            this.btnfacturas.Size = new System.Drawing.Size(167, 60);
            this.btnfacturas.TabIndex = 6;
            this.btnfacturas.Text = "Facturas";
            this.btnfacturas.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.bienvenidos;
            this.pictureBox3.Location = new System.Drawing.Point(4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.RosyBrown;
            this.Seguridad.Controls.Add(this.button3);
            this.Seguridad.Controls.Add(this.btnroles);
            this.Seguridad.Controls.Add(this.btnempleados);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Location = new System.Drawing.Point(4, 25);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(193, 528);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.proteger;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(7, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 60);
            this.button3.TabIndex = 10;
            this.button3.Text = "     Seguridad";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnroles
            // 
            this.btnroles.FlatAppearance.BorderSize = 0;
            this.btnroles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnroles.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.roles__1_;
            this.btnroles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroles.Location = new System.Drawing.Point(7, 205);
            this.btnroles.Name = "btnroles";
            this.btnroles.Size = new System.Drawing.Size(167, 60);
            this.btnroles.TabIndex = 9;
            this.btnroles.Text = "Roles";
            this.btnroles.UseVisualStyleBackColor = true;
            // 
            // btnempleados
            // 
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnempleados.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.clientes_potenciales1;
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(7, 139);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(181, 60);
            this.btnempleados.TabIndex = 8;
            this.btnempleados.Text = "    Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.bienvenidos;
            this.pictureBox4.Location = new System.Drawing.Point(4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(184, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // Ayuda
            // 
            this.Ayuda.BackColor = System.Drawing.Color.RosyBrown;
            this.Ayuda.Controls.Add(this.btnacerca);
            this.Ayuda.Controls.Add(this.btnayuda);
            this.Ayuda.Controls.Add(this.pictureBox5);
            this.Ayuda.Location = new System.Drawing.Point(4, 25);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(193, 528);
            this.Ayuda.TabIndex = 4;
            this.Ayuda.Text = "Ayuda";
            // 
            // btnacerca
            // 
            this.btnacerca.FlatAppearance.BorderSize = 0;
            this.btnacerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnacerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacerca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnacerca.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.acerca_de;
            this.btnacerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacerca.Location = new System.Drawing.Point(7, 218);
            this.btnacerca.Name = "btnacerca";
            this.btnacerca.Size = new System.Drawing.Size(167, 60);
            this.btnacerca.TabIndex = 11;
            this.btnacerca.Text = "    Acerca de..";
            this.btnacerca.UseVisualStyleBackColor = true;
            // 
            // btnayuda
            // 
            this.btnayuda.FlatAppearance.BorderSize = 0;
            this.btnayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnayuda.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.mano_amiga;
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(7, 152);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(167, 60);
            this.btnayuda.TabIndex = 10;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Patalla_sistemaDeFacturación.Properties.Resources.bienvenidos;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(184, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // tabOpcionesMenu
            // 
            this.tabOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.tabOpcionesMenu.Depth = 0;
            this.tabOpcionesMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOpcionesMenu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabOpcionesMenu.Location = new System.Drawing.Point(375, 30);
            this.tabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionesMenu.Name = "tabOpcionesMenu";
            this.tabOpcionesMenu.Size = new System.Drawing.Size(744, 34);
            this.tabOpcionesMenu.TabIndex = 1;
            this.tabOpcionesMenu.Click += new System.EventHandler(this.tabOpcionesMenu_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabOpcionesMenu);
            this.Controls.Add(this.pnlPrincipal);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Facturación.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Ayuda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            frmListaClientes frmListaClientes = new frmListaClientes();
            AbrirForm(frmListaClientes);
        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.TabPage Facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private MaterialSkin.Controls.MaterialTabSelector tabOpcionesMenu;
        private System.Windows.Forms.TabPage Ayuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btninformes;
        private System.Windows.Forms.Button btnfacturas;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnroles;
        private System.Windows.Forms.Button btnacerca;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Panel pnlcontenedor;
    }
}