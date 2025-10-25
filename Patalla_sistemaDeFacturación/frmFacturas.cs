using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patalla_sistemaDeFacturación
{
    public partial class frmFacturas : Form
    {

        Acceso_datos datos = new Acceso_datos();
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            

        }
        private void CargarClientes()
        {
            DataTable dt = datos.cargartabla("TBLCLIENTES", "");
            if (dt != null)
            {
                comboBoxCliente.DataSource = dt;
                comboBoxCliente.DisplayMember = "NombreCliente"; // Ajusta al nombre real de la columna
                comboBoxCliente.ValueMember = "IdCliente";
            }
        }

        private void CargarEmpleados()
        {
            DataTable dt = datos.cargartabla("TBLEMPLEADO", "");
            if (dt != null)
            {
                comboBoxEmpleado.DataSource = dt;
                comboBoxEmpleado.DisplayMember = "NombreEmpleado"; // Ajusta al nombre real
                comboBoxEmpleado.ValueMember = "IdEmpleado";
            }
        }

        private void CargarEstados()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Pendiente");
            comboBox1.Items.Add("Pagada");
            comboBox1.Items.Add("Anulada");
        }

        private void CargarFacturas()
        {
            DataTable dt = datos.cargartabla("TBLFACTURA", "");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }


        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelDetallesFactura = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDetalleFactura = new System.Windows.Forms.Label();
            this.TITULO = new System.Windows.Forms.Label();
            this.panelDatosCliente = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelEstadoFactura = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelNroFactura = new System.Windows.Forms.Label();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDetallesFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetallesFactura
            // 
            this.panelDetallesFactura.Controls.Add(this.dataGridView1);
            this.panelDetallesFactura.Controls.Add(this.labelDetalleFactura);
            this.panelDetallesFactura.Location = new System.Drawing.Point(21, 299);
            this.panelDetallesFactura.Name = "panelDetallesFactura";
            this.panelDetallesFactura.Size = new System.Drawing.Size(698, 225);
            this.panelDetallesFactura.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 167);
            this.dataGridView1.TabIndex = 3;
            // 
            // labelDetalleFactura
            // 
            this.labelDetalleFactura.AutoSize = true;
            this.labelDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleFactura.Location = new System.Drawing.Point(17, 0);
            this.labelDetalleFactura.Name = "labelDetalleFactura";
            this.labelDetalleFactura.Size = new System.Drawing.Size(183, 20);
            this.labelDetalleFactura.TabIndex = 2;
            this.labelDetalleFactura.Text = "DETALLE FACTURA";
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.Location = new System.Drawing.Point(345, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(269, 20);
            this.TITULO.TabIndex = 1;
            this.TITULO.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // panelDatosCliente
            // 
            this.panelDatosCliente.Controls.Add(this.comboBox1);
            this.panelDatosCliente.Controls.Add(this.labelEstadoFactura);
            this.panelDatosCliente.Controls.Add(this.dateTimePicker1);
            this.panelDatosCliente.Controls.Add(this.labelFecha);
            this.panelDatosCliente.Controls.Add(this.txtTotalFactura);
            this.panelDatosCliente.Controls.Add(this.txtIVA);
            this.panelDatosCliente.Controls.Add(this.txtDescuento);
            this.panelDatosCliente.Controls.Add(this.comboBoxEmpleado);
            this.panelDatosCliente.Controls.Add(this.comboBoxCliente);
            this.panelDatosCliente.Controls.Add(this.txtNroFactura);
            this.panelDatosCliente.Controls.Add(this.labelEmpleado);
            this.panelDatosCliente.Controls.Add(this.labelCliente);
            this.panelDatosCliente.Controls.Add(this.labelNroFactura);
            this.panelDatosCliente.Location = new System.Drawing.Point(21, 50);
            this.panelDatosCliente.Name = "panelDatosCliente";
            this.panelDatosCliente.Size = new System.Drawing.Size(698, 243);
            this.panelDatosCliente.TabIndex = 2;
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
            this.comboBox1.Location = new System.Drawing.Point(423, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // labelEstadoFactura
            // 
            this.labelEstadoFactura.AutoSize = true;
            this.labelEstadoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoFactura.Location = new System.Drawing.Point(420, 100);
            this.labelEstadoFactura.Name = "labelEstadoFactura";
            this.labelEstadoFactura.Size = new System.Drawing.Size(120, 16);
            this.labelEstadoFactura.TabIndex = 19;
            this.labelEstadoFactura.Text = "Estado Facturas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(423, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(420, 19);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(113, 16);
            this.labelFecha.TabIndex = 17;
            this.labelFecha.Text = "Fecha Registro";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "Total Factura";
            this.txtTotalFactura.Location = new System.Drawing.Point(32, 208);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(267, 28);
            this.txtTotalFactura.TabIndex = 16;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // txtIVA
            // 
            this.txtIVA.Depth = 0;
            this.txtIVA.Hint = "Total Iva";
            this.txtIVA.Location = new System.Drawing.Point(32, 174);
            this.txtIVA.MaxLength = 32767;
            this.txtIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.PasswordChar = '\0';
            this.txtIVA.SelectedText = "";
            this.txtIVA.SelectionLength = 0;
            this.txtIVA.SelectionStart = 0;
            this.txtIVA.Size = new System.Drawing.Size(267, 28);
            this.txtIVA.TabIndex = 15;
            this.txtIVA.TabStop = false;
            this.txtIVA.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(38, 140);
            this.txtDescuento.MaxLength = 32767;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(267, 28);
            this.txtDescuento.TabIndex = 14;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEmpleado.Location = new System.Drawing.Point(181, 110);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(118, 24);
            this.comboBoxEmpleado.TabIndex = 13;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCliente.Location = new System.Drawing.Point(181, 73);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(118, 24);
            this.comboBoxCliente.TabIndex = 12;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(181, 19);
            this.txtNroFactura.Multiline = true;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(118, 36);
            this.txtNroFactura.TabIndex = 11;
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.Location = new System.Drawing.Point(35, 110);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(78, 16);
            this.labelEmpleado.TabIndex = 3;
            this.labelEmpleado.Text = "Empleado";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(35, 71);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 16);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente";
            // 
            // labelNroFactura
            // 
            this.labelNroFactura.AutoSize = true;
            this.labelNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroFactura.Location = new System.Drawing.Point(35, 33);
            this.labelNroFactura.Name = "labelNroFactura";
            this.labelNroFactura.Size = new System.Drawing.Size(88, 16);
            this.labelNroFactura.TabIndex = 1;
            this.labelNroFactura.Text = "Nro Factura";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(739, 69);
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
            this.btnSalir.Location = new System.Drawing.Point(756, 370);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFacturas
            // 
            this.ClientSize = new System.Drawing.Size(900, 565);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panelDatosCliente);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.panelDetallesFactura);
            this.Name = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load_1);
            this.panelDetallesFactura.ResumeLayout(false);
            this.panelDetallesFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDatosCliente.ResumeLayout(false);
            this.panelDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmFacturas_Load_1(object sender, EventArgs e)
        {
            CargarClientes();
            CargarEmpleados();
            CargarEstados();
            CargarFacturas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNroFactura.Text) ||
                    comboBoxCliente.SelectedValue == null ||
                    comboBoxEmpleado.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtTotalFactura.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios.");
                    return;
                }

                // Construir sentencia SQL
                string sentencia = $@"
            INSERT INTO TBLFACTURA 
            (Fecha, IdCliente, IdEmpleado, NumDescuento, NumFactura, MontoTotal, FechaModifica, STSUsuarioModifica)
            VALUES 
            ('{dateTimePicker1.Value:yyyy-MM-dd}', 
             {comboBoxCliente.SelectedValue}, 
             {comboBoxEmpleado.SelectedValue}, 
             {txtDescuento.Text}, 
             {txtNroFactura.Text}, 
             {txtTotalFactura.Text}, 
             GETDATE(), 
             '{Environment.UserName}')";

                // Ejecutar comando usando tu clase Acceso_datos
                string resultado = datos.EjecutarComando(sentencia);

                // Mostrar resultado
                MessageBox.Show(resultado);

                // Refrescar la tabla de facturas
                CargarFacturas();

                // Limpiar campos
                txtNroFactura.Clear();
                txtDescuento.Clear();
                txtIVA.Clear();
                txtTotalFactura.Clear();
                comboBoxCliente.SelectedIndex = -1;
                comboBoxEmpleado.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la factura: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}