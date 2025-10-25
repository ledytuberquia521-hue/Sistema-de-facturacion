using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Patalla_sistemaDeFacturación
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        public int id_producto { get; set; } // 0 = nuevo producto
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LLENAR_PRODUCTO();
        }

        private void CargarCategorias()
        {
            try
            {
                string consulta = "SELECT IdCategoria, CAST(IdCategoria AS VARCHAR) + ' - ' + StrDescripcion AS CategoriaDesc FROM TBLCATEGORIA_PROD";
                DataTable dtCategorias = Acceso.EjecutarComandoDatos(consulta);

                comboBox1.DataSource = dtCategorias;
                comboBox1.DisplayMember = "CategoriaDesc";  // Visible
                comboBox1.ValueMember = "IdCategoria";      // Valor real
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void LLENAR_PRODUCTO()
        {
            if (id_producto == 0)
            {
                labelProductos.Text = "INGRESAR NUEVO PRODUCTO";
                LimpiarCampos();
            }
            else
            {
                string sentencia = $"SELECT * FROM TBLPRODUCTO WHERE IdProducto = {id_producto}";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtCodReferencia.Text = row["StrCodigo"].ToString();
                    txtNomProducto.Text = row["StrNombre"].ToString();
                    txtPreCompras.Text = row["NumPrecioCompra"].ToString();
                    txtPreVentas.Text = row["NumPrecioVenta"].ToString();
                    txtCanStock.Text = row["NumStock"].ToString();
                    txtDetalle.Text = row["StrDetalle"].ToString();
                    txtRutaImagen.Text = row["strFoto"].ToString();

                    comboBox1.SelectedValue = Convert.ToInt32(row["IdCategoria"]);
                    labelProductos.Text = "EDITAR PRODUCTO";
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con el ID proporcionado.");
                }
            }
        }

        // Limpia los campos para un nuevo producto
        private void LimpiarCampos()
        {
            txtCodReferencia.Clear();
            txtNomProducto.Clear();
            txtPreCompras.Clear();
            txtPreVentas.Clear();
            txtCanStock.Clear();
            txtDetalle.Clear();
            //txtRutaImagen.Clear();
            comboBox1.SelectedIndex = -1;
            errorProvider1.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarProducto())
            {
                // Recargar para reflejar cambios
                if (id_producto == 0)
                {
                    // Si es nuevo, quizás resetear formulario para otro ingreso
                    LimpiarCampos();
                }
                else
                {
                    // Recargar datos del producto editado
                    LLENAR_PRODUCTO();
                }
            }
        }

        private bool GuardarProducto()
        {
            if (ValidarCampos())
            {
                try
                {
                    string storedProcedure = id_producto == 0 ? "insertar_Producto" : "actualizar_Producto";

                    SqlParameter[] parameters;
                    if (id_producto == 0)
                    {
                        parameters = new SqlParameter[]
                        {
        new SqlParameter("@StrNombre", txtNomProducto.Text),
        new SqlParameter("@StrCodigo", txtCodReferencia.Text),
        new SqlParameter("@NumPrecioCompra", Convert.ToDecimal(txtPreCompras.Text)),
        new SqlParameter("@NumPrecioVenta", Convert.ToDecimal(txtPreVentas.Text)),
        new SqlParameter("@IdCategoria", Convert.ToInt32(comboBox1.SelectedValue)),
        new SqlParameter("@StrDetalle", txtDetalle.Text),
        new SqlParameter("@strFoto", txtRutaImagen.Text),
        new SqlParameter("@NumStock", Convert.ToInt32(txtCanStock.Text)),

        // Agrega estos dos parámetros obligatorios
      new SqlParameter("@DtmFechaModifica", DateTime.Now),

        new SqlParameter("@StrUsuarioModifica", "UsuarioAdmin")  // Cambia si tienes un usuario real
                        };
                    }
                    else
                    {
                        // Parámetros para actualizar (igual que antes, asegúrate de incluir todos)
                        parameters = new SqlParameter[]
                        {
        new SqlParameter("@IdProducto", id_producto),
        new SqlParameter("@StrNombre", txtNomProducto.Text),
        new SqlParameter("@StrCodigo", txtCodReferencia.Text),
        new SqlParameter("@NumPrecioCompra", Convert.ToDecimal(txtPreCompras.Text)),
        new SqlParameter("@NumPrecioVenta", Convert.ToDecimal(txtPreVentas.Text)),
        new SqlParameter("@IdCategoria", Convert.ToInt32(comboBox1.SelectedValue)),
        new SqlParameter("@StrDetalle", txtDetalle.Text),
        new SqlParameter("@strFoto", txtRutaImagen.Text),
        new SqlParameter("@NumStock", Convert.ToInt32(txtCanStock.Text)),
        new SqlParameter("@DtmFechaModifica", DateTime.Now),
        new SqlParameter("@StrUsuarioModifica", "UsuarioAdmin")
                        };
                    }


                    string mensaje = Acceso.EjecutarComandoSP(storedProcedure, parameters);
                    MessageBox.Show(mensaje);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message);
                }
            }
            return false;
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;

            if (string.IsNullOrWhiteSpace(txtNomProducto.Text))
            {
                errorProvider1.SetError(txtNomProducto, "Debe ingresar el nombre del producto.");
                camposValidos = false;
            }
            else
                errorProvider1.SetError(txtNomProducto, "");

            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Debe seleccionar una categoría.");
                camposValidos = false;
            }
            else
                errorProvider1.SetError(comboBox1, "");

            if (!decimal.TryParse(txtPreVentas.Text, out _))
            {
                errorProvider1.SetError(txtPreVentas, "El precio debe ser numérico.");
                camposValidos = false;
            }
            else
                errorProvider1.SetError(txtPreVentas, "");

            if (!int.TryParse(txtCanStock.Text, out _))
            {
                errorProvider1.SetError(txtCanStock, "El stock debe ser un número entero.");
                camposValidos = false;
            }
            else
                errorProvider1.SetError(txtCanStock, "");

            return camposValidos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e); // reutiliza el método Guardar
        }

        // Otros eventos innecesarios por ahora
        private void panelproductos_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
