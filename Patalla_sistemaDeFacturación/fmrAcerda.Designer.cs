using System;

namespace Patalla_sistemaDeFacturación
{
    partial class fmrAcerda
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLegal = new System.Windows.Forms.TextBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonDxDiag = new System.Windows.Forms.Button();
            this.buttonInfoSistema = new System.Windows.Forms.Button();
            this.buttonCopiarInfo = new System.Windows.Forms.Button();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // panel1
            this.panel1.Controls.Add(this.textBoxLegal);
            this.panel1.Controls.Add(this.labelCopyright);
            this.panel1.Controls.Add(this.labelCompanyName);
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.buttonAceptar);
            this.panel1.Controls.Add(this.buttonDxDiag);
            this.panel1.Controls.Add(this.buttonInfoSistema);
            this.panel1.Controls.Add(this.buttonCopiarInfo);
            this.panel1.Controls.Add(this.listBoxProductos);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.labelProductName);
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 454);
            this.panel1.TabIndex = 0;

            // labelProductName
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelProductName.Location = new System.Drawing.Point(165, 18);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(380, 20);
            this.labelProductName.TabIndex = 6;
            this.labelProductName.Text = "ACERCA DEL SISTEMA DE FACTURACIÓN";

            // textBoxDescription
            this.textBoxDescription.Location = new System.Drawing.Point(53, 201);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(559, 84);
            this.textBoxDescription.TabIndex = 7;

            // listBoxProductos
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 16;
            this.listBoxProductos.Location = new System.Drawing.Point(53, 120);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(559, 68);
            this.listBoxProductos.TabIndex = 8;

            // buttonCopiarInfo
            this.buttonCopiarInfo.Location = new System.Drawing.Point(618, 101);
            this.buttonCopiarInfo.Name = "buttonCopiarInfo";
            this.buttonCopiarInfo.Size = new System.Drawing.Size(112, 32);
            this.buttonCopiarInfo.TabIndex = 9;
            this.buttonCopiarInfo.Text = "Copiar información";
            this.buttonCopiarInfo.UseVisualStyleBackColor = true;
            this.buttonCopiarInfo.Click += new System.EventHandler(this.buttonCopiarInfo_Click);

            // buttonInfoSistema
            this.buttonInfoSistema.Location = new System.Drawing.Point(618, 165);
            this.buttonInfoSistema.Name = "buttonInfoSistema";
            this.buttonInfoSistema.Size = new System.Drawing.Size(112, 32);
            this.buttonInfoSistema.TabIndex = 10;
            this.buttonInfoSistema.Text = "Info. del sistema";
            this.buttonInfoSistema.UseVisualStyleBackColor = true;
            this.buttonInfoSistema.Click += new System.EventHandler(this.buttonInfoSistema_Click);

            // buttonDxDiag
            this.buttonDxDiag.Location = new System.Drawing.Point(618, 224);
            this.buttonDxDiag.Name = "buttonDxDiag";
            this.buttonDxDiag.Size = new System.Drawing.Size(112, 32);
            this.buttonDxDiag.TabIndex = 11;
            this.buttonDxDiag.Text = "DxDiag";
            this.buttonDxDiag.UseVisualStyleBackColor = true;
            this.buttonDxDiag.Click += new System.EventHandler(this.buttonDxDiag_Click);

            // buttonAceptar
            this.buttonAceptar.Location = new System.Drawing.Point(618, 392);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(112, 32);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "ACEPTAR";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);

            // labelVersion
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(59, 44);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(44, 16);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "Versión";

            // labelCompanyName
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(59, 74);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(60, 16);
            this.labelCompanyName.TabIndex = 15;
            this.labelCompanyName.Text = "Compañía";

            // labelCopyright
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(59, 101);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(62, 16);
            this.labelCopyright.TabIndex = 16;
            this.labelCopyright.Text = "Copyright";

            // textBoxLegal
            this.textBoxLegal.Location = new System.Drawing.Point(53, 308);
            this.textBoxLegal.Multiline = true;
            this.textBoxLegal.ReadOnly = true;
            this.textBoxLegal.Size = new System.Drawing.Size(559, 116);
            this.textBoxLegal.TabIndex = 17;

            // fmrAcerda
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 482);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrAcerda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca del Sistema";
            this.Load += new System.EventHandler(this.fmrAcerda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private void fmrAcerda_Load(object sender, EventArgs e)
        {
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = $"Versión {AssemblyVersion}";
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;

            // Cargar lista de productos simulados
            listBoxProductos.Items.Add("Visual C++ 2017 – 00369-60000-00001-AA061");
            listBoxProductos.Items.Add("Administrador de paquetes NuGet – 4.6.0");
            listBoxProductos.Items.Add("Asistentes de Microsoft Visual C++ – 1.0");
            listBoxProductos.Items.Add("ASP.NET and Web Tools 2017 – 15.8.05085.0");
            listBoxProductos.Items.Add("ASP.NET Core Razor Language Services – 15.6.3.150");
            listBoxProductos.Items.Add("ASP.NET Web Frameworks and Tools 2017 – 5.2.60318.0");
            listBoxProductos.Items.Add("Azure App Service Tools v3.0.0 – 15.0.50302.0");
            listBoxProductos.Items.Add("Azure Functions and Web Jobs Tools – 15.9.02046.0");

            textBoxLegal.Text = "Advertencia: este programa está protegido por las leyes de derechos de autor y otros tratados internacionales. "
                + "La reproducción o distribución ilícita de este programa o de cualquier parte del mismo está penada por la ley con severas sanciones "
                + "civiles y penales y será objeto de todas las acciones judiciales que correspondan.";
        }
        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.Button buttonCopiarInfo;
        private System.Windows.Forms.Button buttonDxDiag;
        private System.Windows.Forms.Button buttonInfoSistema;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxLegal;
    }
}
