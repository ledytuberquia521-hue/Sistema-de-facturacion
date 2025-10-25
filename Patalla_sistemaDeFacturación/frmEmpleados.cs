using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Patalla_sistemaDeFacturación
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; internal set; }
        DataTable dt = new DataTable(); // data table para consultar datos
        Cls_Empleados empleado = new Cls_Empleados(); // instancia de la clase empleado 

        

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            llenar_combo ();
            if (IdEmpleado == 0)
           {
                //registro nuevo
                lblTitulo.Text = "INGRESE NUEVO EMPLEADO";
            }

          else
            { //actualizar el registro id que se recibe
                lblTitulo.Text = "ACTUALIZAR EMPLEADO";
                llenar_campos();//llenar los campos con lo que se tiene en la base de datos

            }
              

        }

        //llenar combo roles
        private void llenar_combo()
        {

            cboRol.DataSource = empleado.Consulta_RolEmpleado();//invocamos metodo de consulta del rol
            cboRol.DisplayMember = "StrDescripcion"; // informacion del nombre del rol
            cboRol.ValueMember = "IdRolEmpleado"; // lo que se guarda
        }

        // consulta de tabla empleados para llenar los campos

        private void llenar_campos()
        {
            dt = empleado.Consulta_Empleado(IdEmpleado); // EJECUTAMOS LA CONSULTA
            if (dt.Rows.Count > 0) //verifico si retorno valores
            {
                foreach (DataRow row in dt.Rows) // RECORREMOS EL DATATABLE PARA CARGAR LOS CAMPOS
                {
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                    //seleccionamos en la lista el rol de acuerdo al valor que se tiene
                    cboRol.SelectedValue = int.Parse(row[6].ToString());
                    dtmIngreso.Value = Convert.ToDateTime(row[7].ToString());
                    dtmRetiro.Value = Convert.ToDateTime(row[8].ToString());
                    txtDatosAdicionales.Text = row[9].ToString();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        // funciones que permiten el ingreso o actualización de la información de empleados en la base de datos
        public void Guardar()
        {
            string mensaje = "";
            if (validar())  // funcion que Valida la informacion de los campos
            {
                empleado.C_IdEmpleado = IdEmpleado;
                empleado.C_StrNombre = txtNombre.Text;
                empleado.C_NumDocumento = double.Parse(txtDocumento.Text);
                empleado.C_StrDireccion = txtDireccion.Text;
                empleado.C_StrTelefono = txtTelefono.Text;
                empleado.C_StrEmail = txtEmail.Text;
                empleado.C_IdRolEmpleado = int.Parse(cboRol.SelectedValue.ToString());
                empleado.C_DtmIngreso = dtmIngreso.Value;
                empleado.C_DtmRetiro = dtmRetiro.Value;
                //empleado.C_DtmIngreso = dtmIngreso.Text;
                //empleado.C_DtmRetiro = dtmRetiro.Text;
                empleado.C_strDatosAdicionales = txtDatosAdicionales.Text;
                empleado.C_StrUsuarioModifico = "javier";
                empleado.C_DtmFechaModifica = DateTime.Now;
                mensaje = empleado.ActualizarEmpleado(); // invocamos el metodo de actualizar informacion de empleados
                MessageBox.Show(mensaje);
            }
        }

        //FUNCIÓN QUE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "debe ingresar el nombre del empleado");
                txtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombre, ""); }

            if (txtDocumento.Text == "")
            {
                MensajeError.SetError(txtDocumento, "debe ingresar el documento");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocumento, ""); }

            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numérico");
                txtDocumento.Focus();
                return false;
            }

            MensajeError.SetError(txtDocumento, "");
            return errorCampos;
        }
        private bool esNumerico (string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }

            catch(Exception)
            {
                return false;
            }
        }
        private void txtNomEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // verificamos si desea cerrar la ventana

            DialogResult Rta;
            Rta = MessageBox.Show("desea salir de la edición?", "MENSAJE DE ADVERTENCIA",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
