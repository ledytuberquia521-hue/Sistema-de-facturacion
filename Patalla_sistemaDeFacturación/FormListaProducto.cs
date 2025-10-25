
using System;
using System.Data;
using System.Windows.Forms;

namespace Patalla_sistemaDeFacturación
{
    public partial class FormListaProducto : Form
    {
        public FormListaProducto()
        {
            InitializeComponent();
        }

        DataTable dt;
        Acceso_datos Acceso = new Acceso_datos();

        private void FormListaProducto_Load(object sender, EventArgs e)
        {
            llenar_grid();
         }

       

        private void llenar_grid()
        {
            try
            {
                dgProductos.Rows.Clear();

                string sentencia = "SELECT IdProducto, StrNombre, NumPrecioVenta, IdCategoria, NumStock FROM TBLPRODUCTO";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos.");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    dgProductos.Rows.Add(
                        row["IdProducto"],
                        row["StrNombre"],
                        row["NumPrecioVenta"],
                        row["IdCategoria"],
                        row["NumStock"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgProductos.Rows.Clear();
                string filtro = txtBuscar.Text.Trim();

                string sentencia;
                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sentencia = $"SELECT IdProducto, StrNombre, NumPrecioVenta, IdCategoria, NumStock FROM TBLPRODUCTO WHERE StrNombre LIKE '%{filtro}%'";
                }
                else
                {
                    sentencia = "SELECT IdProducto, StrNombre, NumPrecioVenta, IdCategoria, NumStock FROM TBLPRODUCTO";
                }

                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    dgProductos.Rows.Add(
                        row["IdProducto"],
                        row["StrNombre"],
                        row["NumPrecioVenta"],
                        row["IdCategoria"],
                        row["NumStock"]
                    );
                }

                txtBuscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int pos = dgProductos.CurrentRow.Index;
                frmProductos producto = new frmProductos();
                producto.id_producto = Convert.ToInt32(dgProductos[0, pos].Value);
                producto.ShowDialog();
                llenar_grid();
            }

            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int pos = dgProductos.CurrentRow.Index;

                if (MessageBox.Show("¿Seguro que desea borrar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdProducto = Convert.ToInt32(dgProductos[0, pos].Value);
                    string sentencia = $"EXEC BORRAR_PRODUCTO {IdProducto}";
                    string mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(mensaje);
                    llenar_grid();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos nuevoProducto = new frmProductos();
            nuevoProducto.id_producto = 0;
            nuevoProducto.ShowDialog();
            llenar_grid();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            {
                if (txtBuscar.Text != "")
                {
                    dgProductos.Rows.Clear(); // LIMPIAMOS EL GRID
                    string sentencia = $"select * from TBLPRODUCTO where strNombre like '%{txtBuscar.Text}%'"; // CONSULTA SQL
                    dt = Acceso.EjecutarComandoDatos(sentencia); // EJECUTAMOS LA CONSULTA
                    foreach (DataRow row in dt.Rows) { dgProductos.Rows.Add(row["IdProducto"], row["StrNombre"], row["NumPrecioVenta"], row["IdCategoria"], row["NumStock"]); }// RECORREMOS EL DATATABLE PARA CARGAR EL GRID
                    txtBuscar.Text = "";
                }
                else
                {
                    llenar_grid();
                }
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            {
                frmProductos Producto = new frmProductos();
                Producto.id_producto = 0;
                Producto.ShowDialog();
                llenar_grid();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
