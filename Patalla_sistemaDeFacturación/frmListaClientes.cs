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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos    

        private void llenar_grid()
        {
            dgClientes.Rows.Clear(); // LIMPIAMOS EL GRID
              string sentencia = "select * from TBLCLIENTES"; // CONSULTA SQL
                dt = Acceso.EjecutarComandoDatos(sentencia); // EJECUTAMOS LA CONSULTA
            foreach (DataRow row in dt.Rows) // RECORREMOS EL DATATABLE PARA CARGAR EL GRID
                {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }


        private void frmListaClientes_Load_1(object sender, EventArgs e)
        {
            llenar_grid();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el botón que se presionó
            {
                int posActual = dgClientes.CurrentRow.Index; // verifico cuál fila fue seleccionada

                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO índice {e.RowIndex} ID {dgClientes[0, posActual].Value}");
                    int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value); // capturamos el ID del cliente a borrar
                    String sentencia = $"Exec BORRAR_CLIENTE {IdCliente}"; // creamos la sentencia SQL
                    string Mensaje = Acceso.EjecutarComando(sentencia); // ejecutamos la sentencia
                    MessageBox.Show(Mensaje); // mostramos el mensaje de confirmación   

                }
            }
        

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presionó un botón editar
            {
                int posActual = dgClientes.CurrentRow.Index; // tomamos la fila seleccionada
                frmEditarClientes Cliente = new frmEditarClientes(); // instanciamos el formulario
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString()); // pasamos el ID
                Cliente.ShowDialog(); // mostramos el formulario en forma modal
            }
            llenar_grid(); // recargamos el grid
        }

              

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmEditarClientes Cliente = new frmEditarClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            llenar_grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgClientes.Rows.Clear(); // LIMPIAMOS EL GRID
                string sentencia = $"select * from TBLCLIENTES where strNombre like '%{txtBuscar.Text}%'"; // CONSULTA SQL
                dt = Acceso.EjecutarComandoDatos(sentencia); // EJECUTAMOS LA CONSULTA
                foreach (DataRow row in dt.Rows) { dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]); }// RECORREMOS EL DATATABLE PARA CARGAR EL GRID
                  txtBuscar.Text = "";
                }
            else
            {
                llenar_grid();
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminClientes_Click(object sender, EventArgs e)
        {

       }
    }
}
