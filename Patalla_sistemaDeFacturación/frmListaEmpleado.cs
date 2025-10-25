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
    public partial class frmListaEmpleado : Form
    {
        public frmListaEmpleado()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable(); // data table para consultar datos
        Cls_Empleados empleado = new Cls_Empleados(); // instancia de la clase empleado

        // consulta de tabla empleados para llenar el grid

          
      //  private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
       // {

        //}

        private void AdminClientes_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
        private void llenar_grid()
        {
            dgEmpleados.Rows.Clear(); // LIMPIAMOS EL GRID
            dt = empleado.ConsultaEmpleado(); // EJECUTAMOS LA CONSULTA

            if (dt.Rows.Count > 0) //verifico si retorno valores
            {
                foreach (DataRow row in dt.Rows) // RECORREMOS EL DATATABLE PARA CARGAR EL GRID

                    dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());//llanamos el grid
            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")// valido que el campo no este vacio
            {
                dgEmpleados.Rows.Clear(); // LIMPIAMOS EL GRID
                dt = empleado.Filtrar_Empleado(txtBuscar.Text); // EJECUTAMOS LA CONSULTA

                if (dt.Rows.Count > 0) //verifico si retorno valores
                {
                    foreach (DataRow row in dt.Rows) // RECORREMOS EL DATATABLE PARA CARGAR EL GRID
                        dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());//llanamos el grid
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            else
            {
                llenar_grid();
            }
            txtBuscar.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleados Empleado = new frmEmpleados();
            Empleado.IdEmpleado = 0;
            Empleado.ShowDialog();
            llenar_grid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita errores si se hace clic fuera de las filas válidas
            if (e.RowIndex < 0)
                return;

            // Verificar si el clic fue en la columna "EDITAR"
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Obtener el ID del empleado seleccionado
                int idEmpleado = Convert.ToInt32(dgEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value);

                // Abrir el formulario de empleados con los datos del empleado seleccionado
                frmEmpleados frm = new frmEmpleados();
                frm.IdEmpleado = idEmpleado;
                frm.ShowDialog();

                // Actualizar el grid después de editar
                llenar_grid();
            }

            // Verificar si el clic fue en la columna "BORRAR"
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int idEmpleado = Convert.ToInt32(dgEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value);

                DialogResult confirm = MessageBox.Show("¿Desea eliminar este empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    empleado.C_IdEmpleado = idEmpleado; // 👈 asignas el id
                    string mensaje = empleado.EliminaEmpleado(); // 👈 ya no le pasas parámetros
                    MessageBox.Show(mensaje);
                    llenar_grid();
                }

            }

        }

    }
}
