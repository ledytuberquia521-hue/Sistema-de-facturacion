using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Clientes
    {
        public int C_IdCliente { get; set; }
        public string C_StrNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        // Consultar todos los clientes
        public DataTable ConsultaClientes()
        {
            try
            {
                string sentencia = "SELECT * FROM TBLCLIENTES";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch
            {
                return null;
            }
        }

        // Consultar cliente por ID
        public DataTable ConsultaCliente(int IdCliente)
        {
            try
            {
                string sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = {IdCliente}";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch
            {
                return null;
            }
        }

        // Filtrar por nombre
        public DataTable Filtrar_Cliente(string filtro)
        {
            try
            {
                string sentencia = $"SELECT * FROM TBLCLIENTES WHERE StrNombre LIKE '%{filtro}%'";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch
            {
                return null;
            }
        }

        // Eliminar cliente
        public string EliminarCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>
                {
                    new Cls_Parametros("@IdCliente", C_IdCliente)
                };
                mensaje = AccesoDatos.Ejecutar_Procedimiento("eliminar_Cliente", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Error al eliminar el cliente. " + ex.Message;
            }
            return mensaje;
        }

        // Insertar o actualizar cliente
        public string ActualizarCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>
                {
                    new Cls_Parametros("@IdCliente", C_IdCliente),
                    new Cls_Parametros("@StrNombre", C_StrNombre),
                    new Cls_Parametros("@NumDocumento", C_NumDocumento),
                    new Cls_Parametros("@StrDireccion", C_StrDireccion),
                    new Cls_Parametros("@StrTelefono", C_StrTelefono),
                    new Cls_Parametros("@StrEmail", C_StrEmail),
                    new Cls_Parametros("@DtmFechaModifica", DateTime.Now),
                    new Cls_Parametros("@StrUsuarioModifica", C_StrUsuarioModifica)
                };
                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Cliente", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el cliente. " + ex.Message;
            }
            return mensaje;
        }
    }
}
