namespace Patalla_sistemaDeFacturación
{
    partial class frmFacturas
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
        private void InicialiceComponent()
        {
            this.SuspendLayout();
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetallesFactura;
        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.Panel panelDatosCliente;
        private System.Windows.Forms.Label labelDetalleFactura;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelNroFactura;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIVA;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelEstadoFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}