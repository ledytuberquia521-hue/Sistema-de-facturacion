using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;


namespace Patalla_sistemaDeFacturación
{
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable(); // data table para consultar datos
        Cls_Seguridad SeguridadEmpleado = new Cls_Seguridad(); // instancia de la clase seguridad
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();

        }
        private void llenar_combo_Empleados()
        {
            cboEmpleado.DataSource = SeguridadEmpleado.ConsultarEmpleado();//invocamos metodo de consulta del rol
            cboEmpleado.DisplayMember = "StrNombre"; // informacion del nombre del rol
            cboEmpleado.ValueMember = "IdEmpleado"; // lo que se guarda

        }
        //funcion para consultar seguridad del empleado

        //CODIGO PARA CONSULTAR LA SEGURIDAD DEL EMPLEADO CORREGIDO
        public void Consultar()
        {
            // Validar que haya un empleado seleccionado ANTES de intentar usar SelectedValue
            if (cboEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un empleado.");
                return;
            }

            try
            {
                int IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());

                // Ejecutar la consulta
                dt = SeguridadEmpleado.Consulta_seguridadEmpleado(IdEmpleado);

                // Verificar que no sea null y tenga registros
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        txtUsuario.Text = row["StrUsuario"].ToString();
                        txtClave.Text = row["StrClave"].ToString();
                    }
                }
                else
                {
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    MessageBox.Show("No se le ha asignado usuario y clave a este empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la seguridad del empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        //funcion que permite guardar los datos de ingreso a un usuario
        public void Guardar()          

        {
            string mensaje = "";
            if (validar()) // funcion que valida la informacion de los campos

            {

                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                SeguridadEmpleado.C_StrUsuario = txtUsuario.Text;
                SeguridadEmpleado.C_StrClave = txtClave.Text;
                SeguridadEmpleado.C_StrUsuarioModifico ="javier";
                SeguridadEmpleado.C_DtmFechaModifica = DateTime.Now;
                mensaje = SeguridadEmpleado.ActualizarSeguridadEmpleado(); // invocamos el metodo actualizar
                MessageBox.Show(mensaje);
            }
            txtClave.Text = "";
            txtUsuario.Text = "";
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        //funcion que permite eliminar la seguridad de un empleado
        public void Eliminar()
        {
            //preguntamos si esta seguro de eliminar

            if (MessageBox.Show($"¿ESTA SEGURO DE BORRAR EL REGISTRO DE: \n {cboEmpleado.Text} ?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //pasamos el id del empleado a eliminar
                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                string mensaje = SeguridadEmpleado.EliminarSeguridadEmpleado(); // invocamos el metodo eliminar
                if (mensaje != "")
                    MessageBox.Show(mensaje);
                else
                MessageBox.Show($"BORRANDO EL REGISTRO");
                txtClave.Text = "";
                txtUsuario.Text = "";
            }
        }
        //FUNCION QUE VALIDA LOS CAMPOS REQUERIDOS
        private bool validar()
        {
            // Validar que se haya seleccionado un empleado
            if (cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el usuario no esté vacío
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            // Validar que la clave no esté vacía
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una clave.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            return true; // Todo correcto
        }

    }

}