using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        public int C_IdProducto { get; set; }
        public string C_StrNombre { get; set; }
        public string C_StrCodigo { get; set; }
        public double C_NumPrecioCompra { get; set; }
        public double C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_StrFoto { get; set; }
        public int C_NumStock { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        // Consultar todos los productos
        public DataTable ConsultaProductos()
        {
            try
            {
                string sentencia = "SELECT * FROM TBLPRODUCTO";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch
            {
                return null;
            }
        }

        // Consultar producto por ID
        public DataTable ConsultaProducto(int IdProducto)
        {
            try
            {
                string sentencia = $"SELECT * FROM TBLPRODUCTO WHERE IdProducto = {IdProducto}";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch
            {
                return null;
            }
        }

        // Filtrar productos por nombre
        public DataTable Filtrar_Producto(string filtro)
        {
            try
            {
                string sentencia = $"SELECT * FROM TBLPRODUCTO WHERE StrNombre LIKE '%{filtro}%'";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch
            {
                return null;
            }
        }

        // Eliminar producto
        public string EliminarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>
                {
                    new Cls_Parametros("@IdProducto", C_IdProducto)
                };
                mensaje = AccesoDatos.Ejecutar_Procedimiento("eliminar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Error al eliminar el producto. " + ex.Message;
            }
            return mensaje;
        }

        // Insertar o actualizar producto
        public string ActualizarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>
                {
                    new Cls_Parametros("@IdProducto", C_IdProducto),
                    new Cls_Parametros("@StrNombre", C_StrNombre),
                    new Cls_Parametros("@StrCodigo", C_StrCodigo),
                    new Cls_Parametros("@NumPrecioCompra", C_NumPrecioCompra),
                    new Cls_Parametros("@NumPrecioVenta", C_NumPrecioVenta),
                    new Cls_Parametros("@IdCategoria", C_IdCategoria),
                    new Cls_Parametros("@StrDetalle", C_StrDetalle),
                    new Cls_Parametros("@StrFoto", C_StrFoto),
                    new Cls_Parametros("@NumStock", C_NumStock),
                    new Cls_Parametros("@DtmFechaModifica", DateTime.Now),
                    new Cls_Parametros("@StrUsuarioModifica", C_StrUsuarioModifica)
                };
                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el producto. " + ex.Message;
            }
            return mensaje;
        }
    }
}
