using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patalla_sistemaDeFacturación
{
    public partial class frmEditarClientes : MaterialForm
    {
        public frmEditarClientes()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; } // ATRIBUTO QUE PERMITE RECIBIR COMO PARAMETRO EL iDcLIENTE
        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
        private void LLENAR_CLIENTE()
        {
            if (IdCliente == 0)
            {
                //REGISTRO NUEVO
                labelTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                // ACTUALIZAR EL REGISTRO CON EL ID PASADO
                string sentencia = $"select * from TBLCLIENTES where IdCliente = {IdCliente}"; // CONSULTO REGISTRO DEL iDcLIENTE
                dt = Acceso.EjecutarComandoDatos(sentencia);
                if (dt != null && dt.Rows.Count > 0)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO 

                        txtIdCliente.Text = IdCliente.ToString();
                        xtNombre.Text = row[1].ToString();
                        xtDocumento.Text = row[2].ToString();
                        xtDireccion.Text = row[3].ToString();
                        xtTelefono.Text = row[4].ToString();
                        xtEmail.Text = row[5].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente con el ID proporcionado.");
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void frmEditarClientes_Load(object sender, EventArgs e)
        {
            LLENAR_CLIENTE();
        }

        // ************************************** ACTUALIZACIONES*****************************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    string sentencia = $"Exec [actualizar_Cliente] {IdCliente},'{xtNombre.Text}',{xtDocumento.Text} ,'{xtDireccion.Text}','{xtTelefono.Text}', '{xtEmail.Text}','Javier','{fecha}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (xtNombre.Text == string.Empty)
            {
                MensajeError.SetError(xtNombre, "debe ingresar el nombre del Cliente");
                xtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(xtNombre, ""); }
            if (xtDocumento.Text == "")
            {
                MensajeError.SetError(xtDocumento, "debe ingresar el documento");
                xtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(xtDocumento, ""); }

            if (!esNumerico(xtDocumento.Text))
            {
                MensajeError.SetError(xtDocumento, "El Documento debe ser numerico");
                xtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(xtDocumento, "");
            return errorCampos;
        }
        //función para validar si un valor dado es numerico
        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btActualizar_Click(object sender, EventArgs e)
        {
            Guardar();

        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}